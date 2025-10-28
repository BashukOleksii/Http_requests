using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using SubscriptionManager.API.Controllers; // Ваш контролер
using SubscriptionManager.API.IServices;    // Ваш інтерфейс
using SubscriptionManager.Core.Models;     // Ваші моделі
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq; // Потрібен для Enumerable.Empty

/// <summary>
/// Юніт-тести для класу <see cref="SubController"/>.
/// </summary>
public class SubControllerTests
{
    /// <summary>
    /// Фальшива (мок) версія сервісу ISubService.
    /// </summary>
    private readonly Mock<ISubService> _mockService;

    /// <summary>
    /// Екземпляр контролера, який ми тестуємо (System Under Test).
    /// </summary>
    private readonly SubController _controller;

    /// <summary>
    /// Конструктор тестів, який виконує спільне налаштування (Arrange)
    /// для кожного тестового методу.
    /// </summary>
    public SubControllerTests()
    {
        _mockService = new Mock<ISubService>();
        _controller = new SubController(_mockService.Object);
    }

    #region Тести для GetAll()

    /// <summary>
    /// Тест: GetAll() має повернути HTTP 200 (Ok) та список підписок,
    /// якщо сервіс знаходить підписки.
    /// </summary>
    [Fact]
    public async Task GetAll_WhenSubsExist_ShouldReturnOk200AndSubList()
    {
        // Arrange
        var subList = new List<SubscriptionItem>
        {
            new SubscriptionItem { Id = "1", Service = "Netflix" },
            new SubscriptionItem { Id = "2", Service = "Spotify" }
        };

        // "Навчаємо" мок-сервіс повертати список
        _mockService.Setup(s => s.GetAllAsync()).ReturnsAsync(subList);

        // Act
        var result = await _controller.GetAll();

        // Assert
        // 1. Перевіряємо, що результат має тип OkObjectResult (HTTP 200 з даними)
        var okResult = Assert.IsType<OkObjectResult>(result.Result);

        // 2. Перевіряємо, що дані всередині - це наш список
        var returnValue = Assert.IsType<List<SubscriptionItem>>(okResult.Value);
        Assert.Equal(2, returnValue.Count);
    }

    /// <summary>
    /// Тест: GetAll() має повернути HTTP 404 (NotFound),
    /// якщо сервіс кидає виняток KeyNotFoundException.
    /// </summary>
    [Fact]
    public async Task GetAll_WhenServiceThrowsKeyNotFound_ShouldReturnNotFound404()
    {
        // Arrange
        // "Навчаємо" сервіс кидати виняток, який контролер повинен зловити
        _mockService.Setup(s => s.GetAllAsync())
                    .ThrowsAsync(new KeyNotFoundException("Не знайдено підписки"));

        // Act
        var result = await _controller.GetAll();

        // Assert
        // 1. Перевіряємо, що результат має тип NotFoundObjectResult (HTTP 404)
        var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);

        // 2. Перевіряємо, що повідомлення про помилку було передано
        Assert.Equal("Не знайдено підписки", notFoundResult.Value);
    }

    #endregion

    #region Тести для GetById()

    /// <summary>
    /// Тест: GetById() має повернути HTTP 200 (Ok) та одну підписку,
    /// якщо її знайдено.
    /// </summary>
    [Fact]
    public async Task GetById_WhenSubExists_ShouldReturnOk200AndSub()
    {
        // Arrange
        var expectedSub = new SubscriptionItem { Id = "123", Service = "Netflix" };
        _mockService.Setup(s => s.GetByIdAsync("123")).ReturnsAsync(expectedSub);

        // Act
        var result = await _controller.GetById("123");

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnValue = Assert.IsType<SubscriptionItem>(okResult.Value);
        Assert.Equal("Netflix", returnValue.Service);
    }

    /// <summary>
    /// Тест: GetById() має повернути HTTP 404 (NotFound),
    /// якщо сервіс кидає виняток KeyNotFoundException для цього ID.
    /// </summary>
    [Fact]
    public async Task GetById_WhenServiceThrowsKeyNotFound_ShouldReturnNotFound404()
    {
        // Arrange
        _mockService.Setup(s => s.GetByIdAsync("bad-id"))
                    .ThrowsAsync(new KeyNotFoundException("Не знайдено"));

        // Act
        var result = await _controller.GetById("bad-id");

        // Assert
        var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);
        Assert.Equal("Не знайдено", notFoundResult.Value);
    }

    #endregion
}
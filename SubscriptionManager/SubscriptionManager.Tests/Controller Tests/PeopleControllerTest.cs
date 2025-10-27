using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using SubscriptionManager.API.Controllers;
using SubscriptionManager.API.IServices;
using SubscriptionManager.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq; 

/// <summary>
/// Юніт-тести для класу <see cref="PeopleController"/>.
/// </summary>
public class PeopleControllerTests
{
    /// <summary>
    /// Фальшива (мок) версія сервісу IPeopleService.
    /// </summary>
    private readonly Mock<IPeopleService> _mockService;

    /// <summary>
    /// Екземпляр контролера, який ми тестуємо (System Under Test).
    /// </summary>
    private readonly PeopleController _controller;

    /// <summary>
    /// Конструктор тестів, який виконує спільне налаштування (Arrange)
    /// для кожного тестового методу.
    /// </summary>
    public PeopleControllerTests()
    {
        _mockService = new Mock<IPeopleService>();
        _controller = new PeopleController(_mockService.Object);
    }

    #region Тести для GetAll()

    /// <summary>
    /// Тест: GetAll() має повернути HTTP 200 (Ok) та список користувачів,
    /// якщо сервіс знаходить користувачів.
    /// </summary>
    [Fact]
    public async Task GetAll_WhenPeopleExist_ShouldReturnOk200AndPeopleList()
    {
        // Arrange
        var peopleList = new List<PeopleItem>
        {
            new PeopleItem { Id = "1", Name = "User One" },
            new PeopleItem { Id = "2", Name = "User Two" }
        };

        // "Навчаємо" мок-сервіс повертати список
        _mockService.Setup(s => s.GetAllAsync()).ReturnsAsync(peopleList);

        // Act
        var result = await _controller.GetAll();

        // Assert
        // 1. Перевіряємо, що результат має тип OkObjectResult (HTTP 200 з даними)
        var okResult = Assert.IsType<OkObjectResult>(result.Result);

        // 2. Перевіряємо, що дані всередині - це наш список
        var returnValue = Assert.IsType<List<PeopleItem>>(okResult.Value);
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
                    .ThrowsAsync(new KeyNotFoundException("Список порожній"));

        // Act
        var result = await _controller.GetAll();

        // Assert
        // 1. Перевіряємо, що результат має тип NotFoundObjectResult (HTTP 404)
        var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);

        // 2. Перевіряємо, що повідомлення про помилку було передано
        Assert.Equal("Список порожній", notFoundResult.Value);
    }

    #endregion

    #region Тести для GetById()

    /// <summary>
    /// Тест: GetById() має повернути HTTP 200 (Ok) та одного користувача,
    /// якщо користувача знайдено.
    /// </summary>
    [Fact]
    public async Task GetById_WhenPersonExists_ShouldReturnOk200AndPerson()
    {
        // Arrange
        var person = new PeopleItem { Id = "123", Name = "Test User" };
        _mockService.Setup(s => s.GetByIdAsync("123")).ReturnsAsync(person);

        // Act
        var result = await _controller.GetById("123");

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnValue = Assert.IsType<PeopleItem>(okResult.Value);
        Assert.Equal("Test User", returnValue.Name);
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
        Assert.IsType<NotFoundObjectResult>(result.Result);
    }

    #endregion

    #region Тести для Create()

    /// <summary>
    /// Тест: Create() має повернути HTTP 201 (CreatedAtAction),
    /// коли користувача успішно створено.
    /// </summary>
    [Fact]
    public async Task Create_WhenCalled_ShouldReturnCreatedAtAction201()
    {
        // Arrange
        var newPerson = new PeopleItem { Id = "new-id", Name = "New Person" };

        _mockService.Setup(s => s.CreateAsync(newPerson))
                    .Returns(Task.CompletedTask);

        // Act
        var result = await _controller.Create(newPerson);

        // Assert
        var createdResult = Assert.IsType<CreatedAtActionResult>(result);
        Assert.Equal(newPerson, createdResult.Value);
        Assert.Equal(nameof(PeopleController.GetById), createdResult.ActionName);
        Assert.Equal("new-id", createdResult.RouteValues["Id"]);
    }

    #endregion

    #region Тести для Update()

    /// <summary>
    /// Тест: Update() має повернути HTTP 204 (NoContent),
    /// якщо оновлення пройшло успішно.
    /// </summary>
    [Fact]
    public async Task Update_WhenUpdateIsSuccessful_ShouldReturnNoContent204()
    {
        // Arrange
        var personToUpdate = new PeopleItem { Name = "Updated Name" };
        string id = "existing-id";

        // Налаштовуємо мок, щоб він успішно завершив завдання
        _mockService.Setup(s => s.UpdateAsync(id, personToUpdate))
                    .Returns(Task.CompletedTask);

        // Act
        var result = await _controller.Update(id, personToUpdate);

        // Assert
        // Перевіряємо, що результат - це HTTP 204
        Assert.IsType<NoContentResult>(result);
    }

    /// <summary>
    /// Тест: Update() має повернути HTTP 404 (NotFound),
    /// якщо сервіс кидає KeyNotFoundException.
    /// </summary>
    [Fact]
    public async Task Update_WhenServiceThrowsKeyNotFound_ShouldReturnNotFound404()
    {
        // Arrange
        var personToUpdate = new PeopleItem { Name = "Updated Name" };
        string id = "non-existing-id";

        // "Навчаємо" сервіс кидати виняток
        _mockService.Setup(s => s.UpdateAsync(id, personToUpdate))
                    .ThrowsAsync(new KeyNotFoundException("ID не знайдено"));

        // Act
        var result = await _controller.Update(id, personToUpdate);

        // Assert
        // Перевіряємо, що результат - це HTTP 404
        var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
        Assert.Equal("ID не знайдено", notFoundResult.Value);
    }

    #endregion

    #region Тести для Delete()

    /// <summary>
    /// Тест: Delete() має повернути HTTP 204 (NoContent),
    /// якщо видалення пройшло успішно.
    /// </summary>
    [Fact]
    public async Task Delete_WhenDeleteIsSuccessful_ShouldReturnNoContent204()
    {
        // Arrange
        string id = "existing-id";

        // Налаштовуємо мок, щоб він успішно завершив завдання
        _mockService.Setup(s => s.DeleteAsync(id))
                    .Returns(Task.CompletedTask);

        // Act
        var result = await _controller.Delete(id);

        // Assert
        // Перевіряємо, що результат - це HTTP 204
        Assert.IsType<NoContentResult>(result);
    }

    /// <summary>
    /// Тест: Delete() має повернути HTTP 404 (NotFound),
    /// якщо сервіс кидає KeyNotFoundException.
    /// </summary>
    [Fact]
    public async Task Delete_WhenServiceThrowsKeyNotFound_ShouldReturnNotFound404()
    {
        // Arrange
        string id = "non-existing-id";

        // "Навчаємо" сервіс кидати виняток
        _mockService.Setup(s => s.DeleteAsync(id))
                    .ThrowsAsync(new KeyNotFoundException("ID не знайдено"));

        // Act
        var result = await _controller.Delete(id);

        // Assert
        // Перевіряємо, що результат - це HTTP 404
        var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
        Assert.Equal("ID не знайдено", notFoundResult.Value);
    }

    #endregion
}
using Moq;
using Xunit;
using SubscriptionManager.API.Services;     // Ваш SubService
using SubscriptionManager.Core.Interfaces;  // Ваші інтерфейси
using SubscriptionManager.Core.Models;      // Ваші моделі
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq; // Потрібен для Enumerable.Empty

/// <summary>
/// Юніт-тести для класу <see cref="SubService"/>.
/// </summary>
public class SubServiceTests
{
    /// <summary>
    /// Фальшива (мок) версія репозиторію підписок.
    /// </summary>
    private readonly Mock<ISubRepository> _mockSubRepo;

    /// <summary>
    /// Фальшива (мок) версія репозиторію користувачів.
    /// </summary>
    private readonly Mock<IPeopleRepository> _mockPeopleRepo;

    /// <summary>
    /// Екземпляр сервісу, який ми тестуємо (System Under Test).
    /// </summary>
    private readonly SubService _service;

    /// <summary>
    /// Конструктор тестів, який виконує спільне налаштування (Arrange)
    /// для кожного тестового методу.
    /// </summary>
    //public SubServiceTests()
    //{
    //    _mockSubRepo = new Mock<ISubRepository>();
    //    _mockPeopleRepo = new Mock<IPeopleRepository>(); // Цей мок потрібен для конструктора

    //    // Впроваджуємо обидві фальшиві залежності
    //    _service = new SubService(_mockSubRepo.Object, _mockPeopleRepo.Object);
    //}


    /// <summary>
    /// Тест: "щасливий шлях" для GetAllAsync.
    /// Перевіряє, що сервіс повертає список, якщо він не порожній.
    /// </summary>
    [Fact]
    public async Task GetAllAsync_WhenSubsExist_ShouldReturnSubList()
    {
        // Arrange
        var subList = new List<SubscriptionItem>
        {
            new SubscriptionItem { Id = "1" },
            new SubscriptionItem { Id = "2" }
        };

        // "Навчаємо" репозиторій повертати список
        _mockSubRepo.Setup(s => s.GetAllAsync()).ReturnsAsync(subList);

        // Act
        var result = await _service.GetAllAsync();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(subList, result);
    }

    /// <summary>
    /// Тест: "сумний шлях" для GetAllAsync.
    /// Перевіряє, що сервіс кидає KeyNotFoundException, якщо репозиторій повертає порожній список.
    /// </summary>
    [Fact]
    public async Task GetAllAsync_WhenRepoReturnsEmptyList_ShouldThrowKeyNotFoundException()
    {
        // Arrange
        var emptyList = Enumerable.Empty<SubscriptionItem>();

        // "Навчаємо" репозиторій повертати порожній список
        _mockSubRepo.Setup(s => s.GetAllAsync()).ReturnsAsync(emptyList);

        // Act & Assert
        // Перевіряємо, що наш 'if (!subs.Any())' спрацював
        await Assert.ThrowsAsync<KeyNotFoundException>(
            () => _service.GetAllAsync()
        );
    }

    /// <summary>
    /// Тест: "сумний шлях" для GetAllAsync.
    /// Перевіряє, що сервіс кидає KeyNotFoundException, якщо репозиторій повертає null.
    /// </summary>
    [Fact]
    public async Task GetAllAsync_WhenRepoReturnsNull_ShouldThrowKeyNotFoundException()
    {
        // Arrange
        // "Навчаємо" репозиторій повертати null
        _mockSubRepo.Setup(s => s.GetAllAsync())
                    .ReturnsAsync((IEnumerable<SubscriptionItem>)null);

        // Act & Assert
        // Перевіряємо, що наш 'if (subs is null)' спрацював
        await Assert.ThrowsAsync<KeyNotFoundException>(
            () => _service.GetAllAsync()
        );
    }



    /// <summary>
    /// Тест: CreateAsync має кидати NotImplementedException.
    /// </summary>
    [Fact]
    public async Task CreateAsync_WhenCalled_ShouldThrowNotImplementedException()
    {
        // Act & Assert
        await Assert.ThrowsAsync<NotImplementedException>(
            () => _service.CreateAsync(new SubscriptionItem())
        );
    }

    /// <summary>
    /// Тест: DeleteAsync має кидати NotImplementedException.
    /// </summary>
    [Fact]
    public async Task DeleteAsync_WhenCalled_ShouldThrowNotImplementedException()
    {
        // Act & Assert
        await Assert.ThrowsAsync<NotImplementedException>(
            () => _service.DeleteAsync("any-id")
        );
    }

    /// <summary>
    /// Тест: UpdateAsync має кидати NotImplementedException.
    /// </summary>
    [Fact]
    public async Task UpdateAsync_WhenCalled_ShouldThrowNotImplementedException()
    {
        // Act & Assert
        await Assert.ThrowsAsync<NotImplementedException>(
            () => _service.UpdateAsync("any-id", new SubscriptionItem())
        );
    }

}
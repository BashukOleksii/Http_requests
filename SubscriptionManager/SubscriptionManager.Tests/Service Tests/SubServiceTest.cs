//using Moq;
//using Xunit;
//using SubscriptionManager.API.Services;     // Ваш SubService
//using SubscriptionManager.Core.Interfaces;  // Ваші інтерфейси
//using SubscriptionManager.Core.Models;      // Ваші моделі
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Linq;
//using System; // Потрібен для Exception

///// <summary>
///// Юніт-тести для класу <see cref="SubService"/>.
///// </summary>
//public class SubServiceTests
//{
//    /// <summary>
//    /// Фальшива (мок) версія репозиторію підписок.
//    /// </summary>
//    private readonly Mock<ISubRepository> _mockSubRepo;

//    /// <summary>
//    /// Фальшива (мок) версія репозиторію користувачів.
//    /// </summary>
//    private readonly Mock<IPeopleRepository> _mockPeopleRepo;

//    /// <summary>
//    /// Екземпляр сервісу, який ми тестуємо (System Under Test).
//    /// </summary>
//    private readonly SubService _service;

//    /// <summary>
//    /// Конструктор тестів, який виконує спільне налаштування (Arrange)
//    /// для кожного тестового методу.
//    /// </summary>
//    public SubServiceTests()
//    {
//        _mockSubRepo = new Mock<ISubRepository>();
//        _mockPeopleRepo = new Mock<IPeopleRepository>(); // Цей мок потрібен для конструктора

//        // Впроваджуємо обидві фальшиві залежності
//        _service = new SubService(_mockSubRepo.Object, _mockPeopleRepo.Object);
//    }

//    // --- Тести для GetAllAsync (Ваші оригінальні, вони коректні) ---

//    [Fact]
//    public async Task GetAllAsync_WhenSubsExist_ShouldReturnSubList()
//    {
//        // Arrange
//        var subList = new List<SubscriptionItem>
//        {
//            new SubscriptionItem { Id = "1" },
//            new SubscriptionItem { Id = "2" }
//        };
//        _mockSubRepo.Setup(s => s.GetAllAsync()).ReturnsAsync(subList);

//        // Act
//        var result = await _service.GetAllAsync();

//        // Assert
//        Assert.NotNull(result);
//        Assert.Equal(2, result.Count());
//        Assert.Equal(subList, result);
//    }

//    [Fact]
//    public async Task GetAllAsync_WhenRepoReturnsEmptyList_ShouldThrowKeyNotFoundException()
//    {
//        // Arrange
//        var emptyList = Enumerable.Empty<SubscriptionItem>();
//        _mockSubRepo.Setup(s => s.GetAllAsync()).ReturnsAsync(emptyList);

//        // Act & Assert
//        await Assert.ThrowsAsync<KeyNotFoundException>(
//            () => _service.GetAllAsync()
//        );
//    }

//    [Fact]
//    public async Task GetAllAsync_WhenRepoReturnsNull_ShouldThrowKeyNotFoundException()
//    {
//        // Arrange
//        _mockSubRepo.Setup(s => s.GetAllAsync())
//                    .ReturnsAsync((IEnumerable<SubscriptionItem>)null);

//        // Act & Assert
//        await Assert.ThrowsAsync<KeyNotFoundException>(
//            () => _service.GetAllAsync()
//        );
//    }

//    // --- Тести для GetByIdAsync ---

//    [Fact]
//    public async Task GetByIdAsync_WhenSubExists_ShouldReturnSub()
//    {
//        // Arrange
//        var subId = "existing-id";
//        var expectedSub = new SubscriptionItem { Id = subId, aName = "Test Sub" };
//        _mockSubRepo.Setup(s => s.GetByIdAsync(subId)).ReturnsAsync(expectedSub);

//        // Act
//        var result = await _service.GetByIdAsync(subId);

//        // Assert
//        Assert.NotNull(result);
//        Assert.Equal(expectedSub, result);
//    }

//    [Fact]
//    public async Task GetByIdAsync_WhenSubDoesNotExist_ShouldThrowKeyNotFoundException()
//    {
//        // Arrange
//        var subId = "non-existing-id";
//        _mockSubRepo.Setup(s => s.GetByIdAsync(subId))
//                    .ReturnsAsync((SubscriptionItem)null); // Репозиторій повертає null

//        // Act & Assert
//        await Assert.ThrowsAsync<KeyNotFoundException>(
//            () => _service.GetByIdAsync(subId)
//        );
//    }

//    // --- Тести для CreateAsync ---

//    [Fact]
//    public async Task CreateAsync_WhenOwnerExists_ShouldCallRepoCreateAsync()
//    {
//        // Arrange
//        var ownerId = "valid-owner-id";
//        var newSub = new SubscriptionItem { Id = "new-sub", OwnerId = ownerId };

//        // Навчаємо мок PeopleRepository, що власник існує
//        _mockPeopleRepo.Setup(p => p.IsExist(ownerId)).ReturnsAsync(true);

//        // Act
//        await _service.CreateAsync(newSub);

//        // Assert
//        // Перевіряємо, що метод CreateAsync репозиторію підписок був викликаний 1 раз
//        // з правильним об'єктом
//        _mockSubRepo.Verify(s => s.CreateAsync(newSub), Times.Once());
//    }

//    [Fact]
//    public async Task CreateAsync_WhenOwnerDoesNotExist_ShouldThrowArgumentException()
//    {
//        // Arrange
//        var ownerId = "invalid-owner-id";
//        var newSub = new SubscriptionItem { Id = "new-sub", OwnerId = ownerId };

//        // Навчаємо мок PeopleRepository, що власник НЕ існує
//        _mockPeopleRepo.Setup(p => p.IsExist(ownerId)).ReturnsAsync(false);

//        // Act & Assert
//        await Assert.ThrowsAsync<ArgumentException>(
//            () => _service.CreateAsync(newSub)
//        );

//        // Переконуємось, що CreateAsync репозиторію НЕ був викликаний
//        _mockSubRepo.Verify(s => s.CreateAsync(It.IsAny<SubscriptionItem>()), Times.Never());
//    }

//    // --- Тести для UpdateAsync ---

//    [Fact]
//    public async Task UpdateAsync_WhenSubAndOwnerExist_ShouldCallRepoUpdateAsync()
//    {
//        // Arrange
//        var subId = "existing-sub-id";
//        var ownerId = "valid-owner-id";
//        var subToUpdate = new SubscriptionItem { Id = subId, OwnerId = ownerId };

//        _mockSubRepo.Setup(s => s.IsExist(subId)).ReturnsAsync(true);
//        _mockPeopleRepo.Setup(p => p.IsExist(ownerId)).ReturnsAsync(true);

//        // Act
//        await _service.UpdateAsync(subId, subToUpdate);

//        // Assert
//        _mockSubRepo.Verify(s => s.UpdateAsync(subId, subToUpdate), Times.Once());
//    }

//    [Fact]
//    public async Task UpdateAsync_WhenSubDoesNotExist_ShouldThrowKeyNotFoundException()
//    {
//        // Arrange
//        var subId = "non-existing-sub-id";
//        var subToUpdate = new SubscriptionItem { Id = subId, OwnerId = "any-owner" };

//        _mockSubRepo.Setup(s => s.IsExist(subId)).ReturnsAsync(false); // Підписка НЕ існує

//        // Act & Assert
//        await Assert.ThrowsAsync<KeyNotFoundException>(
//            () => _service.UpdateAsync(subId, subToUpdate)
//        );

//        // Переконуємось, що UpdateAsync репозиторію НЕ був викликаний
//        _mockSubRepo.Verify(s => s.UpdateAsync(It.IsAny<string>(), It.IsAny<SubscriptionItem>()), Times.Never());
//    }

//    [Fact]
//    public async Task UpdateAsync_WhenSubExistsButOwnerIsInvalid_ShouldThrowArgumentException()
//    {
//        // Arrange
//        var subId = "existing-sub-id";
//        var ownerId = "invalid-owner-id";
//        var subToUpdate = new SubscriptionItem { Id = subId, OwnerId = ownerId };

//        _mockSubRepo.Setup(s => s.IsExist(subId)).ReturnsAsync(true); // Підписка існує
//        _mockPeopleRepo.Setup(p => p.IsExist(ownerId)).ReturnsAsync(false); // Власник НЕ існує

//        // Act & Assert
//        await Assert.ThrowsAsync<ArgumentException>(
//            () => _service.UpdateAsync(subId, subToUpdate)
//        );

//        // Переконуємось, що UpdateAsync репозиторію НЕ був викликаний
//        _mockSubRepo.Verify(s => s.UpdateAsync(It.IsAny<string>(), It.IsAny<SubscriptionItem>()), Times.Never());
//    }

//    // --- Тести для DeleteAsync ---

//    [Fact]
//    public async Task DeleteAsync_WhenSubExists_ShouldCallRepoDeleteAsync()
//    {
//        // Arrange
//        var subId = "existing-id";
//        _mockSubRepo.Setup(s => s.IsExist(subId)).ReturnsAsync(true);

//        // Act
//        await _service.DeleteAsync(subId);

//        // Assert
//        // !!! ЗВЕРНІТЬ УВАГУ: У вашому SubService метод називається 'DeletAsynce' (з 'e')
//        // Якщо ви виправите це на 'DeleteAsync', цей тест впаде, і його треба буде оновити.
//        _mockSubRepo.Verify(s => s.DeletAsynce(subId), Times.Once());
//    }

//    [Fact]
//    public async Task DeleteAsync_WhenSubDoesNotExist_ShouldThrowKeyNotFoundException()
//    {
//        // Arrange
//        var subId = "non-existing-id";
//        _mockSubRepo.Setup(s => s.IsExist(subId)).ReturnsAsync(false);

//        // Act & Assert
//        await Assert.ThrowsAsync<KeyNotFoundException>(
//            () => _service.DeleteAsync(subId)
//        );

//        // Переконуємось, що 'DeletAsynce' репозиторію НЕ був викликаний
//        _mockSubRepo.Verify(s => s.DeletAsynce(It.IsAny<string>()), Times.Never());
//    }
//}
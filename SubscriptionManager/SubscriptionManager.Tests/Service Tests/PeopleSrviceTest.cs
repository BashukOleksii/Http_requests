using Moq;
using Xunit;
using SubscriptionManager.API.Services;     
using SubscriptionManager.Core.Interfaces;  
using SubscriptionManager.Core.Models;      
using System.Linq; 

public class PeopleServiceTests
{
    private readonly Mock<IPeopleRepository> _mockRepo;
    private readonly PeopleService _service;

    public PeopleServiceTests()
    {
        _mockRepo = new Mock<IPeopleRepository>();
        _service = new PeopleService(_mockRepo.Object);
    }

    /// <summary>
    ///     Checks that CreateAsync in PeopleService calls CreateAsync in IPeopleRepository
    /// </summary>
    [Fact]
    public async Task CreateAsync_WhenCalled_ShouldCallRepositoryCreateAsync()
    {
        // Arrange
        var person = new PeopleItem { Name = "Test" };

        _mockRepo.Setup(r => r.CreateAsync(person))
                 .Returns(Task.CompletedTask);

        // Act
        await _service.CreateAsync(person);

        // Assert
        _mockRepo.Verify(r => r.CreateAsync(person), Times.Once());
    }

    /// <summary>
    ///     Checks that GetByIdAsync returns the person when they exist
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task GetByIdAsync_WhenPersonExists_ShouldReturnPerson()
    {
        // Arrange
        var expectedPerson = new PeopleItem { Id = "123", Name = "Found Me" };

        _mockRepo.Setup(r => r.GetByIdAsync("123"))
                 .ReturnsAsync(expectedPerson);

        // Act
        var actualPerson = await _service.GetByIdAsync("123");

        // Assert
        Assert.Equal(expectedPerson, actualPerson);
    }

    /// <summary>
    ///     Checks that GetByIdAsync throws KeyNotFoundException when person does not exist
    /// </summary>
    [Fact]
    public async Task GetByIdAsync_WhenPersonDoesNotExist_ShouldThrowKeyNotFoundException()
    {
        // Arrange
        _mockRepo.Setup(r => r.GetByIdAsync("bad-id"))
                 .ReturnsAsync((PeopleItem)null);

        // Act & Assert
        await Assert.ThrowsAsync<KeyNotFoundException>(
            () => _service.GetByIdAsync("bad-id")
        );
    }

    /// <summary>
    ///     Checks that GetAllAsync throws KeyNotFoundException when no people exist
    /// </summary>
    [Fact]
    public async Task GetAllAsync_WhenNoPeopleExist_ShouldThrowKeyNotFoundException()
    {
        // Arrange
        var emptyList = Enumerable.Empty<PeopleItem>();

        _mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(emptyList);

        // Act & Assert
        await Assert.ThrowsAsync<KeyNotFoundException>(
            () => _service.GetAllAsync()
        );
    }
}
using FluentValidation.TestHelper;
using SubscriptionManager.API.Validators; 
using SubscriptionManager.Core.Models;  
using Xunit;

// Припустимо, що у вас є такий enum (або схожий)
// public enum SubscriptionStatus { Active, Inactive, Canceled }

/// <summary>
/// Юніт-тести для класу SubscriptionValidator>.
/// </summary>
public class SubscriptionValidatorTests
{
    private readonly SubscriptioValidator _validator;

    /// <summary>
    /// Конструктор тестів, який виконує спільне налаштування (Arrange)
    /// для кожного тестового методу.
    /// </summary>
    public SubscriptionValidatorTests()
    {
        _validator = new SubscriptioValidator();
    }

    /// <summary>
    /// Тест: "щасливий шлях".
    /// Перевіряє, що повністю валідний об'єкт не має жодних помилок.
    /// </summary>
    [Fact]
    public void Validate_WithValidSubscription_ShouldNotHaveAnyErrors()
    {
        // Arrange
        var subscription = new SubscriptionItem
        {
            OwnerId = "valid-owner-id",
            Service = "Netflix",
            Status = SubStatus.Active // Припускаємо, що 'Active' - валідне значення
        };

        // Act
        var result = _validator.TestValidate(subscription);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }

    /// <summary>
    /// Тест: "сумний шлях" для OwnerId.
    /// Перевіряє, що виникає помилка, якщо OwnerId порожній.
    /// </summary>
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Validate_WhenOwnerIdIsEmptyOrNull_ShouldHaveValidationError(string invalidOwnerId)
    {
        // Arrange
        var subscription = new SubscriptionItem
        {
            OwnerId = invalidOwnerId,
            Service = "Valid Service",
            Status = SubStatus.Active
        };

        // Act
        var result = _validator.TestValidate(subscription);

        // Assert
        result.ShouldHaveValidationErrorFor(sub => sub.OwnerId)
              .WithErrorMessage("Для підписки неохідно вказати власника");
    }

    /// <summary>
    /// Тест: "сумний шлях" для Service.
    /// Перевіряє всі невалідні стани (порожній, занадто короткий, занадто довгий).
    /// </summary>
    [Theory]
    [InlineData(null, "Поле не може бути порожнім")]
    [InlineData("", "Поле не може бути порожнім")]
    [InlineData("a", "Поле має бути в межах [3;30]")] // Занадто короткий
    [InlineData("This Service Name Is Definitely Way Too Long For The Validation Rule",
                   "Поле має бути в межах [3;30]")] // Занадто довгий
    public void Validate_WhenServiceIsInvalid_ShouldHaveValidationError(string invalidService, string expectedError)
    {
        // Arrange
        var subscription = new SubscriptionItem
        {
            OwnerId = "valid-owner-id",
            Service = invalidService,
            Status = SubStatus.Active
        };

        // Act
        var result = _validator.TestValidate(subscription);

        // Assert
        result.ShouldHaveValidationErrorFor(sub => sub.Service)
              .WithErrorMessage(expectedError);
    }

    /// <summary>
    /// Тест: "сумний шлях" для Status.
    /// Перевіряє, що виникає помилка, якщо Status не є валідним значенням Enum.
    /// </summary>
    [Fact]
    public void Validate_WhenStatusIsNotInEnum_ShouldHaveValidationError()
    {
        // Arrange
        var subscription = new SubscriptionItem
        {
            OwnerId = "valid-owner-id",
            Service = "Valid Service",
            // Присвоюємо значення, якого точно немає в enum
            Status = (SubStatus)99
        };

        // Act
        var result = _validator.TestValidate(subscription);

        // Assert
        result.ShouldHaveValidationErrorFor(sub => sub.Status)
              .WithErrorMessage("Значення має бути в вказаному переліку");
    }
}
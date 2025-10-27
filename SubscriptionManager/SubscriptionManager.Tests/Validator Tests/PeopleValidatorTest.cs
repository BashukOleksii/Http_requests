using FluentValidation.TestHelper;
using SubscriptionManager.API.Validators;
using SubscriptionManager.Core.Models;
using Xunit;

/// <summary>
/// Тести для валідатора PeopleValidator.
/// </summary>
public class PeopleValidatorTests
{
    private readonly PeopleValidator _validator;

    public PeopleValidatorTests()
    {
        _validator = new PeopleValidator();
    }

    /// <summary>
    /// Happy path: Verificate, that a fully valid object
    /// has no validation errors.
    /// </summary>
    [Fact]
    public void Validate_WithValidPerson_ShouldNotHaveAnyErrors()
    {
        // Arrange
        var person = new PeopleItem
        {
            Name = "Validname",
            Email = "valid@email.com"
        };

        // Act
        var result = _validator.TestValidate(person);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }

    /// <summary>
    /// Sad path: Checks all invalid states for the ‘Name’ property.
    /// </summary>
    [Theory]
    [InlineData("")]
    [InlineData("lower")]
    [InlineData("Short")]
    [InlineData("Toolongnameee")]
    [InlineData("With Space")]
    [InlineData("Invalid!")]
    public void Validate_WithInvalidName_ShouldHaveValidationErrorForName(string invalidName)
    {
        // Arrange
        var person = new PeopleItem
        {
            Name = invalidName,
            Email = "valid@email.com"
        };

        // Act
        var result = _validator.TestValidate(person);

        // Assert
        result.ShouldHaveValidationErrorFor(p => p.Name);
    }

    /// <summary>
    /// Sad path: Checks all invalid states for the ‘Email’ property.
    /// </summary>
    [Theory]
    [InlineData("")]
    [InlineData("bad-email")]
    [InlineData("user.com")]
    [InlineData("@example.com")]
    public void Validate_WithInvalidEmail_ShouldHaveValidationErrorForEmail(string invalidEmail)
    {
        // Arrange
        var person = new PeopleItem
        {
            Name = "Validname",
            Email = invalidEmail
        };

        // Act
        var result = _validator.TestValidate(person);

        // Assert
        result.ShouldHaveValidationErrorFor(p => p.Email);
    }
}
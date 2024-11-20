using Domain.Entities;
using FluentValidation;
using JetBrains.Annotations;
using Xunit;

namespace Domain.Tests.Entities;

[TestSubject(typeof(Drug))]
public class DrugTest
{

    [Fact]
    public void Drug_WithValidData_ShouldPassValidation()
    {
        // Arrange
        var countrty = new Country("USA", "US");

        // Act & Assert
        var exception = Record.Exception(() => new Drug("Aspirin","China-Inc","RU", countrty));

        // Assert
        Assert.Null(exception); // Ожидаем, что исключение не будет выброшено
    }
    
    [Fact]
    public void Drug_WithInvalidData_ShouldThrowValidationException()
    {
        // Act & Assert
        var exception = Assert.Throws<ValidationException>(() => new Drug("Aspirin","","ZZ", null));
    }
}
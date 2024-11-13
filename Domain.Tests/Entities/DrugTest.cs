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
        var drug = new Drug("Aspirin","China-Inc","RU", countrty);
        // Инициализация DrugStoreNumbers для теста


        // Act & Assert
        var exception = Record.Exception(() => drug.Validate());

        // Assert
        Assert.Null(exception); // Ожидаем, что исключение не будет выброшено
    }
    
    [Fact]
    public void Drug_WithInvalidData_ShouldThrowValidationException()
    {
        // Act & Assert
        var exception = Assert.Throws<ValidationException>(() => new Drug("Aspirin","","ZZ", null));
        Assert.Contains(" Manufacturer должен содержать только буквы, пробелы и дефисы.", exception.Message);
    }
}
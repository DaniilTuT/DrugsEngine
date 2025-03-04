﻿using Domain.Entities;
using FluentValidation;
using JetBrains.Annotations;
using Xunit;

namespace Domain.Tests.Entities;

[TestSubject(typeof(Country))]
public class CountryTest
{
    /// <summary>
    /// Положительный юнит тест для Country 
    /// </summary>
    [Fact]
    public void Country_WithValidData_ShouldPassValidation()
    {
        // Arrange
        new Country("USA", "US");
        // Инициализация DrugStoreNumbers для теста


        // Act & Assert
        var exception = Record.Exception(() => new Country("USA", "US"));

        // Assert
        Assert.Null(exception); // Ожидаем, что исключение не будет выброшено
    }
    
    /// <summary>
    ///  Негативный юнит тест для Country
    /// </summary>
    [Fact]
    public void Country_WithInvalidData_ShouldThrowValidationException()
    {
        // Act & Assert
        var exception = Assert.Throws<ValidationException>(() => new Country("","efEEFEFE"));
        Assert.Contains("содержит недействительный код страны", exception.Message);
    }

}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Entities;
using Domain.Validators.Primitives;
using Domain.ValueObjects;
using FluentValidation;
using JetBrains.Annotations;
using Xunit;

namespace Domain.Tests.Entities;

[TestSubject(typeof(DrugItem))]
public class DrugItemTest
{
    
    [Fact]
    public void DrugItem_WithValidData_ShouldPassValidation()
    {
        // Arrange
        ExistingDrugStoreNumbers.DrugStoreNumbers["PharmaNetwork"] = new HashSet<int> { };
        var address = new Address("Sample City", "Main Street", "US", 12345);
        var drugStore = new DrugStore(address, 1, "123-456-7890", "PharmaNetwork");
        var countrty = new Country("USA", "US");
        var drug = new Drug("Aspirin","China-Inc","RU", countrty);
        var drugItem = new DrugItem(Guid.NewGuid(), Guid.NewGuid(), 3, (decimal)1515.45, drug, drugStore);
        // Инициализация DrugStoreNumbers для теста


        // Act & Assert
        var exception = Record.Exception(() => drugItem.Validate());

        // Assert
        Assert.Null(exception); // Ожидаем, что исключение не будет выброшено
        //Trace.WriteLine(drugItem.Cost);
    }
    
    [Fact]
    public void DrugItem_WithInvalidData_ShouldThrowValidationException()
    {
        // Act & Assert
        ExistingDrugStoreNumbers.DrugStoreNumbers["PharmaNetwork"] = new HashSet<int> { };
        var address = new Address("Sample City", "Main Street", "US", 12345);
        var drugStore = new DrugStore(address, 1, "123-456-7890", "PharmaNetwork");
        var countrty = new Country("USA", "US");
        var drug = new Drug("Aspirin","China-Inc","RU", countrty);
        var exception = Assert.Throws<ValidationException>(() => new DrugItem(Guid.Empty, Guid.Empty, 2, (decimal)54.355, drug, drugStore));
        Assert.Contains("Cost должен быть положительным числом", exception.Message);
    }
}
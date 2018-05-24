//using Microsoft.AspNetCore.Mvc;

//using SalaryCapData.Data.Models;
//using SalaryCapData.Interfaces;

//using System.Collections.Generic;

//using Xunit;


//namespace SalaryCapGames.Tests
//{
//    public class FranchiseControllerTests
//    {
//        [Fact]
//        public void IndexActionModelIsComplete()
//        {
//            class ModelCompleteFakeRepo : IFranchise


//        // Arrange
//        var controller = new FranchisesController();
//        // Act
//        var model = (controller.Index() as ViewResult)?
//            .ViewData.Model as IEnumerable<Franchise>;
//        // Assert
//        Assert.Equal(SimpleRepository.SharedRepository.Products, model,
//Comparer.Get<Franchise>((p1, p2) => p1.Name == p2.Name
// && p1.Price == p2.Price ) );
//            }
//}
//}
//}

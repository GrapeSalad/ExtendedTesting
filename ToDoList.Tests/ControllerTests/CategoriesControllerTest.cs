using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoListWithMigrations.Controllers;
using ToDoListWithMigrations.Models;
using Xunit;

namespace ToDoListWithMigrations.Tests
{
    public class CategoriesControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            CategoriesController controller = new CategoriesController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        //[Fact]
        //public void Get_ModelList_Index_Test()
        //{
        //    //Arrange
        //    CategoriesController controller = new CategoriesController();
        //    IActionResult actionResult = controller.Index();
        //    ViewResult indexView = controller.Index() as ViewResult;

        //    //ViewResult indexView = new CategoriesController().Index() as ViewResult;

        //    //Act
        //    var result = indexView.ViewData.Model;

        //    //Assert
        //    Assert.IsType<List<Item>>(result);
        //}
    }
}
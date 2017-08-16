using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ToDoListJD.Controllers;
using ToDoListJD.Models;
using Xunit;

namespace ToDoList.Tests
{
    class ItemsControllerTest
    {
		[Fact]
		public void Get_ViewResult_Index_Test()
		{
			//Arrange
			ItemsController controller = new ItemsController();

			//Act
			var result = controller.Index();

			//Assert
			Assert.IsType<ViewResult>(result);
		}
		[Fact]
		public void Get_ModelList_Index_Test()
		{
			//Arrange
			ItemsController controller = new ItemsController();
			IActionResult actionResult = controller.Index();
			ViewResult indexView = controller.Index() as ViewResult;

			//Act
			var result = indexView.ViewData.Model;

			//Assert
			Assert.IsType<List<Item>>(result);
		}
	}
}

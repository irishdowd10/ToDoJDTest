using System;
using System.Collections.Generic;
using System.Text;
using ToDoListJD.Models;
using ToDoListJD.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Tests
{
	public class ItemTest
	{
		[Fact]
		public void GetDescriptionTest()
		{
			//Arrange
			var item = new Item();

			//Act
			var result = item.Description;

			//Assert
			Assert.Equal("Wash the dog", result);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListJD.Models;
using Xunit;

namespace ToDoListJD.Tests
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

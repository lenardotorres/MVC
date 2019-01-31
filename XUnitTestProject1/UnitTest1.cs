using System;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using MVC_Login_Test.Controllers;
using MVC_Login_Test.Models;
using System.Threading.Tasks;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var controller = new MoviesController(null);
            var result = await controller.Index("horror", "") as MovieGenreViewModel;
            Assert.Equal("horror", result.MovieGenre);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Wk_UnitTest.FakeService;
using WKBackend.Controllers;
using WKBackend.Model;
using WKBackend.Repository;
using Xunit;

namespace Wk_UnitTest
{
    public class FormControllerTest
    {
        private readonly FormController _formController;
        private readonly IFormsRepository _formsRepository;
        public FormControllerTest()
        {
            _formsRepository = new FormServiceFake();
            _formController = new FormController(_formsRepository);
        }

        [Fact]
        public async void Get_whenCalled_ReturnOkResult()
        {
            var okResult = await _formController.GetForms();
            _ = Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
        [Fact]
        public async void checkCoutForForm()
        {
            // Act
            var okResult = await _formController.GetForms() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Form>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
        [Fact]
        public async void Get_FormWithCount()
        {
            // Act
            var okResult = await _formController.GetForms() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Form>>(okResult.Value);
            Assert.Equal(2, items.Count);
        }
    }
}

﻿namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    using System.Linq;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            //: this(new JustMockCarsRepository())
            : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void Index_ShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCar_IfCarIsNull_ShouldThrowArgumentNullException()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCar_IfCarMakeIsNull_ShouldThrowArgumentNullException()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCar_ShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCar_ShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void Details_ShouldNotThrowException()
        {
            var model = (Car)this.GetModel(() => this.controller.Details(1));
        }

        public void Search_ShouldReturnResults()
        {
            var expected = "BMW";
            var actual = (ICollection<Car>)GetModel(() => this.controller.Search("random"));

            Assert.AreEqual(expected, actual.First().Make);
        }

        [TestMethod]
        public void Sort_ByYear_ShouldReturnSortedCollectionByYear()
        {
            var expected = 2010;
            var actual = (ICollection<Car>)GetModel(() => this.controller.Sort("year"));

            Assert.AreEqual(expected, actual.First().Year);
        }

        [TestMethod]
        public void Sort_ByMake_ShouldReturnSortedCollectionByYear()
        {
            var expected = "Audi";
            var actual = (ICollection<Car>)GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual(expected, actual.First().Make);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_WithInvalidString_ShouldThrow()
        {
            GetModel(() => this.controller.Sort("invalid"));
        }


        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}

using ANW.ComposerApp.Interfaces;
using ANW.ComposerApp.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using ANW.ComposerApp.Models;
using System;

namespace ANW.ComposerTests.Helpers.ComposerDetailsHelperTests
{
    [TestClass]
    public class GetComposerTests
    {
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void NoComposer()
        {
            var dataMock = new Mock<IComposerDataHelper>();
            var returnData = new List<Composer>
            {
                new Composer
                {
                    Id = 1,
                    FirstName = "Terry",
                    LastName = "Devine King",
                    Title = "Mr",
                    Awards = "Grammy 2006"
                }
            };

            dataMock.Setup(x => x.GetComposerData()).Returns(returnData);

            var composerDetailsHelper = new ComposerDetailsHelper(dataMock.Object);

            composerDetailsHelper.GetComposer(2);
        }

        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void MoreThanOneReturned()
        {
            var dataMock = new Mock<IComposerDataHelper>();
            var returnData = new List<Composer>
            {
                new Composer
                {
                    Id = 1,
                    FirstName = "Terry",
                    LastName = "Devine King",
                    Title = "Mr",
                    Awards = "Grammy 2006"
                },
                new Composer
                {
                    Id = 1,
                    FirstName = "Terry",
                    LastName = "Devine King",
                    Title = "Mr",
                    Awards = "Grammy 2006"
                }
            };

            dataMock.Setup(x => x.GetComposerData()).Returns(returnData);

            var composerDetailsHelper = new ComposerDetailsHelper(dataMock.Object);

            composerDetailsHelper.GetComposer(2);
        }
    }
}

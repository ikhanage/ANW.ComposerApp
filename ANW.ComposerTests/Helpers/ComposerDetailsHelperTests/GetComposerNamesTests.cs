using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ANW.ComposerApp.Interfaces;
using Moq;
using System.Collections.Generic;
using ANW.ComposerApp.Models;
using ANW.ComposerApp.Helpers;

namespace ANW.ComposerTests.Helpers.ComposerDetailsHelperTests
{
    [TestClass]
    public class GetComposerNamesTests
    {
        [TestMethod]
        public void CreateDictionary()
        {
            var dataMock = new Mock<IComposerDataHelper>();

            dataMock.Setup(x => x.GetComposerData()).Returns(returnData);

            var composerDetailsHelper = new ComposerDetailsHelper(dataMock.Object);

            var composerNameDict = composerDetailsHelper.GetComposersNames();

            Assert.AreEqual(typeof(Dictionary<int, string>), composerNameDict.GetType());
            Assert.AreEqual(1, composerNameDict.Count);
        }

        [TestMethod]
        public void NoResults()
        {
            var dataMock = new Mock<IComposerDataHelper>();

            dataMock.Setup(x => x.GetComposerData()).Returns(new List<Composer>());

            var composerDetailsHelper = new ComposerDetailsHelper(dataMock.Object);

            var composerNameDict = composerDetailsHelper.GetComposersNames();

            Assert.AreEqual(typeof(Dictionary<int, string>), composerNameDict.GetType());
            Assert.AreEqual(0, composerNameDict.Count);
        }

        private List<Composer> returnData = new List<Composer>
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
    }
}

﻿using System.Reflection;
using Drachenhorn.Core.Printing;
using Drachenhorn.Core.ViewModels;
using Drachenhorn.Xml.Sheet;
using Drachenhorn.Xml.Sheet.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Drachenhorn.UnitTest
{
    [TestClass]
    public class CoreTest
    {
        private void InitializeData()
        {
            var temp = new ViewModelLocator();
        }

        [TestMethod]
        public void TestPrinting()
        {
            InitializeData();
            
            var sheet = new CharacterSheet
            {
                Characteristics = new Characteristics
                {
                    Name = "test",
                    Race = new RaceInformation {Name = "testRace"},
                    Culture = new CultureInformation {Name = "testCulture", Specification = "test"},
                    Profession = new ProfessionInformation {Name = "testProfession"}
                }
            };

            var temp = PrintingManager.GenerateHtml(sheet);
        }
    }
}
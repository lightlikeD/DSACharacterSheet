﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSACharacterSheet.FileReader;
using DSACharacterSheet.Core.Printing;
using DSACharacterSheet.FileReader.Common;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace DSACharacterSheet.UnitTest
{
    [TestClass]
    public class CoreTest
    {
        [TestMethod]
        public void PrintingTest()
        {
            var sheet = new CharacterSheet()
            {
                Name = "test",
                Race = new RaceInformation() { Name = "testRace"},
                Culture = new CultureInformation() { Name = "testCulture", Spezification = "test"},
                Profession = new ProfessionInformation() { Name = "testProfession"}
            };

            var result = PrintingManager.GenerateHtml(sheet);

#if DEBUG
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "result.html");
                File.WriteAllText(path, result);
                Process.Start(path);
            }
            catch (Exception) { }
#endif

        }
    }
}

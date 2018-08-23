using System;
using System.IO;
using System.Linq;
using GetSlabReinfResult.DataCollector.Logic;
using GetSlabReinfResult.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetSlabReinfResult.UnitTest
{
    [TestClass]
    public class UnitTestLegendViewModel
    {
        [TestMethod]
        public void TestToString() 
        {
            var l = new GetSlabReinfResult.ViewModel.LegendViewModel();

            var Expectlist = l.ListOfLagendItems.ToList();
            var str = l.ToString();

            var Getslist = l.PopulateTableFromString(str);

            Getslist.ForEach(x =>
            {
                Assert.AreEqual(Expectlist[Getslist.IndexOf(x)], x);
            });
            
        }
        [TestMethod]
        public void TestToStringSaveToFile() 
        {
            var l = new LegendViewModel();

            var Expectlist = l.ListOfLagendItems.ToList();
            var str = l.ToString();

            var path = @"F:\scale.scl";

            LoadSaveFromToTextFile.SaveFile(str, path);
      
            Assert.IsTrue(File.Exists(path));

            TempFileManager.DeleteTmpFile(path);
        }
        [TestMethod]
        public void TestReadAndPopulateFromFile()  
        {
            var l = new LegendViewModel();

            var Expectlist = l.ListOfLagendItems.ToList();
            var str = l.ToString();

            var path = @"F:\scale.scl";

            LoadSaveFromToTextFile.SaveFile(str, path);


            var Getslist = l.PopulateTableFromString(LoadSaveFromToTextFile.ReadFile(path));

            TempFileManager.DeleteTmpFile(path);

            Getslist.ForEach(x =>
            {
                Assert.AreEqual(Expectlist[Getslist.IndexOf(x)], x);
            });

            
        }
    }
}

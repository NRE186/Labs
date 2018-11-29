using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SerializedData.Test
{
    [TestClass]
    public class LoadDataTest
    {
        [TestMethod]
        public void LoadDataEmpty()
        {
            LoadData load = new LoadData
            {
                Path = @"W:\C#\Labs\Labs\OOP\SerializedData\TestFiles\empty.json"
            };
            var result = load.LoadingData();
            Assert.AreEqual(result,"Файл пуст");
        }
        [TestMethod]
        public void LoadDataWrongPath()
        {
            LoadData load = new LoadData
            {
                Path = @"W:\C#\Labs\Labs\OOP\Serialized23Data\Files\empty.json"
            };
            var result = load.LoadingData();
            Assert.AreEqual(result, null);
        }
        [TestMethod]
        public void LoadDataWrongExtencion()
        {
            LoadData load = new LoadData
            {
                Path = @"W:\C#\Labs\Labs\OOP\SerializedData\TestFiles\empty.txt"
            };
            var result = load.LoadingData();
            Assert.AreEqual(result, null);
        }
    }
}

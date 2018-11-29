using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SerializedData.Test
{
    [TestClass]
    public class CreateFileTest
    {
        [TestMethod]
        public void CreateFileEmpty()
        {
            CreateFile create = new CreateFile {
                Path = @"W:\C#\Labs\Labs\OOP\SerializedData\TestFiles\",
                Text = "",
                FileName = "1"
            };
        }
    }
}

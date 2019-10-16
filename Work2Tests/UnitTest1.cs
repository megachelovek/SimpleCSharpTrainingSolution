using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Work2;
using Work2.Task2;

namespace Work2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task1Test()
        {
            MenuRepository menuRepository = new MenuRepository();
            menuRepository.GetMenuItems("test1");
        }

        [TestMethod]
        public void Task2Test()
        {
            int[] testArray = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22};
            foreach (var item in testArray.GetEvenDigits())
            {
                Console.WriteLine(item);
            }
        }

        
    }
}

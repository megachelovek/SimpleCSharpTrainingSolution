using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Work2
{
    public class MenuRepository : IMenuRepository
    {
        public IEnumerable<MenuItem> GetMenuItems(string username)
        {
            MenuItem[] result = null;
            Dictionary<string, MenuItem> dataBaseDictionary = GetTestData(); // Этот словарь получили извне
            try
            {
                if (!TrySaveCacheMenuItems(dataBaseDictionary)){
                }
                result = FillArrayItemsFromDictionary(dataBaseDictionary);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }

        private bool TrySaveCacheMenuItems(Dictionary<string, MenuItem> items)
        {
            try
            {
                FileInfo file = new FileInfo("C://testCache.txt");
                if (file.Exists)
                {
                    file.Delete();
                }
                string dbObject = JsonConvert.SerializeObject(items);
                using (FileStream fstream = new FileStream(file.FullName, FileMode.OpenOrCreate))
                {
                    byte[] array = Encoding.Default.GetBytes(dbObject);
                    fstream.Write(array, 0, array.Length);
                }
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return false;
            }
        }

        private MenuItem[] FillArrayItemsFromDictionary(Dictionary<string, MenuItem> dataBaseDictionary)
        {
            MenuItem[] result = new MenuItem[dataBaseDictionary.Count];
            for(int i=0; i< dataBaseDictionary.Count;i++)
            {
                result[0] = dataBaseDictionary.Values.ElementAt(i);
            }
            return result;
        }

        private Dictionary<string, MenuItem> GetTestData()
        {
            Dictionary<string, MenuItem> testData = new Dictionary<string, MenuItem>();
            testData.Add("test1", new MenuItem(0, "menu1", new string[] { "user1", "user2" }));
            testData.Add("test2", new MenuItem(1, "menu2", new string[] { "user1", "user2" }));
            return testData;
        }
    }
}

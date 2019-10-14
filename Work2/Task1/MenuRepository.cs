using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Work2
{
    class MenuRepository : IMenuRepository
    {
        public IEnumerable<MenuItem> GetMenuItems(string username)
        {
            MenuItem[] result = null;
            Dictionary<string, MenuItem> dataBaseDictionary = new Dictionary<string, MenuItem>(); // Этот словарь получили извне
            try
            {
                if (!TrySaveCacheMenuItems(dataBaseDictionary)){
                    //Логгирование, что не закешировалось
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
                FileInfo file = new FileInfo("C://TestCache/testCache.txt");
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
            catch
            {
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
    }
}

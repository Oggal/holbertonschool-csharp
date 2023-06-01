using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    /// <summary> JSONStorage class </summary>
    public class JSONStorage
    {
        const string storagePath = "../storage/inventory_manager.json";
        /// <summary> JSONStorage instance </summary>
        public static JSONStorage instance = new JSONStorage();
        Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();
        /// <summary> All classes </summary>
        public static string[] classes = new string[] { "User", "Item", "Inventory" };

        /// <summary> All Method </summary>
        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        ///<summary> New Method </summary>
        public void New(BaseClass obj)
        {
            string key = String.Format("{0}.{1}", obj.GetType().Name, obj.id);
            objects.Add(key, obj);
        }

        ///<summary> Save Method </summary>
        public void Save()
        {
            string jsonString = JsonSerializer.Serialize(objects);
            try
            {
                PreparePath();
                File.WriteAllText(storagePath, jsonString);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Unable to save to file.");
                Console.ResetColor();
                Console.WriteLine(e);
            }
        }

        ///<summary> Delete Method </summary>
        public void DeleteItem(string ClassName, string id)
        {
            string key = String.Format("{0}.{1}", ClassName, id);
            if (objects.ContainsKey(key))
                objects.Remove(key);
            else
                Console.WriteLine("Error: Object not found.");
        }

        /// <summary> GetItem Method </summary>
        public BaseClass GetItem(string ClassName, string id)
        {
            string key = String.Format("{0}.{1}", ClassName, id);
            foreach( KeyValuePair<string, BaseClass> kvp in objects)
            {
                if (kvp.Key.ToLower() == key)
                    return kvp.Value;
            }
            return null;
        }

        ///<summary> Load Method </summary>
        public void Load()
        {
            string jsonString = "";
            try
            {
                PreparePath();
                jsonString = File.ReadAllText(storagePath);
            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Unable to load from file.");
                Console.ResetColor();
                return;
            }
            catch(Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Unable to load from file due to unknown issue.");
                Console.ResetColor();
                return;
            }
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
        }
        private void PreparePath()
        {
            string path = Path.GetDirectoryName(storagePath);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private string BuildJSONDict()
        {
            List<User> users = new List<User>();
            List<Item> items = new List<Item>();
            List<Inventory> inventories = new List<Inventory>();
            foreach (KeyValuePair<string, BaseClass> kvp in objects)
            {
                string type = kvp.Key.Split('.')[0].ToLower();
                if (type == "user")
                    users.Add(kvp.Value as User);
                else if (type == "item")
                    items.Add(kvp.Value as Item);
                else if (type == "inventory")
                    inventories.Add(kvp.Value as Inventory);
                else
                    Console.WriteLine("Error: Unknown type.");
            }
            string results = JsonSerializer.Serialize(users) + '\n';
            results += JsonSerializer.Serialize(items) + '\n';
            results += JsonSerializer.Serialize(inventories);
            return results;
        }

        private void BuildFromJson(string jsonData, Type type)
        {
            throw new NotImplementedException();
        }
    }
}
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
    }
}
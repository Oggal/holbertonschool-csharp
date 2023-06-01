using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    static class InventoryManager
    {

        delegate void MyCallback(string a = null);
        static Dictionary<string, MyCallback> commands = new Dictionary<string, MyCallback>();
        


        static void Main(string[] args)
        {
            string[] LastIn;
            Init();
            while (true)
            {
                Console.WriteLine(GetMenuPrompt());
                LastIn = GetInput();
                string command = LastIn[0];
                if (commands.ContainsKey(command))
                {
                    MyCallback callback = (MyCallback)commands[command];
                    callback.Invoke(LastIn[1]);
                }
            }
        }

        public static bool ValidateInput(string[] args, int argc)
        {
            return args.Length >= argc;
        }

        public static void Init()
        {
            JSONStorage.instance.Load();

            commands.Add("exit", Exit);
            commands.Add("all", All);
            commands.Add("create",Create);
            commands.Add("show", Show);
        }

        public static string[] GetInput()
        {
            Console.Write("Enter a command: ");
            string[] Input = Console.ReadLine().ToLower().Split(" ", 2);
            if(Input.Length == 1)
                Input = new string[] {Input[0], null};
            return Input;
        }

        public static string GetMenuPrompt()
        {
            string Prompt = @"
            Inventory Manager
        ________________________
            <ClassNames> show all ClassNames of objects
            <All> show all objects
            <All [ClassName]> show all objects of a ClassName
            <Create [ClassName]> a new object
            <Show [ClassName object_id]> an object
            <Update [ClassName object_id]> an object
            <Delete [ClassName object_id]> an object
            <Exit> the program
            ";
            return Prompt;
        }

        private static void Exit(string a = null)
        {
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
        }

        private static void All(string ClassName = null)
        {
            Console.WriteLine("All:");
            foreach (KeyValuePair<string, BaseClass> entry in JSONStorage.instance.All())
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }

        private static void Create(string ClassName = null)
        {
            if (ClassName == null)
            {
                Console.WriteLine("Error: ClassName required.");
                return;
            }
            // create a new object of type 
            BaseClass NewObject = CreateNew(ClassName);
            if ( NewObject == null)
                return;
            JSONStorage.instance.New(NewObject);
            JSONStorage.instance.Save();
            Console.WriteLine("Created: {0} - {1}", NewObject.GetType().Name, NewObject.id);
            // add it to the JSONStorage

        }

        private static BaseClass CreateNew(string ClassName)
        {
            string[] args = ClassName.Split(" ");
            ClassName = args[0];
            switch (ClassName)
            {
                case "item":
                    return new Item(null);
                case "user":
                    return new User(null);
                case "inventory":
                    if(args.Length < 3)
                    {
                        Console.WriteLine("Error: Inventory requires 2 arguments[UserID, ItemID].");
                        return null;
                    }
                    BaseClass  obj;
                    JSONStorage.instance.All().TryGetValue("Item." + args[2], out obj);
                    Item inv_item = obj as Item;
                    JSONStorage.instance.All().TryGetValue("User." + args[1], out obj);
                    User inv_user = obj as User;
                    if (inv_item == null || inv_user == null)
                    {
                        return new Inventory(args[1], args[2]);
                    }
                    return new Inventory(inv_user, inv_item);
                default:
                    Console.WriteLine("Error: ClassName not found.");
                    return null;
            }
        }

        public static void Show(string ClassName = null)
        {
            if (ClassName == null)
            {
                Console.WriteLine("Error: ClassName required.");
                return;
            }
            string[] args = ClassName.Split(" ");
            ClassName = args[0] + "." + args[1];
            BaseClass obj;
            // show an object of type ClassName
            JSONStorage.instance.All().TryGetValue(ClassName, out obj);
            if (obj == null)
            {
                Console.WriteLine("Error: ClassName not found.");
                return;
            }
            Console.WriteLine(obj);
        }

        
    }
}

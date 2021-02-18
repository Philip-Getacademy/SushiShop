using System;
using System.Collections.Generic;
using System.Text;
using SushiShop.Misc.DescribingClass;

namespace SushiShop.RegistryKiosk.CollectionClass
{
    class KioskMessages
    {
        public static string Welcome = "Welcome to Sushi Shop!";
        public static string InvalidRecipeItem = "No Recipe with that name";


        // Enums?
        public static void ErrorMessage(string message)
        {
            Console.WriteLine($"An error has occured: {message}");
            ErrorDoc.AppendError(message);

        }
    }
}

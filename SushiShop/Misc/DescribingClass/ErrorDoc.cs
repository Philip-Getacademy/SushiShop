using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SushiShop.Misc.DescribingClass
{
    public static class ErrorDoc
    {
        
        private static string GCD => Directory.GetCurrentDirectory();
        private static string P => GCD?.Substring(0, GCD?.LastIndexOf("bin") ?? 0);

        private static string ErrorsFile => $"{P}Errors.txt";

        private static bool FileExists => File.Exists($"{P}Errors.txt");

        public static void ConstructStaticErrorsFile()
        {
            if (FileExists) return;
            File.Create(ErrorsFile);
        }

        public static void AppendError(string errorMessage)
        {
            var dateAndTimeOfError = DateTime.Now;
            var format = $"TOI: {dateAndTimeOfError} {errorMessage} \n";

            File.AppendAllText(ErrorsFile, format);
            File.AppendAllText(ErrorsFile, "\n");
        }
        
    }
}

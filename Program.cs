using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Путь к файлу с исходным кодом на C#
        string filePath = "C:\\Универ\\.NET\\9лаба\\sharp_9.2\\file.cs";

        try
        {
            // Считывание содержимого файла
            string code = File.ReadAllText(filePath);

            // Регулярное выражение для поиска методов и их аргументов
            string regexPattern = @"(?<modifiers>\w+\s+)*\w+\s+(?<methodName>\w+)\s*\((?<arguments>.*?)\)";

            // Поиск всех методов с аргументами
            MatchCollection matches = Regex.Matches(code, regexPattern);

            // Вывод информации о найденных методах и их аргументах
            foreach (Match match in matches)
            {
                string methodName = match.Groups["methodName"].Value;
                string arguments = match.Groups["arguments"].Value;

                // Разделение аргументов по запятой
                string[] argumentList = arguments.Split(',');

                List<string> argumentTypes = new List<string>();

                // Выделение типов аргументов
                foreach (string argument in argumentList)
                {
                    string argumentType = argument.Trim().Split(' ')[0]; // Предполагается, что тип аргумента указан перед ним

                    argumentTypes.Add(argumentType);
                }

                Console.WriteLine("Метод: " + methodName);

                if (argumentTypes.Count > 0)
                {
                    Console.WriteLine("Аргументы:");

                    foreach (string argumentType in argumentTypes)
                    {
                        
                        if (argumentType.Length == 0)
                            Console.WriteLine("0\nМетод не имеет аргументов.");
                        else
                        {
                            Console.WriteLine("- " + argumentType);
                        }
                    }
                }

                Console.WriteLine();
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка: " + e.Message);
        }

        Console.ReadLine();
    }
}
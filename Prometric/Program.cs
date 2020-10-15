using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Prometric.Models;

namespace Prometric
{
    class Program
    {
        static List<IShape> _shapes = new List<IShape>();
        private static string _fileName = "c:\\Temp\\data.json";

        static void Main(string[] args)
        {
            // set the shapes here
            _shapes.Add(new Circle(5));
            _shapes.Add(new Triangle(2, 3, 5));
            _shapes.Add(new Quadrilateral(3, 2));
            _shapes.Add(new Quadrilateral(4, 4));

            // Menu draw
            DrawScreen();
        }

        private static void DrawScreen()
        {
            string action = "List created";
            bool exit = false;

            do
            {
                Console.Clear();

                Console.WriteLine("Please select an option");
                Console.WriteLine();

                // menu
                Console.WriteLine("1 - Order by Name");
                Console.WriteLine("2 - Order by Area");
                Console.WriteLine("3 - Order by Perimeter");
                Console.WriteLine("4 - Export to json");
                Console.WriteLine("5 - Exit");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("List of Shapes:");
                Console.WriteLine();
                foreach (IShape shape in _shapes)
                {
                    Console.WriteLine($"Name. {shape.Name}, Area: {shape.Area}, Perimeter: { shape.Perimeter}");
                }
                Console.WriteLine();
                Console.WriteLine($"Executed Action: {action}");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Enter your option: ");
                var key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        _shapes = _shapes.OrderBy(o => o.Name).ToList();
                        action = "Ordered by name";
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        _shapes = _shapes.OrderBy(o => o.Area).ToList();
                        action = "Ordered by shape";
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        _shapes = _shapes.OrderBy(o => o.Perimeter).ToList();
                        action = "Ordered by perimeter";
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        File.WriteAllText(_fileName, JsonSerializer.Serialize(_shapes));
                        action = "Exported to json";
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        exit = true;
                        break;
                }

            } while (!exit);

            Console.WriteLine("Exiting Application");
        }
    }
}

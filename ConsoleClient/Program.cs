// See https://aka.ms/new-console-template for more information
using System.Text;
using ConsoleClient;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, World!");

var khnure = UniversityInitializer.Initialize();
Console.WriteLine(khnure);
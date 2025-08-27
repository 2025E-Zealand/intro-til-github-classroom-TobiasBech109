// See https://aka.ms/new-console-template for more information
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
Console.WriteLine("Hello, World!");

DemoTry person = new DemoTry{ Name = "Tobias", Age = 24, Email = "123@456.dk" };
Console.WriteLine(person);
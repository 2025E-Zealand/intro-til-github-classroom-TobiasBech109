// See https://aka.ms/new-console-template for more information
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

DemoTry person = new DemoTry{ Name = "Henning", Age = 72, Email = "123@456.dk" };
Console.WriteLine(person);

Console.WriteLine();

Opgave opgave = new Opgave { Navn = "Classroom", Tid = 12, Beskrivelse = "Lav en klasse og prøv at fork" };
Console.WriteLine(opgave);
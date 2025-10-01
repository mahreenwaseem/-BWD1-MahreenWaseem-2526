/*
 * Auteur: Mahreen Waseem
 * Datum: 2025-09-25
 */
using System;

namespace ConsoleNaamVanDeOefening
{
   internal class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine("Hallo Wereld !");
		Console.Write("Hoe heet je: ");
		string naam = Console.ReadLine();
		Console.WriteLine($"Aangename kennismaking, {naam}");
		Console.WriteLine("druk een toets om verder te gaan...");
        Console.ReadKey();  
      }
   }
}

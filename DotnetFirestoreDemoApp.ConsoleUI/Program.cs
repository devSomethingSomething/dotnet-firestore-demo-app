using DotnetFirestoreDemoApp.Core;
using System;

namespace DotnetFirestoreDemoApp.ConsoleUI
{
    public class Program
    {
        private static void Main(string[] args)
        {
            FirestoreManager.Create();

            Console.ReadKey(intercept: true);
        }
    }
}

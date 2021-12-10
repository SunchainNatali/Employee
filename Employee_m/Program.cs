using System;
using System.Collections.Generic;
namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double wage;
            int subordinates;
            Console.WriteLine("Hello user!");
            Console.WriteLine("Enter the number of worker to add please: ");
            int numEnter;
                
                while (!int.TryParse(Console.ReadLine(), out numEnter))
                {
                    Console.WriteLine("Enter a number!");
                }

            List<Worker> workers = new List<Worker>();

            for(int i = 0; i < numEnter; i++)
            {
                Console.WriteLine("Choose who you want to add : ");
                Console.WriteLine("1. Director");
                Console.WriteLine("2. Engineer");
                Console.WriteLine("3. Masters ");
                Console.WriteLine("4. Assistant ");
                Console.WriteLine("5. JuniorWorker ");
                int position;
                while (!int.TryParse(Console.ReadLine(), out position))
                {
                    Console.WriteLine("Enter a number!");
                }
                Console.WriteLine($"You have position {position}");
                Console.WriteLine("Enter the name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter the wage: ");
                wage = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the subordinates: ");
                subordinates = int.Parse(Console.ReadLine());
                AddWorker.AddWorkerNew(position, name, wage, subordinates, workers);
            }
            Console.WriteLine("Do you want to see the characteristics of the worker? ");
            Console.WriteLine("1 - Yes, 2 - No");
            Console.WriteLine("You chose : ");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("List of workers: ");
                foreach (Worker worker in workers)
                {
                    Console.WriteLine(worker.Name());
                }
                Console.WriteLine();
                Console.WriteLine("Enter the name of the worker to see the characteristic: ");
                var choice = Console.ReadLine();
                Console.WriteLine();
                foreach (Worker worker in workers)
                {
                    if (choice != worker.Name())
                    {
                        Console.WriteLine("This worker does not exist!");
                    }
                    else
                    {
                        Console.WriteLine("Worker characteristic: ");
                    }
                }
                foreach (Worker worker in workers)
                {
                    if (choice == worker.Name())
                    {
                        Console.WriteLine($"Position: {worker.Position()}");
                        Console.WriteLine($"Name: {worker.Name()}");
                        Console.WriteLine($"Wage: {worker.Wage()}");
                        Console.WriteLine($"Subordinates: {worker.Subordinates()}");
                        Console.WriteLine($"LevelOfResponsibility: {worker.LevelOfResponsibility()}");
                    }
                }
            }
            else 
            {
                Console.WriteLine("Exit");
            }






        }
    }
}

using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "tickets.txt";
            string choice;

            do
            {
                Console.WriteLine("1. Read data from file");
                Console.WriteLine("2. Create new data");
                Console.WriteLine("Enter any other response to close the file");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (File.Exists(file))
                    {
                        int i = 0;
                        StreamReader sr = new StreamReader(file);

                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] arr = line.Split(',');
                            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
                            i++;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("the file does not exist");
                    }
                }
                else if (choice == "2")
                {
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine("Enter a new ticket (y/n)");
                        string input = Console.ReadLine().ToLower();
                        if (input != "y") { break; }
                        Console.WriteLine("What is the ticket number?");
                        string tickNum = Console.ReadLine();
                        Console.WriteLine("Summarize the issue.");
                        string summary = Console.ReadLine();
                        Console.WriteLine("What is the status of the ticket?");
                        string status = Console.ReadLine();
                        Console.WriteLine("What is the priority of the ticket?");
                        string priority = Console.ReadLine();
                        Console.WriteLine("Who submitted the ticket?");
                        string submit = Console.ReadLine();
                        Console.WriteLine("Who is assigned to work on the ticket?");
                        string assign = Console.ReadLine();
                        Console.WriteLine("How many people are monitoring the ticket");
                        int watchNum = int.Parse(Console.ReadLine());
                        string[] watching = new string[watchNum];
                        for (int j = 0; j < watching.Length; j++)
                        {
                            Console.WriteLine($"Person {j + 1}:");
                            watching[j] = Console.ReadLine();
                        }
                        string watchers;
                        for (int j = 0; )
                        
                        
                        
                    }
                }




            } while (choice == "1" || choice == "2");
            Console.WriteLine("Have a good day!");
        }
    }
}
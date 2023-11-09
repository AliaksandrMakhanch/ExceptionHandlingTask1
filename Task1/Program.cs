using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
               Console.WriteLine("Enter symbols. No null input is allowed");

                while (true)
                {
                    try
                    {
                        string input = Console.ReadLine();

                        PrintFirstCharacter(input);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            static void PrintFirstCharacter(string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentException("Input cannot be empty");
                }

                Console.WriteLine($"First character is: {input[0]}");
            }
        }
    }

    
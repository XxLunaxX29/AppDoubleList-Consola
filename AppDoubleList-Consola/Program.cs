
using AppDoubleList_Consola;
using System;

internal class Program
{ 
    static void Main(string[] args)
    {
        DoubleList MyList = new DoubleList();
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("====== DOUBLE LINKED LIST ======");
            Console.WriteLine("1. Add element");
            Console.WriteLine("2. Remove element");
            Console.WriteLine("3. Show list");
            Console.WriteLine("4. Show list in reverse");
            Console.WriteLine("5. Count elements");
            Console.WriteLine("6. Clear list");
            Console.WriteLine("0. Exit");
            Console.WriteLine("================================");
            Console.Write("Select an option: ");

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option. Press any key...");
                Console.ReadKey();
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.Write("Enter the data to add: ");
                    if (int.TryParse(Console.ReadLine(), out int dataToAdd))
                    {
                        if (MyList.Exists(dataToAdd))
                        {
                            Console.WriteLine("The data already exists in the list.");
                        }
                        else
                        {
                            Node n = new Node(dataToAdd);
                            MyList.Add(n);
                            Console.WriteLine("Data added successfully!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                    break;

                case 2:
                    Console.Write("Enter the data to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int dataToRemove))
                    {
                        if (!MyList.Exists(dataToRemove))
                        {
                            Console.WriteLine("The data doesn't exist in the list.");
                        }
                        else
                        {
                            MyList.Remove(dataToRemove);
                            Console.WriteLine("Data removed successfully!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nList contents:");
                    Console.WriteLine(MyList.Show());
                    break;

                case 4:
                    Console.WriteLine("\nList in reverse:");
                    Console.WriteLine(MyList.ReverseShow());
                    break;

                case 5:
                    Console.WriteLine($"\nThe list contains {MyList.Count()} elements.");
                    break;

                case 6:
                    MyList.Clear();
                    Console.WriteLine("List cleared.");
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            if (option != 0)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

        } while (option != 0);

        Console.WriteLine("\n--- End of program. Final list ---");
        MyList.Show();
        Console.ReadKey();

    }
}



using System;

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList list = new SinglyLinkedList();

        while (true)
        {
            Console.WriteLine("\n===== Student Management Menu =====");
            Console.WriteLine("1. Insert Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Print All Students");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Index Number: ");
                    int index = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter GPA: ");
                    double gpa = double.Parse(Console.ReadLine());
                    Console.Write("Enter Admission Year: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Enter NIC: ");
                    string nic = Console.ReadLine();

                    Student student = new Student(index, name, gpa, year, nic);
                    list.Insert(student);
                    break;

                case "2":
                    Console.Write("Enter Index Number to Search: ");
                    int searchIndex = int.Parse(Console.ReadLine());
                    Student found = list.Search(searchIndex);
                    if (found != null)
                        found.Display();
                    else
                        Console.WriteLine("Student not found.");
                    break;

                case "3":
                    Console.Write("Enter Index Number to Remove: ");
                    int removeIndex = int.Parse(Console.ReadLine());
                    list.Remove(removeIndex);
                    break;

                case "4":
                    list.PrintAll();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}

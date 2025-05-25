using System;

public class SinglyLinkedList
{
    private Node head;

    public void Insert(Student student)
    {
        // Check for uniqueness
        if (Search(student.IndexNumber) != null)
        {
            Console.WriteLine("Student with this index already exists!");
            return;
        }

        Node newNode = new Node(student);

        if (head == null || student.IndexNumber < head.Data.IndexNumber)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null && current.Next.Data.IndexNumber < student.IndexNumber)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        Console.WriteLine("Student inserted successfully!");
    }

    public Student Search(int index)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data.IndexNumber == index)
            {
                return current.Data;
            }
            current = current.Next;
        }
        return null;
    }

    public void Remove(int index)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty!");
            return;
        }

        if (head.Data.IndexNumber == index)
        {
            head = head.Next;
            Console.WriteLine("Student removed successfully!");
            return;
        }

        Node current = head;
        while (current.Next != null && current.Next.Data.IndexNumber != index)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Student not found!");
        }
        else
        {
            current.Next = current.Next.Next;
            Console.WriteLine("Student removed successfully!");
        }
    }

    public void PrintAll()
    {
        if (head == null)
        {
            Console.WriteLine("No students in the list.");
            return;
        }

        Node current = head;
        while (current != null)
        {
            current.Data.Display();
            current = current.Next;
        }
    }
}

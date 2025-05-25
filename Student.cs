public class Student
{
    public int IndexNumber;
    public string Name;
    public double GPA;
    public int AdmissionYear;
    public string NIC;

    public Student(int indexNumber, string name, double gpa, int admissionYear, string nic)
    {
        IndexNumber = indexNumber;
        Name = name;
        GPA = gpa;
        AdmissionYear = admissionYear;
        NIC = nic;
    }

    public void Display()
    {
        Console.WriteLine($"Index: {IndexNumber}, Name: {Name}, GPA: {GPA}, Year: {AdmissionYear}, NIC: {NIC}");
    }
}

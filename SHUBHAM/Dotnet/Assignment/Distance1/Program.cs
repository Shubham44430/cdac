using Distanceee;

class Program
{
    public static void Main(string[] args)
    {
        Distance a = new Distance(100);
        Distance b = new Distance(50);

        a.Print();
        b.Print();  

        Distance c = a + b;
        c.Print();

        Distance d = a - b;
        d.Print();
    }
}
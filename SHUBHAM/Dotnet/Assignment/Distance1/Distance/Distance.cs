namespace Distanceee;
class Distance
{

    public Distance(int value)
    {
        Feet = value / 12;
        Inch = value % 12;
    }   
      public Distance(int f , int i)
    {
        Feet = f;
        Inch = i;
    }
    public int Feet { get; set; }
    public int Inch { get; set; }

    public void Print()
    {
         
        Console.WriteLine($"The distance is : {Feet} Feet And {Inch} Inches");
    }

    public static Distance operator +(Distance lhs, Distance rhs)
    {
        return new Distance(lhs.Feet + rhs.Feet, lhs.Inch + rhs.Inch);
    }
    
     public static Distance operator-(Distance lhs, Distance rhs)
    {
        return new Distance(lhs.Feet - rhs.Feet, lhs.Inch - rhs.Inch);
    }
}
using Loan1;

class Program
{
    public static void Main(string[] args)
    {
        Loan H = new Homeloan();
        double a = double.Parse(args[0]);
        int t = int.Parse(args[1]);

        H.Principle = a;
        H.Period = t;
        Console.WriteLine("For Homeloan");
        Console.WriteLine($"The {H.GetRate()} & {H.GetEMI()} ");
        if (H is IDiscountable d)
            Console.WriteLine($"Discount = {d.GetDiscount()}");

        Loan P = new Personalloan();
        P.Principle = a;
        P.Period = t;
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("For Personal loan");
        Console.WriteLine($"The {P.GetRate()} & {P.GetEMI()}");
        if (P is ITaxable t1)
            Console.WriteLine($"Tax = {t1.GetTax()}");
    }
}
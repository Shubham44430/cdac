namespace Loan1;

public abstract class Loan
{
    public double Principle { get; set; }          //emi = p * (1 + r * n / 100) / (12 * n)
    public int Period { get; set; }

    public abstract double GetRate();
    public double GetEMI()
    {
        double emi = Principle * (1 + GetRate() * Period / 100) / (12 * Period);
        return emi;
    }
}
namespace Loan1;

class Personalloan : Loan, ITaxable 
{
    public override double GetRate()
    {
        if (Principle < 500000)
            return 0.15;
        else
            return 0.16;
    }
    public  double GetTax()
    {
        double TotalInterest = Principle * GetRate() * Period;
        return TotalInterest * 0.1;
    }
    
}
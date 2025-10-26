using System.Security.Principal;

namespace Loan1;

class Homeloan : Loan, IDiscountable
{

  
    
    public override double GetRate()
    {
        int limit = 2500000;
        if (Principle <= 2000000)
            return 0.1;
        else if (Principle > limit)
            return 0.13;
        else
            return 0.11;
    }

      public  double GetDiscount()
    {
        double TotalInterest = Principle * GetRate() * Period;
        return TotalInterest * 0.02;
    }
}
using System;

public class SalariedEmployee : Employee
{
    private decimal weeklySalary; 

    public SalariedEmployee(string first, string last, string ssn, decimal salary)
        : base(first, last, ssn)
    {
        WeeklySalary = salary; // validate salary via property
    } // end four-parameter SalariedEmployee constructor

    public decimal WeeklySalary
    {
        get
        {
            return weeklySalary;
        } // end get
        set
        {
            if (value >= 0) // validation
                weeklySalary = value;
            else
                throw new ArgumentOutOfRangeException("WeeklySalary",
                    value, "WeeklySalary must be >= 0");
        } 
    }

    public override decimal GetPaymentAmount()
    {
        return WeeklySalary;
    } 

    public override string ToString()
    {
        return string.Format("salaried employee: {0}\n{1}: {2:C}",
            base.ToString(), "weekly salary", WeeklySalary);
    } // end method ToString
} // end class SalariedEmployee

﻿using System;
public class CommissionEmployee : Employee
{
    private decimal grossSales; // gross weekly sales
    private decimal commissionRate; // commission percentage

    // five-parameter constructor
    public CommissionEmployee(string first, string last, string ssn,
        decimal sales, decimal rate)
        : base(first, last, ssn) // Call the base class constructor
    {
        GrossSales = sales; // validate gross sales via property
        CommissionRate = rate; // validate commission rate via property
    } // end five-parameter CommissionEmployee constructor
    public decimal GrossSales
    {
        get
        {
            return grossSales;
        } // end get
        set
        {
            if (value >= 0)
                grossSales = value;
            else
                throw new ArgumentOutOfRangeException(
                    "GrossSales", value, "GrossSales must be >= 0");
        } // end set
    } // end property GrossSales

    public decimal CommissionRate
    {
        get
        {
            return commissionRate;
        } // end get
        set
        {
            if (value > 0 && value < 1)
                commissionRate = value;
            else
                throw new ArgumentOutOfRangeException(
                    "CommissionRate", value, "CommissionRate must be > 0 and < 1");
        } // end set
    } // end property CommissionRate

    public override decimal GetPaymentAmount()
    {
        return CommissionRate * GrossSales;
    } // end method Earnings

    public override string ToString()
    {
        return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}",
            "commission employee", base.ToString(),
            "gross sales", GrossSales, "commission rate", CommissionRate);
    } // end method ToString
} // end class CommissionEmployee

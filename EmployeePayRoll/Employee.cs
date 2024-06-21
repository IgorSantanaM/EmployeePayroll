using EmployeePayRoll;
using System;

public abstract class Employee : IPayable
{ 
    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string SocialSecurityNumber { get; private set; }
    public Employee(string first, string last, string ssn)
    {
        FirstName = first;
        LastName = last;
        SocialSecurityNumber = ssn;
    } // end three-parameter Employee constructor

    public override string ToString()
    {
        return string.Format("{0} {1}\nsocial security number: {2}",
            FirstName, LastName, SocialSecurityNumber);
    } // end method ToString

    public abstract decimal GetPaymentAmount();
} // end abstract class Employee

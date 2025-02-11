﻿// Fig. 12.4: Employee.cs
// Employee abstract base class.
public abstract class Employee
{
   public string FirstName { get; }
   public string LastName { get; }
   public string SocialSecurityNumber { get; }
  public   static int employeeCount;

   // three-parameter constructor
   public Employee(string firstName, string lastName,
      string socialSecurityNumber)
   {
      FirstName = firstName;
      LastName = lastName;
      SocialSecurityNumber = socialSecurityNumber;
        employeeCount++;

   }

    // return string representation of Employee object, using properties
    public override string ToString() => $"{FirstName} {LastName}\n" +
       $"social security number: {SocialSecurityNumber}";


   // abstract method overridden by derived classes
   public abstract decimal Earnings(); // no implementation here\
    //public void add()=> body of method
    
}




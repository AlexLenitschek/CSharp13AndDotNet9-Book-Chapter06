namespace Packt.Shared;

public class Employee : Person
{
    public string? EmployeeCode { get; set; }
    public DateOnly HireDate { get; set; }

    #region Hidding Members
    public new void WriteToConsole() // "new" here indicates to the compiler that overwritting Person's WriteToConsole Method was desired
    {
        WriteLine(format: "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}.", arg0: Name, arg1: Born, arg2: HireDate);
    }
    #endregion

    #region Understanding Polymorphism - Overriding Members
    public override string ToString() // "override" can only be used to override a "virtual" method.
    {
        return $"{Name}'s code is {EmployeeCode}";
    }
    #endregion
}
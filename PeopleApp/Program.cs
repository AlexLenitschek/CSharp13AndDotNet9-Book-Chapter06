using System.Globalization; // To use CultureInfo.
using Packt.Shared;
// Set the culture to en-US for English (United States)
CultureInfo.CurrentCulture = new CultureInfo("en-US");

#region Implementing functionality using methods and operators.
Person harry = new()
{
    Name = "Harry",
    Born = new(year: 2001, month: 3, day: 25, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

harry.WriteToConsole();

Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

// Call the instance method to marry Lamech and Adah.
lamech.Marry(adah);

// Call the static method to marry Lamech and Zillah.
//Person.Marry(lamech, zillah);

if (lamech + zillah)
{
    WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
}

lamech.OutPutSpouses();
adah.OutPutSpouses();
zillah.OutPutSpouses();

// Call the instance method to make a baby.
Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

// Call the static method to make a baby.
Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

// Use the * operator to "multiply".
Person baby3 = lamech * adah;
baby3.Name = "Jubal";

Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine(format: "  {0}'s child #{1} is named \"{2}\".",
      arg0: lamech.Name, arg1: i,
      arg2: lamech.Children[i].Name);
}

WriteLine();
#endregion

#region Working with non-generic types

// Non-generic lookup collection.
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2; // Look up the value that has 2 as its key.

WriteLine(format: "Key {0} has value: {1}",
  arg0: key,
  arg1: lookupObject[key]);

// Look up the value that has harry as its key.
WriteLine(format: "Key {0} has value: {1}",
  arg0: harry,
  arg1: lookupObject[harry]);

WriteLine();
#endregion

#region Working with generic types.
// Define a generic lookup collection.
Dictionary<int, string> lookupIntString = new(); 
// System.Collections.Generic.Dictionary<TKey, TValue> is implicitly and globally imported by default.
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;

WriteLine(format: "Key {0} has value: {1}",
  arg0: key,
  arg1: lookupIntString[key]);

WriteLine();
#endregion

#region Defining and handling delegates

// Assign the method(s) to the Shout event delegate. Shout Initially null.
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;

// Call the Poke method that eventually raises the Shout event.
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

WriteLine();
#endregion

#region Comparing objects when sorting - Interface
Person?[] people = {
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
};

OutputPeopleNames(people, "Initial list of people:");

Array.Sort(people);

OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");

Array.Sort(people, new PersonComparer());

OutputPeopleNames(people, "After sorting using PersonComparer's IComparer implementation:");

WriteLine();
#endregion

#region Inheriting from classes
Employee john = new()
{
    Name = "John",
    Born = new(year: 1990, month: 7, day: 28, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};
john.WriteToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
WriteLine($"{john.Name} was hired on {john.HireDate:yyyy-MM-dd}");

WriteLine();
#endregion

#region Overriding members
WriteLine(john.ToString());


WriteLine();
#endregion

#region Understanding polymorphism
Employee aliceInEmployee = new() { Name = "Alice", EmployeeCode = "AA123" };

Person aliceInPerson = aliceInEmployee;
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());

WriteLine();
#endregion

#region Implicit & Explicit Casting
//Person ImplicitAlice = aliceInEmployee; // Derived types can be stored in their base type (or its base's base type, amd so on.)
Employee explicitAlice1 = (Employee)aliceInPerson; // Explicit casts need the type to be explicitly mentioned.
// Could result in an InvalidCastException if the type is not compatible. Do the following codeblock to avoid it:
#endregion


// Use the is and as keywords to prevent throwing exceptions when casting between derived types. Prevents the need to write try-catch statements for InvalidCastException.
#region Using the "is" keyword to check a type
if (aliceInPerson is Employee)

{
    WriteLine($"{nameof(aliceInPerson)} is an Employee.");
    
    Employee explicitAlice2 = (Employee)aliceInPerson;

    // Safely do something with explicitAlice2.
}

if (aliceInPerson is Employee explicitAlice3) // Same as above but using declaration pattern. Checks and Casts in one line.
{
    WriteLine($"{nameof(aliceInPerson)} is an Employee.");

    // Safely do something with explicitAlice2.
}

WriteLine();
#endregion

#region Using the "as" keyword to cast a type
Employee? aliceAsEmployee = aliceInPerson as Employee; // If the cast fails, the result is null.

if (aliceAsEmployee is not null)
{
    WriteLine($"{nameof(aliceInPerson)} as an Employee.");

    // Safely do something with aliceAsEmployee.
}

WriteLine();
#endregion
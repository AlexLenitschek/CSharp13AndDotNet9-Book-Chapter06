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
#endregion
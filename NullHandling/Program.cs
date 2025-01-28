using Packt.Shared;

#region Dealing with null values.
int thisCannotBeNull = 4;

//thisCannotBeNull = null; // CS0037: Cannot convert null to 'int' because it is a non-nullable value type
WriteLine(thisCannotBeNull);

int? thisCouldBeNull = null;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

// The actual type of int? is Nullable<int>.
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull = 9;
WriteLine(thisCouldAlsoBeNull);

WriteLine();
#endregion

#region Declaring non-nullable variables and parameters.
Address address = new(city: "London")
{
    Building = null,
    Street = null!,
    Region = "UK"
};

WriteLine(address.Building?.Length);

if (address.Street is not null)
{
    WriteLine(address.Street.Length);
}

WriteLine();
#endregion

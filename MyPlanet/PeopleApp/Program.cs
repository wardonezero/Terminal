using Pack.Shared;
using static System.Console;
/*// var bob = new Person();
// WriteLine(bob.ToString());
// bob.FavoriteAncientWonder = WonderOfTheAnciantWorld.StatueofZeusatOlympia;
// WriteLine($"{bob.name}'s favorite wonder is {bob.FavoriteAncientWonder}. It's integer is {(int)bob.FavoriteAncientWonder}");
// bob.BucketList = WonderOfTheAnciantWorld.HangingGardensofBabylon | WonderOfTheAnciantWorld.MausoleumatHalicarnassus;
// WriteLine($"{bob.name}'s bucket is {(int)bob.BucketList}");
// bob.BucketList = (WonderOfTheAnciantWorld)18;
// WriteLine($"{bob.BucketList}");
// bob.BucketList = (WonderOfTheAnciantWorld)96;
// WriteLine($"{bob.BucketList}");
// bob.Children.Add(new Person {name = "Zoe"});
// bob.Children.Add(new Person {name = "Alfred"});
// foreach (Person child in bob.Children)
// {
//     WriteLine(child.name);
// }*/
BankAccount.interestRate = 0.024M;/*
// var jonesAccount = new BankAccount();
// jonesAccount.accountName = "Mrs. Jones";
// jonesAccount.balance = 24000;
// WriteLine($"{jonesAccount.accountName} earned ${jonesAccount.balance * BankAccount.interestRate} interest.");
// var gerrierAccount = new BankAccount();
// gerrierAccount.accountName = "Ms. Gerrier";
// gerrierAccount.balance = 416000;
// WriteLine($"{gerrierAccount.accountName} earned ${gerrierAccount.balance * BankAccount.interestRate} interest.");
// WriteLine($"{bob.name} is a {Person.Species}");
// WriteLine($"{bob.name} was born on {bob.homePlanet}");
// var blankPerson = new Person();
// WriteLine($"{blankPerson.name} of {blankPerson.homePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}");
// var gunny = new Person("Gunny", "Mars");
// WriteLine($"{gunny.name} of {gunny.homePlanet} was created at {gunny.Instantiated:hh:mm:ss} on a {gunny.Instantiated:dddd}");
//Person zoe = new(){name = "Zoe",DateOfBirth = new(1980,12,19)};
//WriteLine($"{zoe.origin} {zoe.age} {zoe.greeting}");
//zoe.favoriteIceCream = "Chocolate Fude";
//zoe.FavoritePrimaryColor = "Red";
//WriteLine($"{zoe.name}'s favorite ice-cream is {zoe.favoriteIceCream}.\n{zoe.name}'s favorite color is {zoe.FavoritePrimaryColor}.");
// zoe.Children.Add(new Person {name = "Charlie"});
// zoe.Children.Add(new Person {name = "Ella"});
// WriteLine($"{zoe.name}'s first  child is {zoe[0].name}.");
// WriteLine($"{zoe.name}'s second child is {zoe.Children[1].name}.");
//Employee john = new(){name = "John Jones", DateOfBirth = new (1990,7,28)};
//john.WriteToConsole();
//john.EmployeeCode = "JJ1";
//john.HireDate = new(2014,11,23);
//WriteLine($"{john.name} was hired on {john.HireDate:dd/MM/yy}");
//john.WriteToConsole();
// Employee aliceInEmploye = new() { name = "Alice", EmployeeCode = "AA2" };
// Person aliceInPerson = aliceInEmploye;
// aliceInEmploye.WriteToConsole();
// aliceInPerson.WriteToConsole();
// WriteLine(aliceInEmploye.ToString());
// WriteLine(aliceInPerson.ToString());
// if (aliceInPerson is Employee)
// {
//     WriteLine($"{nameof(aliceInPerson)} Is an Employee");
//     Employee explicitAlice = (Employee)aliceInPerson;
// }
// Employee? aliceAsEmployee = aliceInPerson as Employee;
// if(aliceAsEmployee != null)
// {
//     WriteLine($"{nameof(aliceInPerson)} As an Employee");
// }
// try
// {
//     Employee? aliceAsEmployee = aliceInPerson as Employee;
//     Employee explicitAlice = (Employee)aliceInPerson;
// }
// catch (InvalidCastException)
// {
//     WriteLine("Something went wrong.");
// }
// catch (Exception e)
// {
//     WriteLine($"{e.Message}");
// }
// var t1 = new Thing();
// t1.Data = 42;
// WriteLine($"Thing with an integer: {t1.Process(42)}");
// var t2 = new Thing();
// t1.Data = "apple";
// WriteLine($"Thing with a integer: {t1.Process("apple")}");
// var gt1 = new GenericThing<int>();
// gt1.Data = 42;
// WriteLine($"GenericThing with an integer: {gt1.Process(42)}");
// var gt2 = new GenericThing<string>();
// gt2.Data = "apple";
// WriteLine($"GenericThing with a string: {gt2.Process("apple")}");*/
string number1 = "4";
WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");
byte number2 = 3;
WriteLine($"{number2} squared is {Squarer.Square(number2)}");
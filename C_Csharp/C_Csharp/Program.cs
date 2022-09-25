    using C_Csharp;
using System.Reflection.Emit;
using System.Xml.Linq;
using static C_Csharp.Enumeration;

//Console.WriteLine("Hello, World!");

//Chapter1 hlo = new Chapter1();
//hlo.hello();


//   DataTypes type = new DataTypes();

// DataTypes.datatype();

//Passing the copy value of number variable
/*
int val = type.Value_Type(5);
Console.WriteLine(val);
string Name = type.Value_Type("Nitish Mehta");
Console.WriteLine(Name);
type.Value_Type(909, "Nitish");

int number = type.Value_Type(09);
string Nam = type.Value_Type("Nitish Kumar");
Console.WriteLine(Nam);
Console.WriteLine(".....................");
Console.WriteLine(number);
type.excercise();
type.student("Nitish",369,18,12,"IGNOU");

Operator oper = new Operator();
oper.vowel();
oper.AreaOfRectange();
oper.evenorodd();
oper.power();

Statement stat = new Statement();
stat.Switch();
stat.days();
*/
//AllStatement state = new AllStatement();
// state.block();
/*
int i = 0;
while (state.empty())
{
    ; //Empty Statement
}
Console.WriteLine("i = {0}", i);
Console.ReadLine();

*/
// state.Goto();
// state.break_statements();
//state.Continue();
//state.THROW();
//state.Unchecked_Statement();

//  // creating lock segment.
//  all the resources that is used in lock segment, can't be used by another thread until it releases.
/*
lock (state)
{
   state.Lock_Statement();
}
state.Lock_Statement();

*/
/*
//An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
attandance enumm = attandance.Monday;
Console.WriteLine(enumm);
Month check = Month.May;

Structure st = new Structure();
st.str();
Console.WriteLine("Selected month is {0} ",check);
*/
//LoopConstructs loop = new LoopConstructs();
//loop.WhileLoop();
/*
PublicAccessSpecifier access = new PublicAccessSpecifier();
label:
Console.Write("Enter your name:\t");
// Accepting value in public variable that is outside the class
access.name = Console.ReadLine();
Console.Write("Enter your City Name:\t");
// Accepting value in public variable that is outside the class
access.city = Console.ReadLine();
Console.Write("Enter your area ZipCode:\t");
// Accepting value in public variable that is outside the class
access.ZipCode = int.Parse(Console.ReadLine());
access.AccessSpecifier();
goto label;
*/
/*
// ENCAPSULATION USING PROPERTIES
PrivateAccessSpecifiers Private = new PrivateAccessSpecifiers();
Private.getname = "Nitish Mehta";
Private.getcity = "Bangalore";
Private.getZipCode = 560068;
Private.AccessSpecifier();
Private.getpartname = ".NetDeveloper";

*/
Bank b = new Bank();
b.AccountNumber = 12345678;
b.Balance = 546868;
b.Name = "Mehta";
b.GetBalance();
b.WithdrawAmount();
//b.getbalance = 15444;
Console.WriteLine(b.getbalance);
b.SetBalance(56546862);
b.SetBalance(500);
Console.WriteLine(b.GetBalance());


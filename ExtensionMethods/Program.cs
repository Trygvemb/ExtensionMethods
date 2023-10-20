// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

//string s = "abcde";

//Console.WriteLine(s);

////Console.WriteLine(i);
////Console.WriteLine(i);

//Console.WriteLine(s.Shift(-2));
//Console.WriteLine(s.Shift(2));
//Console.WriteLine(s.Shift(0));
DateTime birth = new DateTime(2013, 1, 1);
int age = birth.Age(new DateTime(2013, 12, 30));

Console.WriteLine(age);

Console.ReadKey();
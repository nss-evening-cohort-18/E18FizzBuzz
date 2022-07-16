//FizzBuzz - Print integers 1 to 100,
//but print “Fizz” if an integer is divisible by 3,
//“Buzz” if an integer is divisible by 5,
//and “FizzBuzz” if an integer is divisible by both 3 and 5.

string[] fizz = new string[3] { "Fizz", "", "" };
string[] buzz = new string[5] { "Buzz", "", "", "", "" };
string valueToPrint;

for (int i = 1; i <= 100; i++)
{
    valueToPrint = i.ToString().PadRight(8); //"3       "
    valueToPrint += fizz[i % 3];//"3       Fizz"
    valueToPrint += buzz[i % 5];

    Console.WriteLine(valueToPrint.Substring(valueToPrint.Length - 8).Trim());
}

Console.ReadLine();
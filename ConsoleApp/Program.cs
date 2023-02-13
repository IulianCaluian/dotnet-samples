using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
       var numbers =  ProgramHelpers.ReadAllNumbersFromAFile();

        ProgramHelpers.Sort(numbers, 0, numbers.Count);

        Console.WriteLine(string.Join(',', numbers));
    }
}
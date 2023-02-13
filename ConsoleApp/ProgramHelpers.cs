using System.Text.RegularExpressions;

internal static class ProgramHelpers
{

    internal static void ReadAllNumbersFromAFile()
    {
        string[] lines = File.ReadAllLines("Input.txt");
        foreach (string line in lines)
        {
            Regex re = new Regex(@"\d+");
            MatchCollection m = re.Matches(line);

            foreach (Match m2 in m)
            {
                Int32 nr = Int32.Parse(m2.Value);
                Console.WriteLine(nr);
            }
        }
    }
}
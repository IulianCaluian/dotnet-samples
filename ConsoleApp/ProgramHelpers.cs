using System.Text.RegularExpressions;

internal static class ProgramHelpers
{

    internal static List<int> ReadAllNumbersFromAFile()
    {
        List<int> numbers = new List<int>();

        string[] lines = File.ReadAllLines("Input.txt");
        foreach (string line in lines)
        {
            Regex re = new Regex(@"\d+");
            MatchCollection m = re.Matches(line);

            foreach (Match m2 in m)
            {
                Int32 nr = Int32.Parse(m2.Value);
                numbers.Add(nr);
            }
        }

        return numbers;

    }

    internal static void Sort(List<int> ints, int start, int count)
    {
        if (count <= 1) return;

        int pivot = ints[start];

        int l = start;
        int r = start + count - 1;


        while (l <= r)
        {
            if (ints[l] <= pivot)
            {
                l++;
            }
            else if (ints[r] > pivot)
            {
                r--;
            }
            else
            {
                int aux = ints[r];
                ints[r] = ints[l];
                ints[l] = aux;
                r--; l++;
            }
        }

        ints[r] = pivot;

        Sort(ints, start, r - start);
        Sort(ints, r + 1, start + count - (r + 1));

    }
}
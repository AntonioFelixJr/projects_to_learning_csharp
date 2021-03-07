using System;

namespace FuncoesStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";
            string saida = $"|{original}|";

            string s1 = original.ToUpper();
            saida += $"\nToUpper: |{s1}|";

            s1 = original.ToLower();
            saida += $"\nToLower: |{s1}|";

            s1 = original.Trim();
            saida += $"\nTrim: |{s1}|";

            int n1 = original.IndexOf("bc");
            saida += $"\nIndexOf(\"bc\"): |{n1}|";

            n1 = original.LastIndexOf("bc");
            saida += $"\nLastIndexOf(\"bc\"): |{n1}|";

            s1 = original.Substring(3);
            saida += $"\nSubstring(3): |{s1}|";

            s1 = original.Substring(3, 5);
            saida += $"\nSubstring(3, 5): |{s1}|";

            s1 = original.Replace("a", "x");
            saida += $"\nReplace(\"a\", \"x\"): |{s1}|";

            s1 = original.Replace("abc", "xy");
            saida += $"\nReplace(\"abc\", \"xy\"): |{s1}|";

            bool b1 = String.IsNullOrEmpty(original);
            saida += $"\nString.IsNullOrEmpty: |{b1}|";

            b1 = String.IsNullOrWhiteSpace(original);
            saida += $"\nString.IsNullOrEmpty: |{b1}|";

            Console.WriteLine(saida);
        }
    }
}

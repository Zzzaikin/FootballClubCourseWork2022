using ImportLokomotivStats.DTO;
using System;
using System.Collections.Generic;

namespace ImportLokomotivStats
{
    internal static class App
    {
        internal static void Run()
        {
            RunImport(2019);
            RunImport(2020);
        }

        private static List<MatchResult> GetMatchResults(int year)
        {
            ValidateYear(year);
            var matchResults = Parser.GetMatchResults(year);

            return matchResults;
        }

        private static void ValidateYear(int year)
        {
            if ((year <= 0) || (year < 1970) || (year > DateTime.Now.Year))
            {
                throw new ArgumentException($"Uncorrect year - {year}");
            }
        }

        private static void RunImport(int year)
        {
            var matchResults = GetMatchResults(year);
            var succes = Ecxel.Import(matchResults);

            Console.WriteLine($"Import is succesfull - {succes}");
        }
    }
}

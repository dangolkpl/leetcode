using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Leetcode
{
    class Result
    {
        /*
         * Complete the 'countTeams' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY skills
         *  2. INTEGER minPlayers
         *  3. INTEGER minLevel
         *  4. INTEGER maxLevel
         */

        public static int countTeams(List<int> skills, int minPlayers, int minLevel, int maxLevel)
        {
            int qualifiedPlayers = 0;

            foreach (int lvl in skills)
            {
                if (lvl >= minLevel && lvl <= maxLevel)
                {
                    ++qualifiedPlayers;
                }
            }

            return getMaxGroupsNumber(qualifiedPlayers, minPlayers);
        }

        public static int getMaxGroupsNumber(int numberOfPlayers, int minPlayers)
        {
            /*
            There is a formula to calculate subgroup matches in group
            
            matches = (group (group - 1)) / subgroup
            
            Assume:
             Group has 4 members
             Subgroup has 3 members
             
             Number of subgroups can be made is (4 (4-1)) / 3 = 4
             
             In our case we can make bigger number of groups 
             So Number of groups:
                Subgroups with 3 + and Entire group itsef = 4 + 1 = 5;
            
            */

            if (numberOfPlayers < minPlayers)
                return 0;
            long result = 0;
            for (int i = minPlayers; i < numberOfPlayers; i++)
            {
                result = result + ((numberOfPlayers * (numberOfPlayers - 1)) / i);
            }

            return (int) result + 1;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int skillsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> skills = new List<int>();

            for (int i = 0; i < skillsCount; i++)
            {
                int skillsItem = Convert.ToInt32(Console.ReadLine().Trim());
                skills.Add(skillsItem);
            }

            int minPlayers = Convert.ToInt32(Console.ReadLine().Trim());

            int minLevel = Convert.ToInt32(Console.ReadLine().Trim());

            int maxLevel = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.countTeams(skills, minPlayers, minLevel, maxLevel);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

    class ikm
    {
        static void foo(string s)
        {
            Console.WriteLine("string");
        }
        static void foo(int i)
        {
            Console.WriteLine("interger");
        }
        static void foo(object o)
        {
            Console.WriteLine("object");
        }

        static void Main()
        {
            object x = "string";
            foo(x);
            dynamic y = "string";
            foo(y);
        }
    }
}
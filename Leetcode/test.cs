using System;

namespace Leetcode
{
    public class test
    {
        public test()
        {
        }

        void practice()
        {
            Coordinate point = new Coordinate();

            Console.WriteLine(point.x); //output: 10  
            Console.WriteLine(point.y);
        }
    }

    struct Coordinate
    {
        public int x;
        public int y;


        public Coordinate(int x, int y)
        {
            this.x = 1;
            this.y = 2;
        }
    }

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }

    class FileInfo : IFile
    {
        public override bool Equals(object? obj)
        {
            int i = 0;
            return base.Equals(obj);
        }

        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }
    }
}
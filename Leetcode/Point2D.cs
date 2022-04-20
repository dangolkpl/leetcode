using System;

namespace Leetcode
{
    public class Point2D
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public  double dist2D( Point2D cur, Point2D p)
        {
            return Math.Sqrt(Math.Pow(System.Convert.ToDouble(cur.x - p.x), 2) +
                             Math.Pow(System.Convert.ToDouble(cur.y - p.y), 2));
        }

        public void printDistance(double d)
        {
            Console.WriteLine(String.Format("2D distance = {0}", Math.Ceiling(d)));
        }
    }

    public class Point3D : Point2D
    {
        public int z { get; set; }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public  double dist3D( Point3D cur, Point3D p)
        {
            return Math.Sqrt(Math.Pow(System.Convert.ToDouble(cur.x - p.x), 2)
                             + Math.Pow(System.Convert.ToDouble(cur.y - p.y), 2)
                             + Math.Pow(System.Convert.ToDouble(cur.z - p.z), 2)
            );
        }

        public void printDistance(double d)
        {
            Console.WriteLine(String.Format("3D distance = {0}", Math.Ceiling(d)));
        }
    }
}
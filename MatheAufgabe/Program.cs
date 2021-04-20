using System;

namespace MatheAufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A:");
            string[] inputA = Parser(Console.ReadLine());
            Point3D a = new Point3D(Convert.ToDouble(inputA[0]), Convert.ToDouble(inputA[1]), Convert.ToDouble(inputA[2]));
            Console.Write("");

            Console.Write("B:");
            string[] inputB = Parser(Console.ReadLine());
            Point3D b = new Point3D(Convert.ToDouble(inputB[0]), Convert.ToDouble(inputB[1]), Convert.ToDouble(inputB[2]));
            Console.Write("");

            Console.Write("C:");
            string[] inputC = Parser(Console.ReadLine());
            Point3D c = new Point3D(Convert.ToDouble(inputC[0]), Convert.ToDouble(inputC[1]), Convert.ToDouble(inputC[2]));
            Console.Write("");



            Console.WriteLine("a)");
            Console.WriteLine("");
            drehenRechts(a, b, c);

            Console.WriteLine("");
            Console.WriteLine("b)");
            Console.WriteLine("");
            Drehen2MalVorne(a, b, c);

            Console.WriteLine();
            Console.WriteLine("c)");
            Console.WriteLine();
            Drehen2MalLinks(a, b, c);

            Console.WriteLine();
            Console.WriteLine("d)");
            Console.WriteLine();
            Drehe1MalVorne2MalRechts(a, b, c);
        }
        public static void drehenRechts(Point3D a, Point3D b, Point3D e)
        {
            double länge = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));

            Point3D c = new Point3D(b.X - länge, b.Y, b.Z);
            Point3D d = new Point3D(a.X - länge, a.Y, a.Z);
            Point3D f = new Point3D(b.X, b.Y, b.Z + länge);
            Point3D g = new Point3D(f.X - länge, f.Y, f.Z);
            Point3D h = new Point3D(e.X - länge, e.Y, e.Z);

            Point3D aS = new Point3D(f);
            Point3D bS = new Point3D(b);
            Point3D cS = new Point3D(c);
            Point3D dS = new Point3D(g);
            Point3D eS = new Point3D(f.X, f.Y + länge, f.Z);
            Point3D fS = new Point3D(b.X, b.Y + länge, b.Z);
            Point3D gS = new Point3D(c.X, c.Y + länge, c.Z);
            Point3D hS = new Point3D(g.X, g.Y + länge, g.Z);

            print(aS, "a");
            print(bS, "b");
            print(cS, "c");
            print(dS, "d");
            print(eS, "e");
            print(fS, "f");
            print(gS, "g");
            print(hS, "h");
        }
        public static void Drehen2MalVorne(Point3D a, Point3D b, Point3D e)
        {
            double länge = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));

            Point3D c = new Point3D(b.X - länge, b.Y, b.Z);
            Point3D d = new Point3D(a.X - länge, a.Y, a.Z);
            Point3D f = new Point3D(b.X, b.Y, b.Z + länge);
            Point3D g = new Point3D(f.X - länge, f.Y, f.Z);
            Point3D h = new Point3D(e.X - länge, e.Y, e.Z);

            Point3D aS = new Point3D(e.X + länge, e.Y, e.Z);
            Point3D bS = new Point3D(f.X + länge, f.Y, f.Z);
            Point3D cS = new Point3D(f.X + länge * 2, f.Y, f.Z);
            Point3D dS = new Point3D(e.X + länge * 2, e.Y, e.Z);
            Point3D eS = new Point3D(a.X + länge * 2, a.Y, a.Z);
            Point3D fS = new Point3D(b.X + länge, b.Y, b.Z);
            Point3D gS = new Point3D(b.X + länge * 2, b.Y, b.Z);
            Point3D hS = new Point3D(a.X + länge * 2, a.Y, a.Z);

            print(aS, "a");
            print(bS, "b");
            print(cS, "c");
            print(dS, "d");
            print(eS, "e");
            print(fS, "f");
            print(gS, "g");
            print(hS, "h");
        }
        public static void Drehen2MalLinks(Point3D a, Point3D b, Point3D e)
        {
            double länge = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));

            Point3D c = new Point3D(b.X - länge, b.Y, b.Z);
            Point3D d = new Point3D(a.X - länge, a.Y, a.Z);
            Point3D f = new Point3D(b.X, b.Y, b.Z + länge);
            Point3D g = new Point3D(f.X - länge, f.Y, f.Z);
            Point3D h = new Point3D(e.X - länge, e.Y, e.Z);

            Point3D aS = new Point3D(e.X, e.Y - länge, e.Z);
            Point3D bS = new Point3D(f.X, f.Y - länge, f.Z);
            Point3D cS = new Point3D(f.X, f.Y - länge * 2, f.Z);
            Point3D dS = new Point3D(e.X, e.Y - länge * 2, e.Z);
            Point3D eS = new Point3D(a.X, a.Y - länge, a.Z);
            Point3D fS = new Point3D(b.X, b.Y - länge, b.Z);
            Point3D gS = new Point3D(b.X, b.Y - länge * 2, b.Z);
            Point3D hS = new Point3D(a.X, a.Y - länge * 2, a.Z);

            print(aS, "a");
            print(bS, "b");
            print(cS, "c");
            print(dS, "d");
            print(eS, "e");
            print(fS, "f");
            print(gS, "g");
            print(hS, "h");
        }
        public static void Drehe1MalVorne2MalRechts(Point3D a, Point3D b, Point3D e)
        {
            double länge = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));

            Point3D c = new Point3D(b.X - länge, b.Y, b.Z);
            Point3D d = new Point3D(a.X - länge, a.Y, a.Z);
            Point3D f = new Point3D(b.X, b.Y, b.Z + länge);
            Point3D g = new Point3D(f.X - länge, f.Y, f.Z);
            Point3D h = new Point3D(e.X - länge, e.Y, e.Z);

            Point3D aS = new Point3D(f.X, f.Y + länge * 2, f.Z);
            Point3D bS = new Point3D(f.X, f.Y + länge, f.Z);
            Point3D cS = new Point3D(b.X, b.Y + länge, b.Z);
            Point3D dS = new Point3D(b.X, b.Y + länge * 2, b.Z);
            Point3D eS = new Point3D(f.X + länge, f.Y + länge * 2, f.Z);
            Point3D fS = new Point3D(f.X + länge, f.Y + länge, f.Z);
            Point3D gS = new Point3D(b.X + länge, b.Y + länge, b.Z);
            Point3D hS = new Point3D(b.X + länge, b.Y + länge * 2, b.Z);

            print(aS, "a");
            print(bS, "b");
            print(cS, "c");
            print(dS, "d");
            print(eS, "e");
            print(fS, "f");
            print(gS, "g");
            print(hS, "h");
        }
        public static string[] Parser(string input)
        {
            char[] ar = { ',' };
            string[] Out = input.Split(ar);
            return Out;
        }
        public static void print(Point3D a, string st)
        {
            Console.Write(st);
            Console.Write("(");
            Console.Write(a.X);
            Console.Write(",");
            Console.Write(a.Y);
            Console.Write(",");
            Console.Write(a.Z);
            Console.Write(")");
            Console.WriteLine("");
        }
    }
    class Point3D
    {
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D(Point3D a)
        {
            X = a.X;
            Y = a.Y;
            Z = a.Z;
        }

        public double X;
        public double Y;
        public double Z;

    }
}

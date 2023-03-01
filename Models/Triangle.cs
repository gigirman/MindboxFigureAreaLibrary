namespace MindboxFigureAreaLibrary
{
    public class Triangle : IFigureAreaService
    {
        public Triangle(double a, double b, double c)
        {

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("The side of the triangle cannot be negative");
            }
            else if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new Exception("This is not a triangle");
            }
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public double GetArea()
        {
            double p = A + B + C;
            int triangleType = GetTriangleType();

            if (triangleType == 0 || triangleType == 2 || triangleType ==3)
            {
                return Math.Sqrt(p / 2 * (p / 2 - A) * (p / 2 - B) * (p / 2 - C));
            }
            else if (triangleType == 1)
            {
                return ((Math.Sqrt(3)) / 4) * A*A;
            }

            return -1;
        }

        public int GetTriangleType()
        {
            if (A == B && B == C)
                return TriangleType.equilateralTriangle;
            if (A == B || A == C || B == C)
                return TriangleType.isoscelesTriangle;
            if (A * A == B * B + C * C || B * B == A * A + C * C || C * C == B * B + A * A)
                return TriangleType.rightTriangle;

            return TriangleType.justTriangle;
        }
    }
}

namespace ExampleForUnitTests
{
    public class Triangle
    {
        private double _sideFirstTriangle;
        private double _sideSecondTriangle;
        private double _sideThirdTriangle;

        public double SideFirstTriangle
        {
            get { return _sideFirstTriangle; }
            set { _sideSecondTriangle = value; }
        }

        public double SideSecondTriangle
        {
            get { return _sideSecondTriangle; }
            set { _sideSecondTriangle = value; }
        }

        public double SideThirdTriangle
        {
            get { return _sideThirdTriangle; }
            set { _sideThirdTriangle = value; }
        }

        public double GetTriangleSide(string value)
        {
            if (double.Parse(value) <= 0)
            {
                throw new Exception("The triangle side is equal 0 or negative");
            }
            else
            {
                return double.Parse(value);
            }
        }

        public bool IsLengthTriangleSide(double oneSide, double twoSide, double threeSide)
        {
            if (oneSide > twoSide + threeSide || twoSide > oneSide + threeSide || threeSide > oneSide + twoSide)
            {
                throw new Exception("One of the side longer then sum other ones.");
            }
            else
            {
                return true;
            }
        }

        public double TriangleSquare(double oneSide, double twoSide, double threeSide)
        {
            double triangleHalfPerimeter = (oneSide + threeSide + threeSide) / 2;
            double triangleSquare = Math.Sqrt(triangleHalfPerimeter * (triangleHalfPerimeter - oneSide) * (triangleHalfPerimeter - twoSide) * (triangleHalfPerimeter - threeSide));
            return Math.Round(triangleSquare, 2, MidpointRounding.AwayFromZero);
        }
    }
}
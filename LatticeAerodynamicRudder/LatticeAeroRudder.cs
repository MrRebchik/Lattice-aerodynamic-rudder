using AerodynamicRudder;
using System.Reflection.Metadata.Ecma335;

namespace LatticeAerodynamicRudder
{
    public class LatticeAeroRudder : AerounamicRudder
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double BorderThickness { get; set; }
        public double BorderDistance { get; set; }
        public double InnerEdgeThickness { get; set; }
        double stepLength
        {
            get => BorderDistance + BorderThickness;
        }
        public override double GetAreaWithCurrentAngel(double angleDegrees)
        {
            return GetPerimeter() * Depth * Math.Cos(angleDegrees/ 57.3);
        }
        double GetPerimeter()
        {
            double lessSide = Height < Width ? Height : Width;
            double biggerSide = Height >= Width ? Width : Height;
            double square, rectangle;
            square = 8 * (GetArithmeticProgressionSum(GetStepsCount(lessSide)) + lessSide);
            var reducedLessSide = lessSide * Math.Sqrt(2);
            var reducedDifference = (biggerSide - lessSide) * Math.Sqrt(2);
            rectangle = biggerSide - lessSide * (DivideInteger(lessSide,stepLength)+ lessSide * (DivideInteger(biggerSide-lessSide, stepLength)));
            return square + rectangle;
        }
        double GetArithmeticProgressionSum(int steps)
        {
            return (steps - 1) * steps * stepLength * 0.5;
        }
        int GetStepsCount(double length)
        {
            var reducedStepLength = stepLength * Math.Sqrt(2);
            return DivideInteger(length,reducedStepLength);
        }
        int DivideInteger(double a, double b)
        {
            return (int)((a - a % b) / b);
        }
    }
}

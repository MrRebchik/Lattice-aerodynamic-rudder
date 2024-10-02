using AerodynamicRudder;
using System.Reflection.Metadata.Ecma335;

namespace LatticeAerodynamicRudder
{
    public class LatticeAeroRudder : AerounamicRudder
    {
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal BorderThickness { get; set; }
        public decimal BorderDistance { get; set; }
        public decimal InnerEdgeThickness { get; set; }
        decimal stepLength
        {
            get => BorderDistance + BorderThickness;
        }
        public override decimal GetAreaWithCurrentAngel(decimal angle)
        {
            return GetPerimeter() * Depth * (decimal)Math.Cos((double)angle);
        }
        decimal GetPerimeter()
        {
            decimal lessSide = Height < Width ? Height : Width;
            decimal biggerSide = Height >= Width ? Width : Height;
            decimal square, rectangle;
            square = 8 * (GetArithmeticProgressionSum(GetStepsCount(lessSide)) + lessSide);
            var reducedLessSide = lessSide * (decimal)Math.Sqrt(2);
            var reducedDifference = (biggerSide - lessSide) * (decimal)Math.Sqrt(2);
            rectangle = biggerSide - lessSide * (DivideInteger(lessSide,stepLength)+ lessSide * (DivideInteger(biggerSide-lessSide, stepLength)));
            return square + rectangle;
        }
        decimal GetArithmeticProgressionSum(int steps)
        {
            return (steps - 1) * steps * stepLength * 0.5m;
        }
        int GetStepsCount(decimal length)
        {
            var reducedStepLength = stepLength * (decimal)Math.Sqrt(2);
            return DivideInteger(length,reducedStepLength);
        }
        int DivideInteger(decimal a, decimal b)
        {
            return (int)((a - a % b) / b);
        }
    }
}

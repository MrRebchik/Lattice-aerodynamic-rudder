using AerodynamicRudder;

namespace LatticeAerodynamicRudder
{
    public class LatticeAeroRudder : AerounamicRudder
    {
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal BorderThickness { get; set; }
        public decimal InnerEdgeThickness { get; set; }
        public override decimal GetAreaWithCurrentAngel(decimal angle)
        {
            throw new NotImplementedException();
        }
    }
}

using LatticeAerodynamicRudder;

namespace LatticeTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            LatticeAeroRudder a = new LatticeAeroRudder();
            a.Height = 0.7m;
            a.Width = 0.35m;
            a.Depth = 0.05m;
            a.BorderThickness = 0.01m;
            a.InnerEdgeThickness = 0.005m;
            a.BorderDistance = 0.05m;

            var area = a.GetAreaWithCurrentAngel(0);
            Assert.Equal(0.214m, area);
        }
    }
}
using LatticeAerodynamicRudder;

namespace LatticeTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            LatticeAeroRudder a = new LatticeAeroRudder();
            a.Height = 0.7;
            a.Width = 0.35;
            a.Depth = 0.05;
            a.BorderThickness = 0.01;
            a.InnerEdgeThickness = 0.005;
            a.BorderDistance = 0.05;

            var area = a.GetAreaWithCurrentAngel(0);
            Assert.Equal(0.214, area);
        }
    }
}
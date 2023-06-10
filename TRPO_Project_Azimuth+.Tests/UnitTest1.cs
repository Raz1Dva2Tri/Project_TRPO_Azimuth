namespace TRPO_Project_Azimuth_.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AzimuthTest()
        {
            Azimuth azimuth = new(155, 10);
            double z = azimuth.ObrDirUgl;
            int b = azimuth.MRLD;
        }
    }
}
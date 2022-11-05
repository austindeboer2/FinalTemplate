using System.Runtime.ConstrainedExecution;

namespace Random10Test
{
    public class Tests
    {
        Final final;
        [SetUp]
        public void Setup()
        {
            final = new Final();
        }

        [Test]
        public void Test1()
        {
            int found1 = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (final.Random10() == 1) found1++;
            }
            if(found1 > 950 && found1 < 1050) Assert.Pass();
            else Assert.Fail("Your random distribution has falled outside of the acceptable limits. You may need to look at what random numbers you are generating."); 
        }
    }
}
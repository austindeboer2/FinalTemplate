namespace BigATest
{
    public class Tests
    {
        Final final;
        Random r;
        [SetUp]
        public void Setup()
        {
            final = new Final();
            r = new Random();
        }

        [Test]
        public void Test1()
        {

            bool passing = true;
            string failMessage = "";
            for (int i = 0; i < 10000; i++)
            {
                int first = r.Next(1, 100); 
                int second = r.Next(1, 100); 
                bool equal = false;
                if (second > first) equal = true;
                if (final.BigA(second, first) != equal)
                {
                    passing = false;
                    failMessage = "Given Parameters, A: " + first + " B: " + second + " The expected output is " + equal + ". Your output was " + final.BigA(second, first);
                }
            }
            if (passing) Assert.Pass();
            else Assert.Fail(failMessage);
        }
    }
}
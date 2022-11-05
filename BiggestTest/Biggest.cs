namespace BiggestTest
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
            for (int i = 0; i < 100; i++)
            {
                int first = r.Next(1, 100);
                int second = r.Next(1, 100);
                while (second == first) second = r.Next();
                int third = r.Next(1, 100);
                while (third == first || third == second) third = r.Next();
                int fourth = 0;
                if(first > second)
                {
                    if (first > third) fourth = first;
                    else fourth = third;
                }
                else
                {
                    if (second > third) fourth = second;
                    else fourth = third;
                }
                if (final.Biggest(first, second, third) != fourth)
                {
                    passing = false;
                    failMessage = "Given Parameters, A: " + first + " B: " + second + " C: " + third + " The expected output is " + fourth + ". Your output was " + final.Biggest(first, second, third);
                }
            }
            if (passing) Assert.Pass();
            else Assert.Fail(failMessage);
        }
    }
}
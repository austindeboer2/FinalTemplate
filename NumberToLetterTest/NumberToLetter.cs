namespace NumberToLetterTest
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
            if (!final.NumberToLetter(1).Equals("A")) Assert.Fail("Expected output: A, Your Output: " + final.NumberToLetter(1));
            if (!final.NumberToLetter(2).Equals("B")) Assert.Fail("Expected output: B, Your Output: " + final.NumberToLetter(2));
            if (!final.NumberToLetter(3).Equals("C")) Assert.Fail("Expected output: C, Your Output: " + final.NumberToLetter(3));
            if (!final.NumberToLetter(4).Equals("D")) Assert.Fail("Expected output: D, Your Output: " + final.NumberToLetter(4));
            if (!final.NumberToLetter(5).Equals("E")) Assert.Fail("Expected output: E, Your Output: " + final.NumberToLetter(5));

            Assert.Pass();
        }
    }
}
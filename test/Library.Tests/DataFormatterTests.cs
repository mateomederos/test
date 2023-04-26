namespace TestDateFormat
{
       public class DateFormatterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDateWithFormatOk()
        {
        const string input = "10/11/1977";
        const string expected = "1977-11-10";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void DateLengthIsValid()
        {
        const string input = "10-11-19777";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
        }
    }


}


 
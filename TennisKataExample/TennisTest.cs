namespace TennisKataExample;

public class TennisTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Love_All()
    {
        var tennis = new Tennis();
        Assert.AreEqual("Love All", tennis.Score());
    }
}
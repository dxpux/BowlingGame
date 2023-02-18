namespace TennisKataExample;

public class TennisTest
{
    private Tennis _tennis;

    [SetUp]
    public void Setup()
    {
        _tennis = new Tennis();
    }

    [Test]
    public void Love_All()
    {
        ScoreShouldBe("Love All");
    }

    private void ScoreShouldBe(string expected)
    {
        Assert.AreEqual(expected, _tennis.Score());
    }
}
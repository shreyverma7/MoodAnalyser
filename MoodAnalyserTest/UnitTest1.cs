using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyser analyser = new MoodAnalyser();
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            string acutual = analyser.AnalyseMode(message);
            Assert.AreEqual(acutual, "SAD");
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = "I am in any Mood";
            string acutual = analyser.AnalyseMode(message);
            Assert.AreEqual(acutual, "HAPPY");
        }






    }
}
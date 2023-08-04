using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string acutual = analyser.AnalyseMode();
            Assert.AreEqual(acutual, "SAD");
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = "I am in any Mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string acutual = analyser.AnalyseMode();
            Assert.AreEqual(acutual, "HAPPY");
        }






    }
}
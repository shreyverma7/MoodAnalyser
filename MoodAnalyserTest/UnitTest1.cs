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
        [Test]
        public void GivenNullMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = null;
            MoodAnalyser analyser = new MoodAnalyser(message);
            try
            {
                string acutual = analyser.AnalyseMode();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        [Test]
        public void GivenEmptyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = "";
            MoodAnalyser analyser = new MoodAnalyser(message);
            try
            {
                string acutual = analyser.AnalyseMode();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }

    }
}
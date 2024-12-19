namespace Tasks.Tests
{
    [TestFixture]
    public class NumberGuesserTests
    {
        [Test]
        public void Test_CorrectGuess()
        {
            var game = new NumberGuesser(50);
            Assert.That(game.Guess(50), Is.EqualTo("Вы угадали!"));
        }

        [Test]
        public void Test_HigherGuess()
        {
            var game = new NumberGuesser(30);
            Assert.That(game.Guess(40), Is.EqualTo("Загаданное число меньше."));
        }

        [Test]
        public void Test_LowerGuess()
        {
            var game = new NumberGuesser(70);
            Assert.That(game.Guess(60), Is.EqualTo("Загаданное число больше."));
        }
    }
}
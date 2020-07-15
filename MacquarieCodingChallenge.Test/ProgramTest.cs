using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MacquarieCodingChallenge.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void Main()
        {
            Program.Main(new string[] { });
        }
        
        [TestMethod]
        public void TestCowProperties()
        {
            Animal cow = new Cow();
            Assert.AreEqual(cow.Type, "Cow");
            Assert.AreEqual(cow.Food, "grass");
            Assert.AreEqual(cow.Mobility, "walking");
            Assert.AreEqual(cow.LegCount, 4);
        }

        [TestMethod]
        public void TestDuckProperties()
        {
            Animal duck = new Duck();
            Assert.AreEqual(duck.Type, "Duck");
            Assert.AreEqual(duck.Food, "different kinds of food such as corn");
            Assert.AreEqual(duck.Mobility, "swimming");
            Assert.AreEqual(duck.LegCount, 2);
        }

        [TestMethod]
        public void TestBirdProperties()
        {
            Animal bird = new Bird();
            Assert.AreEqual(bird.Type, "Bird");
            Assert.AreEqual(bird.Food, "bird seed");
            Assert.AreEqual(bird.Mobility, "flying");
            Assert.AreEqual(bird.LegCount, 2);
        }
    }
}

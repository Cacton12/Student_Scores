using OOP_Final_Project;

namespace Teesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameValid_True()
        {
            Validator validator = new Validator();

            string name = "Colby Acton";
            bool result = validator.NameValid(name);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NameValid_False()
        {
            Validator validator = new Validator();

            string name = null;
            bool result = validator.NameValid(name);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NewScoresValid_True()
        {
            Validator validator = new Validator();

            int score = 50;
            bool result = validator.NewScoresValid(score);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NewScoresValid_False()
        {
            Validator validator = new Validator();

            int score = -10;
            bool result = validator.NewScoresValid(score);
            Assert.IsFalse(result);
        }
    }
}
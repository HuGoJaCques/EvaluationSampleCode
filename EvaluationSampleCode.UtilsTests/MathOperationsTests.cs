namespace EvaluationSampleCode.UtilsTests
{
    [TestClass]
    public sealed class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(2, 2)]
        public void Add_WithNumberPositive_ShouldReturnCorrectSum(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [DataRow(2, -4)]
        public void Add_WithNuberPositive_ShouldReturnCorrectSum(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(-2, result);
        }
    }
}

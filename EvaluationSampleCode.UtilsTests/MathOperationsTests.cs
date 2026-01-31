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

        //Test pour Add

        [TestMethod]
        [DataRow(2, 2)]
        public void Add_TwoPositiveNumbers_ShouldReturnCorrectSum(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [DataRow(2, -4)]
        public void Add_PositiveAndNegative_ShouldReturnCorrectSum(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        [DataRow(-5, -10)]
        public void Add_TwoNegativeNumbers_ShouldReturnCorrectSum(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(-15, result);
        }

        [TestMethod]
        [DataRow(40, 0)]
        public void Add_WithZero_ShouldReturnsOtherNumber(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(40, result);
        }

        [TestMethod]
        [DataRow(0, 0)]
        public void Add_WithTwoNumbersZero_ShouldReturnsZero(int numberOne, int numberTwo)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(0, result);
        }

        //Test pour Divide

        [TestMethod]
        [DataRow(10, 2)]
        public void Divide_NormalDivision_ShouldReturnsCorrectResult(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(5.0, result);
        }

        [TestMethod]
        [DataRow(10, 3)]
        public void Divide_NormalDivision_ShouldReturnsCorrectResultFloat(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(3.333333, result, 0.00001);
        }

        [TestMethod]
        [DataRow(10, 0)]
        public void Divide_ByZero_ShouldThrowsArgumentException(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Divide(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(10, -2)]
        public void Divide_NegativeDenominator_ShouldReturnsNegativetResult(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(-5.0, result);
        }

        [TestMethod]
        [DataRow(-10, -2)]
        public void Divide_TwoNegativeNumbers_ShouldReturnsPositiveResult(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(5.0, result);
        }

        [TestMethod]
        [DataRow(0, 5)]
        public void Divide_ZeroDividends_ShouldReturnsZero(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(0.0, result);
        }

        // Test pour GetOddNumbers

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void GetOddNumbers_NegativeLimit_ShouldThrowsArgumentException(int limit)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetOddNumbers(limit));
        }

        [TestMethod]
        [DataRow(0)]
        public void GetOddNumbers_LimitZero_ShouldReturnsEmptyList(int limit)
        {
            IEnumerable<int> result = _mathOperations.GetOddNumbers(limit);

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        [DataRow(1)]
        public void GetOddNumbers_LimitOne_ShouldReturnsListWithOne(int limit)
        {
            IEnumerable<int> result = _mathOperations.GetOddNumbers(limit);

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual(1, result.First());
        }

        [TestMethod]
        [DataRow(10)]
        public void GetOddNumbers_LimitTen_ShouldReturnsCorrectNumbers(int limit)
        {
            IEnumerable<int> result = _mathOperations.GetOddNumbers(limit);

            Assert.AreEqual(5, result.Count());
            CollectionAssert.AreEqual(new List<int> { 1, 3, 5, 7, 9 }, result.ToList());
        }

       



















    }
}

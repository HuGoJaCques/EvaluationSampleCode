namespace EvaluationSampleCode.UtilsTests
{
    [TestClass]
    public sealed class CustomStackTests
    {
        private CustomStack _customStack;

        [TestInitialize]
        public void Init()
        {
            _customStack = new CustomStack();
        }

        // Test pour Count()
        [TestMethod]
        public void Count_EmptyStack_ShouldReturnsZero()
        {
            int count = _customStack.Count();

            Assert.AreEqual(0, count);
        }


        [TestMethod]
        public void Count_AfterOnePush_ShouldReturnsOne()
        {
            _customStack.Push(5);

            int count = _customStack.Count();

            Assert.AreEqual(1, count);
        }

        
        [TestMethod]
        public void Count_AfterMultiplePush_ShouldReturnsCorrectCount()
        {
            _customStack.Push(1);
            _customStack.Push(2);
            _customStack.Push(3);

            int count = _customStack.Count();

            Assert.AreEqual(3, count);
        }

        //Test pour Push
        [TestMethod]
        public void Push_OneValue_ShouldReturnsCorrectCount()
        {
            _customStack.Push(10);  

            int count = _customStack.Count();          

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Push_MultipleValues_ShouldReturnsCorrectCount()
        {
            _customStack.Push(10);  
            _customStack.Push(20);  
            _customStack.Push(30);  

            int count = _customStack.Count();          

            Assert.AreEqual(3, count);
        }

        //Test pour Pop
        [TestMethod]
        public void Pop_EmptyStack_ShouldThrowsArgumentException()
        {
            Assert.ThrowsException<CustomStack.StackCantBeEmptyException>(() => _customStack.Pop());
        }

        [TestMethod]
        public void Pop_OneElement_ShouldReturnsCorrectValue()
        {
            _customStack.Push(42);

            int result = _customStack.Pop();

            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void Pop_OneElement_ShouldDecreasesCount()
        {
            _customStack.Push(10);

            _customStack.Pop();

            Assert.AreEqual(0, _customStack.Count());
        }

        [TestMethod]
        public void Pop_MultipleElement_ShouldReturnsLastElementAdd()
        {
            _customStack.Push(10);
            _customStack.Push(15);
            _customStack.Push(20);

            int result = _customStack.Pop();

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Pop_MultipleElement_ShouldCountDecreasesCorrect()
        {
            _customStack.Push(1);
            _customStack.Push(5);
            _customStack.Push(40);

            int result = _customStack.Pop();

            Assert.AreEqual(2, _customStack.Count());
        }
    }
}
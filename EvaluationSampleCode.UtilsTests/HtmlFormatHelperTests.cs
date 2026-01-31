namespace EvaluationSampleCode.UtilsTests
{
    [TestClass]
    public sealed class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
        public void Init()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }

        // Test pour GetBoldFormat
        [TestMethod]
        [DataRow("Hello")]
        public void GetBoldFormat_NormalTexte_ShouldReturnsTextInBoldTags(string content)
        {
            string result = _htmlFormatHelper.GetBoldFormat(content);

            Assert.AreEqual("<b>Hello</b>", result);
        }

        [TestMethod]
        [DataRow("")]
        public void GetBoldFormat_EmptyTexte_ShouldReturnsEmptyBoldTags(string content)
        {
            string result = _htmlFormatHelper.GetBoldFormat(content);

            Assert.AreEqual("<b></b>", result);
        }
        
        // Test pour GetItalicFormat
        [TestMethod]
        [DataRow("Hello")]
        public void GetItalicFormat_NormalTexte_ShouldReturnsTextInBoldTags(string content)
        {
            string result = _htmlFormatHelper.GetItalicFormat(content);

            Assert.AreEqual("<i>Hello</i>", result);
        }

        [TestMethod]
        [DataRow("")]
        public void GetItalicFormat_EmptyTexte_ShouldReturnsEmptyBoldTags(string content)
        {
            string result = _htmlFormatHelper.GetItalicFormat(content);

            Assert.AreEqual("<i></i>", result);
        }
        

        // Test pour GetFormattedListElements
        [TestMethod]
        public void GetFormattedListElements_EmptyList_ShouldReturnsEmptyUlTags()
        {
            List<string> emptyList = new List<string>();

            string result = _htmlFormatHelper.GetFormattedListElements(emptyList);

            Assert.AreEqual("<ul></ul>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_OneElement_ShouldReturnsCorrectHtml()
        {
            List<string> emptyList = new List<string> {"Item 1"};

            string result = _htmlFormatHelper.GetFormattedListElements(emptyList);

            Assert.AreEqual("<ul><li>Item 1</li></ul>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_MultipleElement_ShouldReturnsCorrectHtml()
        {
            List<string> emptyList = new List<string> {"Item 1", "Item 2", "Item 3"};

            string result = _htmlFormatHelper.GetFormattedListElements(emptyList);

            Assert.AreEqual("<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_EmptyStringElementInList_ShouldReturnsCorrectHtml()
        {
            List<string> emptyList = new List<string> {"Item 1", "", "Item 3"};

            string result = _htmlFormatHelper.GetFormattedListElements(emptyList);

            Assert.AreEqual("<ul><li>Item 1</li><li></li><li>Item 3</li></ul>", result);
        }
    }
}
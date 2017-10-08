using Microsoft.VisualStudio.TestTools.UnitTesting;
using JSTest;
using JSTest.ScriptLibraries;

namespace Test_WebPaint
{
    [TestClass]
    public class UnitTest
    {
        static private readonly TestScript _commonTestScript = new TestScript();

        [ClassInitialize]
        static public void CommonJavaScriptTests(TestContext tc)
        {
            _commonTestScript.AppendFile(@"D:\COURSE\paint\Paint WEB\testCommand.js");
            _commonTestScript.AppendBlock(new JsAssertLibrary());
        }

        [DataTestMethod]
        [DataRow("addTab", "addTab")]
        [DataRow("deleteTab", "deleteTab")]
        [DataRow("renameTab", "renameTab")]
        [DataRow("colorFigure", "colorF")]
        [DataRow("widthFigure", "widthF")]
        [DataRow("typeFigure", "typeF")]
        [DataRow("colorText", "colorTxt")]
        [DataRow("fontText", "fontTxt")]
        [DataRow("alignText", "alignTxt")]
        [DataRow("angleText", "angleTxt")]
        [DataRow("Plugin", "Plugin")]
        [DataRow("changeLanguage", "language")]
        [DataRow("changeSkin", "skin")]
        [DataRow("showHelp", "help")]
        [DataRow("showAbout", "about")]
        [DataRow("save", "save")]
        [DataRow("load", "load")]
        [DataRow("save in Cloud", "saveCloud")]
        [DataRow("load from Cloud", "loadCloud")]
        public void TestUnit(string res, string method)
        {
            _commonTestScript.RunTest($"assert.equal('{res}', new testCommand().{method}());");
        }
    }
}

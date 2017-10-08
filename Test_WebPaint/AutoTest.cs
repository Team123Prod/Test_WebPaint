using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace Test_WebPaint
{
    [TestClass]
    public class AutoTest
    {
        public static IWebDriver driver = null;
        POM pom;

        [OneTimeSetUp]
        public void DriverPath()
        {
            driver = new ChromeDriver();
            pom = new POM(driver);
        }
        
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            driver.Quit();
        }

        [SetUp]
        public void TestUp()
        {
            driver.Navigate().GoToUrl("file:///D:/COURSE/paint/Paint%20WEB/pagePaint.html");
        }

        //   --Menu--
        [TestCategory("File")]
        [TestCase("mAdd", "addTab")]
        [TestCase("mDel", "deleteTab")]
        [TestCase("mRename", "renameTab")]

        [TestCategory("Figure")]
        [TestCase("mColor", "colorFigure")]
        [TestCase("mWidth", "widthFigure")]
        [TestCase("mType", "typeFigure")]

        [TestCategory("Text")]
        [TestCase("mColorTxt", "colorText")]
        [TestCase("mFontTxt", "fontText")]
        [TestCase("mAlignTxt", "alignText")]
        [TestCase("mAngleTxt", "angleText")]

        [TestCategory("Plugins")]
        [TestCase("mEmptyFigure", "Plugin")]
        [TestCase("mFigureTxt", "Plugin")]
        [TestCase("mFigureImg", "Plugin")]

        [TestCategory("Settings")]
        [TestCase("mLanguage", "changeLanguage")]
        [TestCase("mSkin", "changeSkin")]

        [TestCategory("Help")]
        [TestCase("mHelp", "showHelp")]
        [TestCase("mAbout", "showAbout")]
        public void TestMenu(string elementId, string res)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript($"document.getElementById('{pom.FindElement(elementId).GetAttribute("id")}').click();");
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }

        //  --ToolBar--
        [TestCase("tAdd", "addTab")]

        [TestCase("tColorF", "colorFigure")]
        [TestCase("tWidthF", "widthFigure")]
        [TestCase("tTypeF", "typeFigure")]

        [TestCase("tColorTxt", "colorText")]
        [TestCase("tFontTxt", "fontText")]
        [TestCase("tAlignTxt", "alignText")]
        [TestCase("tAngleTxt", "angleText")]

        [TestCase("tSave", "save")]
        [TestCase("tLoad", "load")]
        [TestCase("tSaveCloud", "save in Cloud")]
        [TestCase("tLoadCloud", "load from Cloud")]

        public void TestToolBar(string elementId, string res)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript($"document.getElementById('{pom.FindElement(elementId).GetAttribute("id")}').click();");
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }
    }
}

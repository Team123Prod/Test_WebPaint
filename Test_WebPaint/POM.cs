using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test_WebPaint
{
    public class POM
    { 
        IWebDriver driver;
        public POM(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        // --Menu--
        By mAdd = By.Id("mAdd");
        By mDelete = By.Id("mDel");
        By mRename = By.Id("mRename");
        By mColor = By.Id("mColor");
        By mWidth = By.Id("mWidth");
        By mType = By.Id("mType");
        By mColorTxt = By.Id("mColorTxt");
        By mFontTxt = By.Id("mFontTxt");
        By mAlignTxt = By.Id("mAlignTxt");
        By mAngleTxt = By.Id("mAngleTxt");
        By mEmptyFigure = By.Id("mEmptyFigure");
        By mFigureTxt = By.Id("mFigureTxt");
        By mFigureImg = By.Id("mFigureImg");
        By mLanguage = By.Id("mLanguage");
        By mSkin = By.Id("mSkin");
        By mHelp = By.Id("mHelp");
        By mAbout = By.Id("mAbout");
        // --ToolBar--
        By tAdd = By.Id("tAdd");
        By tColorF = By.Id("tColorF");
        By tWidthF = By.Id("tWidthF");
        By tTypeF = By.Id("tTypeF");
        By tColorTxt = By.Id("tColorTxt");
        By tFontTxt = By.Id("tFontTxt");
        By tAlignTxt = By.Id("tAlignTxt");
        By tAngleTxt = By.Id("tAngleTxt");
        By tSave = By.Id("tSave");
        By tLoad = By.Id("tLoad");
        By tSaveCloud = By.Id("tSaveCloud");
        By tLoadCloud = By.Id("tLoadCloud");

        public IWebElement FindElement(string s)
        {
            IWebElement flag = null;
            switch (s)
            {
                //--Menu--
                case "mAdd":
                    flag = driver.FindElement(mAdd);
                    break;
                case "mDel":
                    flag = driver.FindElement(mDelete);
                    break;
                case "mRename":
                    flag = driver.FindElement(mRename);
                    break;
                case "mColor":
                    flag = driver.FindElement(mColor);
                    break;
                case "mWidth":
                    flag = driver.FindElement(mWidth);
                    break;
                case "mType":
                    flag = driver.FindElement(mType);
                    break;
                case "mColorTxt":
                    flag = driver.FindElement(mColorTxt);
                    break;
                case "mFontTxt":
                    flag = driver.FindElement(mFontTxt);
                    break;
                case "mAlignTxt":
                    flag = driver.FindElement(mAlignTxt);
                    break;
                case "mAngleTxt":
                    flag = driver.FindElement(mAngleTxt);
                    break;
                case "mEmptyFigure":
                    flag = driver.FindElement(mEmptyFigure);
                    break;
                case "mFigureTxt":
                    flag = driver.FindElement(mFigureTxt);
                    break;
                case "mFigureImg":
                    flag = driver.FindElement(mFigureImg);
                    break;
                case "mLanguage":
                    flag = driver.FindElement(mLanguage);
                    break;
                case "mSkin":
                    flag = driver.FindElement(mSkin);
                    break;
                case "mHelp":
                    flag = driver.FindElement(mHelp);
                    break;
                case "mAbout":
                    flag = driver.FindElement(mAbout);
                    break;

                    //--ToolBar--
                case "tAdd":
                    flag = driver.FindElement(tAdd);
                    break;
                case "tColorF":
                    flag = driver.FindElement(tColorF);
                    break;
                case "tWidthF":
                    flag = driver.FindElement(tWidthF);
                    break;
                case "tTypeF":
                    flag = driver.FindElement(tTypeF);
                    break;
                case "tColorTxt":
                    flag = driver.FindElement(tColorTxt);
                    break;
                case "tFontTxt":
                    flag = driver.FindElement(tFontTxt);
                    break;
                case "tAlignTxt":
                    flag = driver.FindElement(tAlignTxt);
                    break;
                case "tAngleTxt":
                    flag = driver.FindElement(tAngleTxt);
                    break;
                case "tSave":
                    flag = driver.FindElement(tSave);
                    break;
                case "tLoad":
                    flag = driver.FindElement(tLoad);
                    break;
                case "tSaveCloud":
                    flag = driver.FindElement(tSaveCloud);
                    break;
                case "tLoadCloud":
                    flag = driver.FindElement(tLoadCloud);
                    break;
                default:
                    break;
            }
            return flag;
        }

    }
}

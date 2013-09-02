﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TestAutomation
{
    [TestFixture]
    public class Driver
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Create a new instance of the Firefox driver
            driver = new FirefoxDriver();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        public void musicTest()
        {
            driver.Navigate().GoToUrl("http://mrcoles.com/piano/");
            IWebElement keys = driver.FindElement(By.ClassName("keys"));

            //Star Wars main theme
            int speed = 600;
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("g");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed * 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("g");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed * 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4 * 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4 * 6);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 8);
            keys.SendKeys("j");
            Thread.Sleep(speed / 8);
            keys.SendKeys("h");
            Thread.Sleep(speed / 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("t");
            Thread.Sleep(speed / 2);
            keys.SendKeys("s");
            Thread.Sleep(speed * 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4 * 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4 * 6);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fl");
            Thread.Sleep(speed / 8 * 7);
            keys.SendKeys("th");
            Thread.Sleep(speed / 8);
            keys.SendKeys("th");
            Thread.Sleep(speed * 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4 * 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4 * 6);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("h");
            Thread.Sleep(speed / 8);
            keys.SendKeys("j");
            Thread.Sleep(speed / 8);
            keys.SendKeys("h");
            Thread.Sleep(speed / 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("t");
            Thread.Sleep(speed / 2);
            keys.SendKeys("s");
            Thread.Sleep(speed / 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("f");
            Thread.Sleep(speed / 4);
            keys.SendKeys("e,");
            Thread.Sleep(speed / 2);
            keys.SendKeys("l");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 2);
            keys.SendKeys("u");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 2);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("l");
            Thread.Sleep(speed * 2);

            //Tetris
            speed = 400;
            keys.SendKeys("j;");
            Thread.Sleep(speed);
            keys.SendKeys("yj");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("jl");
            Thread.Sleep(speed / 2);
            keys.SendKeys(";");
            Thread.Sleep(speed / 4);
            keys.SendKeys("l");
            Thread.Sleep(speed / 4);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("yj");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dh");
            Thread.Sleep(speed);
            keys.SendKeys("dh");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("k;");
            Thread.Sleep(speed);
            keys.SendKeys("jl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("yj");
            Thread.Sleep(speed / 3 * 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 3 * 2);
            keys.SendKeys("j");
            Thread.Sleep(speed / 3 * 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("jl");
            Thread.Sleep(speed);
            keys.SendKeys("k;");
            Thread.Sleep(speed);
            keys.SendKeys("hk");
            Thread.Sleep(speed);
            keys.SendKeys("dh");
            Thread.Sleep(speed);
            keys.SendKeys("dh");
            Thread.Sleep(speed * 2);

            keys.SendKeys("fl");
            Thread.Sleep(speed / 2 * 3);
            keys.SendKeys("h'");
            Thread.Sleep(speed / 2);
            keys.SendKeys(".ah");
            Thread.Sleep(speed);
            keys.SendKeys("g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("f,");
            Thread.Sleep(speed / 2);
            keys.SendKeys("g;");
            Thread.Sleep(speed / 2 * 3);
            keys.SendKeys("dk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("g;");
            Thread.Sleep(speed);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("dk");
            Thread.Sleep(speed / 4);
            keys.SendKeys("yj");
            Thread.Sleep(speed / 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 2);
            keys.SendKeys("y");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("jl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("y");
            Thread.Sleep(speed / 2);
            keys.SendKeys("k;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("y");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dh");
            Thread.Sleep(speed);
            keys.SendKeys("dh");
            Thread.Sleep(speed*2);

            //Darth Vadar
            speed = 600;
            keys.SendKeys("gl.g");
            Thread.Sleep(speed);
            keys.SendKeys(",gl.g");
            Thread.Sleep(speed);
            keys.SendKeys(",gl.g,");
            Thread.Sleep(speed);
            keys.SendKeys("eup");
            Thread.Sleep(speed / 8 * 7);
            keys.SendKeys(".u");
            Thread.Sleep(speed / 8);
            keys.SendKeys(",gl.g,");
            Thread.Sleep(speed);
            keys.SendKeys("eup");
            Thread.Sleep(speed / 8 * 7);
            keys.SendKeys(".u");
            Thread.Sleep(speed / 8);
            keys.SendKeys(",gl.g,");
            Thread.Sleep(speed);

            speed = 600;
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys(";");
            Thread.Sleep(speed / 4);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed / 4);
            keys.SendKeys("dhk;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dhk;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("gk");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed);

            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys(";");
            Thread.Sleep(speed / 4);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed / 4);
            keys.SendKeys("dhk;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dhk;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed);

            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".sg");
            Thread.Sleep(speed / 2);
            keys.SendKeys("g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sg");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("sgu");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sgu");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sh");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("sh");
            Thread.Sleep(speed / 4);
            keys.SendKeys("sh");
            Thread.Sleep(speed / 4);
            keys.SendKeys("s");
            Thread.Sleep(speed);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys("d,");
            Thread.Sleep(speed / 4);
            keys.SendKeys("ul'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ul'");
            Thread.Sleep(speed / 2);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sh");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",hl");
            Thread.Sleep(speed);

            keys.SendKeys("hl");
            Thread.Sleep(speed / 8);
            keys.SendKeys("hl");
            Thread.Sleep(speed / 8);
            keys.SendKeys("'");
            Thread.Sleep(speed / 4);
            keys.SendKeys("go;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("go;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("do");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dho;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl'");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sfh");
            Thread.Sleep(speed / 2 * 3);
            keys.SendKeys(",h'");
            Thread.Sleep(speed / 6);
            keys.SendKeys("hl");
            Thread.Sleep(speed / 6);
            keys.SendKeys("h");
            Thread.Sleep(speed * 2);

            keys.SendKeys(".sfu");
            Thread.Sleep(speed / 2 * 3);
            keys.SendKeys("f");
            Thread.Sleep(speed / 6);
            keys.SendKeys("s");
            Thread.Sleep(speed / 6);
            keys.SendKeys(",u");
            Thread.Sleep(speed);

            keys.SendKeys("hl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dho;");
            Thread.Sleep(speed);

            keys.SendKeys(".g");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",u.sfu");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed);

            keys.SendKeys(",g.adg");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",g.adg");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",g.adg");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",g.adg");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed);

            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",u.sfu");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed);

            keys.SendKeys(",h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("l");
            Thread.Sleep(speed / 4);
            keys.SendKeys("'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",gu.sg");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dh;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sfhl");
            Thread.Sleep(speed * 2);
        }

        [Test]
        public void darthVadarMusicTest()
        {
            driver.Navigate().GoToUrl("http://mrcoles.com/piano/");
            IWebElement keys = driver.FindElement(By.ClassName("keys"));
            int speed = 600;
            //Darth Vadar
            speed = 600;
            keys.SendKeys("gl.g");
            Thread.Sleep(speed);
            keys.SendKeys(",gl.g");
            Thread.Sleep(speed);
            keys.SendKeys(",gl.g,");
            Thread.Sleep(speed);
            keys.SendKeys("eup");
            Thread.Sleep(speed / 8 * 7);
            keys.SendKeys(".u");
            Thread.Sleep(speed / 8);
            keys.SendKeys(",gl.g,");
            Thread.Sleep(speed);
            keys.SendKeys("eup");
            Thread.Sleep(speed / 8 * 7);
            keys.SendKeys(".u");
            Thread.Sleep(speed / 8);
            keys.SendKeys(",gl.g,");
            Thread.Sleep(speed);
        }

        [Test]
        public void starwarsMusicTest()
        {
            driver.Navigate().GoToUrl("http://mrcoles.com/piano/");
            IWebElement keys = driver.FindElement(By.ClassName("keys"));

            //Star Wars main theme
            int speed = 600;
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("g");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed * 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 3);
            keys.SendKeys("g");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed * 2);
            keys.SendKeys("l");
            Thread.Sleep(speed);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed * 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4 * 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4 * 6);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 8);
            keys.SendKeys("j");
            Thread.Sleep(speed / 8);
            keys.SendKeys("h");
            Thread.Sleep(speed / 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("t");
            Thread.Sleep(speed / 2);
            keys.SendKeys("s");
            Thread.Sleep(speed * 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4 * 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4 * 6);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fl");
            Thread.Sleep(speed / 8 * 7);
            keys.SendKeys("th");
            Thread.Sleep(speed / 8);
            keys.SendKeys("th");
            Thread.Sleep(speed * 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4 * 3);
            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4 * 6);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("j");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("h");
            Thread.Sleep(speed / 8);
            keys.SendKeys("j");
            Thread.Sleep(speed / 8);
            keys.SendKeys("h");
            Thread.Sleep(speed / 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 4);
            keys.SendKeys("t");
            Thread.Sleep(speed / 2);
            keys.SendKeys("s");
            Thread.Sleep(speed / 2);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("f");
            Thread.Sleep(speed / 4);
            keys.SendKeys("e,");
            Thread.Sleep(speed / 2);
            keys.SendKeys("l");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 2);
            keys.SendKeys("u");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 2);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("l");
            Thread.Sleep(speed * 2);
        }

        [Test]
        public void tetrisMusicTest()
        {
            driver.Navigate().GoToUrl("http://mrcoles.com/piano/");
            IWebElement keys = driver.FindElement(By.ClassName("keys"));
            int speed = 600;
            //Teris
            speed = 400;
            keys.SendKeys("j;");
            Thread.Sleep(speed);
            keys.SendKeys("yj");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("jl");
            Thread.Sleep(speed / 2);
            keys.SendKeys(";");
            Thread.Sleep(speed / 4);
            keys.SendKeys("l");
            Thread.Sleep(speed / 4);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("yj");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dh");
            Thread.Sleep(speed);
            keys.SendKeys("dh");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("k;");
            Thread.Sleep(speed);
            keys.SendKeys("jl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("yj");
            Thread.Sleep(speed / 3 * 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 3 * 2);
            keys.SendKeys("j");
            Thread.Sleep(speed / 3 * 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("jl");
            Thread.Sleep(speed);
            keys.SendKeys("k;");
            Thread.Sleep(speed);
            keys.SendKeys("hk");
            Thread.Sleep(speed);
            keys.SendKeys("dh");
            Thread.Sleep(speed);
            keys.SendKeys("dh");
            Thread.Sleep(speed * 2);

            keys.SendKeys("fl");
            Thread.Sleep(speed / 2 * 3);
            keys.SendKeys("h'");
            Thread.Sleep(speed / 2);
            keys.SendKeys(".ah");
            Thread.Sleep(speed);
            keys.SendKeys("g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("f,");
            Thread.Sleep(speed / 2);
            keys.SendKeys("g;");
            Thread.Sleep(speed / 2 * 3);
            keys.SendKeys("dk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("g;");
            Thread.Sleep(speed);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("dk");
            Thread.Sleep(speed / 4);
            keys.SendKeys("yj");
            Thread.Sleep(speed / 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 2);
            keys.SendKeys("y");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("jl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("y");
            Thread.Sleep(speed / 2);
            keys.SendKeys("k;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("y");
            Thread.Sleep(speed / 2);
            keys.SendKeys("hk");
            Thread.Sleep(speed / 2);
            keys.SendKeys("d");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dh");
            Thread.Sleep(speed);
            keys.SendKeys("dh");
            Thread.Sleep(speed * 2);
        }

        [Test]
        public void pirateMusicTest()
        {
            driver.Navigate().GoToUrl("http://mrcoles.com/piano/");
            IWebElement keys = driver.FindElement(By.ClassName("keys"));
            int speed = 600;
            //He's a pirate
            speed = 600;
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys(";");
            Thread.Sleep(speed / 4);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed / 4);
            keys.SendKeys("dhk;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dhk;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("gk");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed);

            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys(";");
            Thread.Sleep(speed / 4);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ful'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g,");
            Thread.Sleep(speed / 4);
            keys.SendKeys("dhk;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dhk;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed);

            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("k");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".sg");
            Thread.Sleep(speed / 2);
            keys.SendKeys("g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sg");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("sgu");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sgu");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sh");
            Thread.Sleep(speed / 4);
            keys.SendKeys("g");
            Thread.Sleep(speed / 4);
            keys.SendKeys("sh");
            Thread.Sleep(speed / 4);
            keys.SendKeys("sh");
            Thread.Sleep(speed / 4);
            keys.SendKeys("s");
            Thread.Sleep(speed);

            keys.SendKeys("s");
            Thread.Sleep(speed / 4);
            keys.SendKeys("d,");
            Thread.Sleep(speed / 4);
            keys.SendKeys("ul'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("ul'");
            Thread.Sleep(speed / 2);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sh");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",hl");
            Thread.Sleep(speed);

            keys.SendKeys("hl");
            Thread.Sleep(speed / 8);
            keys.SendKeys("hl");
            Thread.Sleep(speed / 8);
            keys.SendKeys("'");
            Thread.Sleep(speed / 4);
            keys.SendKeys("go;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("go;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("do");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dho;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("fhl'");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sfh");
            Thread.Sleep(speed / 2 * 3);
            keys.SendKeys(",h'");
            Thread.Sleep(speed / 6);
            keys.SendKeys("hl");
            Thread.Sleep(speed / 6);
            keys.SendKeys("h");
            Thread.Sleep(speed * 2);

            keys.SendKeys(".sfu");
            Thread.Sleep(speed / 2 * 3);
            keys.SendKeys("f");
            Thread.Sleep(speed / 6);
            keys.SendKeys("s");
            Thread.Sleep(speed / 6);
            keys.SendKeys(",u");
            Thread.Sleep(speed);

            keys.SendKeys("hl");
            Thread.Sleep(speed / 4);
            keys.SendKeys("h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("fhl");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dho;");
            Thread.Sleep(speed);

            keys.SendKeys(".g");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",u.sfu");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed);

            keys.SendKeys(",g.adg");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",g.adg");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",g.adg");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",g.adg");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed);

            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",u.sfu");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",h.sfh");
            Thread.Sleep(speed);

            keys.SendKeys(",h");
            Thread.Sleep(speed / 4);
            keys.SendKeys("l");
            Thread.Sleep(speed / 4);
            keys.SendKeys("'");
            Thread.Sleep(speed / 4);
            keys.SendKeys(".g");
            Thread.Sleep(speed / 4);
            keys.SendKeys(",gu.sg");
            Thread.Sleep(speed / 2);
            keys.SendKeys(",ful'");
            Thread.Sleep(speed / 2);
            keys.SendKeys("dh;");
            Thread.Sleep(speed / 2);
            keys.SendKeys("sfhl");
            Thread.Sleep(speed * 2);
        }
    }
}

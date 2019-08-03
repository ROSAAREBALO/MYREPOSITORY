using System;

namespace MyFirtSolution
{

    [TestClass]
        //1 reference
    public class Class1
    {
        //framework base: c#
        // ui framework:selenium webdriver      
        //init framework: MSTest
        //necesitamos un objeto

        //  Webdriver con ctrl+.  usamos para complementar poner un nonvbre  webdriver

       IWebDriver webDriver;
        public Class1()
        {
            webDriver = new ChromeDriver(@"C:\selenumWebDriver");
        }
         
        //crear un metodo que te devuelva lago
        [TestMethod]
      //  0 references
        public void MyFirstSolution() {

            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");

        }


    }
}

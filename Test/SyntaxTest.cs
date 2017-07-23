using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Navigation;
namespace Test
{
    [TestClass]
    public class SyntaxTest
    {
        [TestMethod]
        public void Should_Find_Blue(){
            var testString =  new SyntaxHighlighter("as:blue:capital if:blue:lower").Process("as if twice");
            Console.WriteLine(testString);
            Assert.AreEqual(testString, "[blue]AS[blue] [blue]if[blue] twice");
        }

    }

}
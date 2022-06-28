using System;
using System.Collections.Generic;
using NUnit.Framework;
using work;


namespace TestProject1
{
    
    
    
    [TestFixture]
    public class Tests
    {
        public List<Shape> list = new List<Shape>();
        
        [Test]
        public void Test1()
        {
            list.Add(new circle(5));
            list.Add(new triangle(5,4,3));
            list.Add(new triangle(115,0.00001f,9));
            
            Assert.AreEqual(Math.PI* 25,list[0].calcS());
            Assert.AreEqual(6,list[1].calcS());
            Assert.AreEqual(true,(list[1] as triangle).check90());
            Assert.AreNotEqual(true, (list[2] as triangle).check90());
            Assert.AreEqual("circle",list[0].type);
            Assert.AreEqual("triangle",list[1].type);
        }
    }
}
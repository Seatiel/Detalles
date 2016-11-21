using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class EstudiantesBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Estudiantes est = new Estudiantes(); 
            Assert.IsTrue(EstudiantesBLL.Insertar(est));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsTrue(EstudiantesBLL.GetList().Count > 0);
        }

        [TestMethod()]
        public void GetListTest1()
        {
            Assert.Fail();
        }
    }
}
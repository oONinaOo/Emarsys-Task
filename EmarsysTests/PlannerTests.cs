using Microsoft.VisualStudio.TestTools.UnitTesting;
using Emarsys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emarsys.Tests
{
    [TestClass()]
    public class PlannerTests
    {
        [TestMethod()]
        public void Test1()
        {
            Planner planner = new Planner();
            planner.addDestination(new Destination(" "), new Destination("x"));
            CollectionAssert.AreEqual(planner.getList(), new List<Destination> {new Destination( "x") });
        }

        [TestMethod()]
        public void Test2()
        {
            Planner planner = new Planner();
            planner.addDestination(new Destination(" "), new Destination("x"));
            planner.addDestination(new Destination(" "), new Destination("y"));
            planner.addDestination(new Destination(" "), new Destination("z"));
            CollectionAssert.AreEqual(planner.getList(), new List<Destination> { new Destination("x"), new Destination("y"), new Destination("z") });
        }

        [TestMethod()]
        public void Test3()
        {
            Planner planner = new Planner();
            planner.addDestination(new Destination(" "), new Destination("x"));
            planner.addDestination(new Destination("z"), new Destination("y"));
            planner.addDestination(new Destination(" "), new Destination("z"));
            CollectionAssert.AreEqual(planner.getList(), new List<Destination> { new Destination("x"), new Destination("z"), new Destination("y") });
        }

        [TestMethod()]
        public void Test4()
        {
            Planner planner = new Planner();
            planner.addDestination(new Destination(" "), new Destination("z"));
            planner.addDestination(new Destination("w"), new Destination("v"));
            planner.addDestination(new Destination("v"), new Destination("y"));
            planner.addDestination(new Destination("z"), new Destination("w"));
            planner.addDestination(new Destination(" "), new Destination("u"));
            planner.addDestination(new Destination("u"), new Destination("x"));


            CollectionAssert.AreEqual(planner.getList(), new List<Destination> { new Destination("z"), new Destination("w"), new Destination("v"), new Destination("y"), new Destination("u"), new Destination("x") });
        }
    }
}
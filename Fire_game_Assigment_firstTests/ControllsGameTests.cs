using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fire_game_Assigment_first;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_game_Assigment_first.Tests
{
    [TestClass()]
    public class ControllsGameTests
    {
        Form1 frm = new Form1();
        public void shootTest()
        {

            ControllsGame controlls = new ControllsGame();
            int y = controlls.shoot(1);
            if (y == 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }
        public void shootAwayTest()
        {

            ControllsGame controlls = new ControllsGame();
            int y = controlls.shootAway(2);
            if (y == 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}
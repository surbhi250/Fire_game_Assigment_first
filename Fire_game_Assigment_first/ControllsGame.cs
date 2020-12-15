using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_game_Assigment_first
{
   public class ControllsGame
    {

        Random rd = new Random();
        int trigger = 0;
        int triggerN = 0;
        public int fire() {
            trigger = rd.Next(1, 6);
            triggerN= rd.Next(1, 4);
            return trigger;
        }
        
        //start the button to 
        public int startGame(Button btnStart) {
            fire();
            btnStart.Enabled = false;
            return 1;
        }
        //load the gun with bullet 
        public int loadGun(Button btnLoad) {
            btnLoad.Enabled = false;
            return 1;
        }

        //load the gun with bullet 
        public int SpinGun(Button btnSpin)
        {
            btnSpin.Enabled = false;
            return 1;
        }


        public int shoot(int chance) {
            if (chance==trigger)
            {
                MessageBox.Show("You are dead Now ");
                return 1;
            }
            return 0;
        }
        public int shootAway(int chance)
        {
            if (chance == triggerN)
            {
                MessageBox.Show("You are dead Now ");
                return 1;
            }
            return 0;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_game_Assigment_first
{
    public partial class Form1 : Form
    {
        ControllsGame Controlls = new ControllsGame();
        int fire = 0,fireN=0;
        public Form1()
        {
            InitializeComponent();
            LoadGun.Enabled = false;
            Sppinroller.Enabled = false;
            shootGun.Enabled = false;
            ShootAway.Enabled = false;
            Retry.Enabled = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Controlls.startGame(StartButton) == 1)
            {
                //this code is used when we click on the start button to proceeed
                //load the gun for the game 
                pbGun.Image = Fire_game_Assigment_first.Properties.Resources.shoot4;
                LoadGun.Enabled = true;
            }
            else {
                MessageBox.Show("Please Click on Start to play ");
            }
        }

        private void LoadGun_Click(object sender, EventArgs e)
        {
            if (Controlls.loadGun(LoadGun) == 1)
            {
                //this code is used when we click on the start button to proceeed
                //load the gun for the game 
                pbGun.Image = Fire_game_Assigment_first.Properties.Resources.shoot2;
                Sppinroller.Enabled = true;
                MessageBox.Show("Gun is Loaded with bullet ");
            }
            else
            {
                MessageBox.Show("Please Click on Load Gun to play ");
            }
        }

        private void Sppinroller_Click(object sender, EventArgs e)
        {
            if (Controlls.SpinGun(Sppinroller) == 1)
            {
                //this code is used when we click on the start button to proceeed
                //load the gun for the game 
                pbGun.Image = Fire_game_Assigment_first.Properties.Resources.shoot4;
                Sppinroller.Enabled = false;
                shootGun.Enabled = true;
                ShootAway.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Click on Spinner to play ");
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            //when we want to close the app
            Application.Exit();
        }

        private void Retry_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;

        }
        // shoot gun button for creating sound and click
        private void shootGun_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Fire_game_Assigment_first.Properties.Resources.fireSound);
            obj.Play();


            if (fire <= 4)
            {
                fire++;
                if (Controlls.shoot(fire) == 1)
                {
                    ShootAway.Enabled = false;
                    shootGun.Enabled = false;
                    Retry.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You are save ! ");

                }
            }
            else {
                MessageBox.Show("you are survive");
                ShootAway.Enabled = false;
                shootGun.Enabled = false;
                Retry.Enabled = true;
            }
        }

        private void ShootAway_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Fire_game_Assigment_first.Properties.Resources.fireSound);
            obj.Play();

            if (fireN <= 2)
            {
                fireN++;
                if (Controlls.shootAway(fireN) == 1)
                {
                    ShootAway.Enabled = false;
                    shootGun.Enabled = false;
                    Retry.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You are save ! ");

                }
            }
            else
            {
                MessageBox.Show("you are survive");
                ShootAway.Enabled = false;
                shootGun.Enabled = false;
                Retry.Enabled = true;
            }
        }
    }
}

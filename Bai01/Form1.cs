using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Bai01
{
    public partial class Form1 : Form
    {
        
        private int option = 0;
        public static string category = "";
        public static bool soundon = true;
        public static AxWindowsMediaPlayer wmp = new AxWindowsMediaPlayer();
        public Form1()
        {
            
            InitializeComponent();
            this.CenterToScreen();
            
            var pos = this.PointToScreen(pictureBox_logo.Location);
            pos = pictureBox_begin.PointToClient(pos);
            pictureBox_logo.Parent = pictureBox_begin;
            pictureBox_logo.Location = pos;
            pictureBox_logo.BackColor = Color.Transparent;
            this.label_fruit.BackColor = System.Drawing.Color.Transparent;
            this.label_animal.BackColor = System.Drawing.Color.Transparent;
            this.label_place.BackColor = System.Drawing.Color.Transparent;
            this.label_vetgetable.BackColor = System.Drawing.Color.Transparent;
            this.label_transport.BackColor = System.Drawing.Color.Transparent;
            this.label_fruit.Hide();
            this.label_animal.Hide();
            this.label_place.Hide();
            this.label_transport.Hide();
            this.label_vetgetable.Hide();
            this.pictureBox_transport.Hide();
            this.pictureBox_vegetable.Hide();
            this.pictureBox_job.Hide();
            this.pictureBox_animal.Hide();
            this.pictureBox_fruit.Hide();
            this.pictureBox_back.Hide();
            wmp.CreateControl();
            //wmp.SkinAllThreads();
            wmp.URL = "backgroundmusic.mp3";
            //this.wmp.EditMode.
            wmp.Hide();
            wmp.Ctlcontrols.play();
            wmp.settings.setMode("loop", true);
        }

        private void choose()
        {
            pictureBox_speaker.Hide();
            pictureBox4.Show();
            pictureBox4.Size = this.Size;
            pictureBox4.Image = Addition.vent;
            pictureBox3.Hide();
            button_learn.Hide();
            button_test.Hide();
            button_history.Hide();
            this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_susleft.Hide();
            pictureBox_susright.Hide();
            Task.Run(() =>
            {
                Thread.Sleep(3500);
                this.Invoke(new Action(() =>
                {
                    pictureBox4.Hide();
                    this.BackgroundImage = Addition.map;

                    this.label_fruit.Show();
                    this.label_animal.Show();
                    this.label_place.Show();
                    this.label_transport.Show();
                    this.label_vetgetable.Show();
                    this.pictureBox_transport.Show();
                    this.pictureBox_vegetable.Show();
                    this.pictureBox_job.Show();
                    this.pictureBox_animal.Show();
                    this.pictureBox_fruit.Show();
                    this.pictureBox_back.Show();
                    pictureBox_speaker.Show();
                }));
            });
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            choose();
            option = 1;
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            this.label_fruit.Hide();
            this.label_animal.Hide();
            this.label_place.Hide();
            this.label_transport.Hide();
            this.label_vetgetable.Hide();
            this.pictureBox_transport.Hide();
            this.pictureBox_vegetable.Hide();
            this.pictureBox_job.Hide();
            this.pictureBox_animal.Hide();
            this.pictureBox_fruit.Hide();
            this.pictureBox_back.Hide();
            pictureBox3.Show();
            button_learn.Show();
            button_test.Show();
            button_history.Show();
            this.BackgroundImage = Addition.pinkbackground;
            pictureBox_susleft.Show();
            pictureBox_susright.Show();
        }
        private void chooseform()
        {
            if (option == 1)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else if (option == 0)
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
            else
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            if (soundon)
            {
                pictureBox_speaker.BackgroundImage = Addition.speaker;
            }
            else
            {
                pictureBox_speaker.BackgroundImage = Addition.mute;
            }
            //wmp.Ctlcontrols.play();
        }
        private void pictureBox_animal_Click(object sender, EventArgs e)
        {
            category = "animal";
            chooseform();
            
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            choose();
            option = 2;
        }

        private void button_learn_Click(object sender, EventArgs e)
        {
            choose();
            option = 0;
        }

        private void pictureBox_fruit_Click(object sender, EventArgs e)
        {
            category = "fruit";
            chooseform();
        }


        private void pictureBox_job_Click(object sender, EventArgs e)
        {
            category = "job";
            chooseform();
        }

        private void pictureBox_transport_Click(object sender, EventArgs e)
        {
            category = "transport";
            chooseform();
        }

        private void pictureBox_vegetable_Click(object sender, EventArgs e)
        {
            category = "vegetable";
            chooseform();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(soundon)
            {
                wmp.Ctlcontrols.stop();
                
                pictureBox_speaker.BackgroundImage = Addition.mute;
            }
            else
            {
                wmp.Ctlcontrols.play();
                pictureBox_speaker.BackgroundImage = Addition.speaker;
            }    
            soundon = !soundon;
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox_begin.Hide();
            pictureBox_logo.Hide();
            button1.Hide();
            button1.Enabled = false;
        }
    }
}

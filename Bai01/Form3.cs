using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen();
            var pos = this.PointToScreen(pictureBox_cate1.Location);
            pos = pictureBox5.PointToClient(pos);
            pictureBox_cate1.Parent = pictureBox5;
            pictureBox_cate1.Location = pos;
            pictureBox_cate1.BackColor = Color.Transparent;
            //pictureBox_anminal.Hide();

            pos = this.PointToScreen(label_cate.Location);
            pos = pictureBox5.PointToClient(pos);
            label_cate.Parent = pictureBox5;
            label_cate.Location = pos;
            label_cate.BackColor = Color.Transparent;

            pos = this.PointToScreen(label_1st.Location);
            pos = pictureBox5.PointToClient(pos);
            label_1st.Parent = pictureBox5;
            label_1st.Location = pos;
            label_1st.BackColor = Color.Transparent;

            pos = this.PointToScreen(label_2nd.Location);
            pos = pictureBox5.PointToClient(pos);
            label_2nd.Parent = pictureBox5;
            label_2nd.Location = pos;
            label_2nd.BackColor = Color.Transparent;

            pos = this.PointToScreen(label_3rd.Location);
            pos = pictureBox5.PointToClient(pos);
            label_3rd.Parent = pictureBox5;
            label_3rd.Location = pos;
            label_3rd.BackColor = Color.Transparent;

            pos = this.PointToScreen(label_1s.Location);
            pos = pictureBox5.PointToClient(pos);
            label_1s.Parent = pictureBox5;
            label_1s.Location = pos;
            label_1s.BackColor = Color.Transparent;

            pos = this.PointToScreen(label_2s.Location);
            pos = pictureBox5.PointToClient(pos);
            label_2s.Parent = pictureBox5;
            label_2s.Location = pos;
            label_2s.BackColor = Color.Transparent;

            pos = this.PointToScreen(label_3s.Location);
            pos = pictureBox5.PointToClient(pos);
            label_3s.Parent = pictureBox5;
            label_3s.Location = pos;
            label_3s.BackColor = Color.Transparent;

            pos = this.PointToScreen(pictureBox_1st.Location);
            pos = pictureBox5.PointToClient(pos);
            pictureBox_1st.Parent = pictureBox5;
            pictureBox_1st.Location = pos;
            pictureBox_1st.BackColor = Color.Transparent;

            pos = this.PointToScreen(pictureBox_2nd.Location);
            pos = pictureBox5.PointToClient(pos);
            pictureBox_2nd.Parent = pictureBox5;
            pictureBox_2nd.Location = pos;
            pictureBox_2nd.BackColor = Color.Transparent;

            pos = this.PointToScreen(pictureBox_3rd.Location);
            pos = pictureBox5.PointToClient(pos);
            pictureBox_3rd.Parent = pictureBox5;
            pictureBox_3rd.Location = pos;
            pictureBox_3rd.BackColor = Color.Transparent;

            pos = this.PointToScreen(pictureBox_sus1.Location);
            pos = pictureBox5.PointToClient(pos);
            pictureBox_sus1.Parent = pictureBox5;
            pictureBox_sus1.Location = pos;
            pictureBox_sus1.BackColor = Color.Transparent;

            pos = this.PointToScreen(pictureBox_sus2.Location);
            pos = pictureBox5.PointToClient(pos);
            pictureBox_sus2.Parent = pictureBox5;
            pictureBox_sus2.Location = pos;
            pictureBox_sus2.BackColor = Color.Transparent;

            pos = this.PointToScreen(pictureBox_sus3.Location);
            pos = pictureBox5.PointToClient(pos);
            pictureBox_sus3.Parent = pictureBox5;
            pictureBox_sus3.Location = pos;
            pictureBox_sus3.BackColor = Color.Transparent;

            pos = this.PointToScreen(pictureBox_buc.Location);
            pos = pictureBox5.PointToClient(pos);
            pictureBox_buc.Parent = pictureBox5;
            pictureBox_buc.Location = pos;
            pictureBox_buc.BackColor = Color.Transparent;

            pos = this.PointToScreen(pictureBox_speaker.Location);
            pos = pictureBox5.PointToClient(pos);
            pictureBox_speaker.Parent = pictureBox5;
            pictureBox_speaker.Location = pos;
            pictureBox_speaker.BackColor = Color.Transparent;
            if (Form1.soundon)
            {
                pictureBox_speaker2.BackgroundImage = Addition.speaker;
                pictureBox_speaker.BackgroundImage = Addition.speaker;
            }
            else
            {
                pictureBox_speaker2.BackgroundImage = Addition.mute;
                pictureBox_speaker.BackgroundImage = Addition.mute;
            }

            switch (Form1.category)
            {
                case "animal":
                    {
                        label_cate.Text = "Animals";
                        pictureBox_cate1.BackgroundImage = Addition.animal;
                        pictureBox_cate2.BackgroundImage = Addition.animal;
                        string s1 = Properties.Settings.Default.animal_first;
                        string s2 = Properties.Settings.Default.animal_second;
                        string s3 = Properties.Settings.Default.animal_third;
                        get_name_score(s1, s2, s3);
                        break;
                    }
                case "fruit":
                    {
                        label_cate.Text = "Fruits";
                        pictureBox_cate1.BackgroundImage = Addition.fruit;
                        pictureBox_cate2.BackgroundImage = Addition.fruit;
                        string s1 = Properties.Settings.Default.fruit_first;
                        string s2 = Properties.Settings.Default.fruit_second;
                        string s3 = Properties.Settings.Default.fruit_third;
                        get_name_score(s1, s2, s3);
                        break;
                    }
                case "vegetable":
                    {
                        label_cate.Text = "Vegetables";
                        pictureBox_cate1.BackgroundImage = Addition.vegetable;
                        pictureBox_cate2.BackgroundImage = Addition.vegetable;
                        string s1 = Properties.Settings.Default.vegetable_first;
                        string s2 = Properties.Settings.Default.vegetable_second;
                        string s3 = Properties.Settings.Default.vegetable_third;
                        get_name_score(s1, s2, s3);
                        break;
                    }
                case "job":
                    {
                        label_cate.Text = "Jobs";
                        pictureBox_cate1.BackgroundImage = Addition.job;
                        pictureBox_cate2.BackgroundImage = Addition.job;
                        string s1 = Properties.Settings.Default.job_first;
                        string s2 = Properties.Settings.Default.job_second;
                        string s3 = Properties.Settings.Default.job_third;
                        get_name_score(s1, s2, s3);
                        break;
                    }
                case "transport":
                    {
                        label_cate.Text = "Transports";
                        pictureBox_cate1.BackgroundImage = Addition.transport;
                        pictureBox_cate2.BackgroundImage = Addition.transport;
                        string s1 = Properties.Settings.Default.transport_first;
                        string s2 = Properties.Settings.Default.transport_second;
                        string s3 = Properties.Settings.Default.transport_third;
                        get_name_score(s1, s2, s3);
                        break;
                    }
                default:
                    break;
            }  
        }

        private void get_name_score(string s1,string s2,string s3)
        {
            if (s1.Length > 1)
            {
                string[] strscore = s1.Split('_');
                int score1 = Convert.ToInt32(strscore[strscore.Length - 1]);
                s1 = strscore[0];
                for (int i = 1; i < strscore.Length - 1; i++)
                    s1 = s1 + "_" + strscore[i];
                label_1st.Text = s1;
                label_1s.Text = strscore[strscore.Length - 1];
                if (s2.Length > 1)
                {
                    string[] strscore2 = s2.Split('_');
                    int score2 = Convert.ToInt32(strscore2[strscore2.Length - 1]);
                    s2 = strscore2[0];
                    for (int i = 1; i < strscore2.Length - 1; i++)
                        s2 = s2 + "_" + strscore2[i];
                    label_2nd.Text = s2;
                    label_2s.Text = strscore2[strscore2.Length - 1];
                    if (s3.Length > 1)
                    {
                        string[] strscore3 = s3.Split('_');
                        int score3 = Convert.ToInt32(strscore3[strscore3.Length - 1]);
                        s3 = strscore3[0];
                        for (int i = 1; i < strscore3.Length - 1; i++)
                            s3 = s3 + "_" + strscore3[i];
                        label_3rd.Text = s3;
                        label_3s.Text = strscore3[strscore3.Length - 1];
                    }
                    else
                    {

                        pictureBox_3rd.Hide();
                        label_3s.Hide();
                        label_3rd.Hide();
                    }
                }
                else
                {

                    pictureBox_2nd.Hide();
                    pictureBox_3rd.Hide();
                    label_2s.Hide();
                    label_2nd.Hide();
                    label_3s.Hide();
                    label_3rd.Hide();
                }
            }
            else
            {
                pictureBox_1st.Hide();
                pictureBox_2nd.Hide();
                pictureBox_3rd.Hide();
                label_1s.Hide();
                label_1st.Hide();
                label_2s.Hide();
                label_2nd.Hide();
                label_3s.Hide();
                label_3rd.Hide();
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_speaker1_Click(object sender, EventArgs e)
        {
            if (Form1.soundon)
            {
                Form1.wmp.Ctlcontrols.stop();
                pictureBox_speaker2.BackgroundImage = Addition.mute;
                pictureBox_speaker.BackgroundImage = Addition.mute;
            }
            else
            {
                Form1.wmp.Ctlcontrols.play();
                pictureBox_speaker.BackgroundImage = Addition.speaker;
                pictureBox_speaker2.BackgroundImage = Addition.speaker;
            }
            Form1.soundon = !Form1.soundon;
        }
    }
}

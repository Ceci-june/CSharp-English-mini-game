using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai01
{
    public partial class Form2 : Form
    {
        public Bitmap[] images;
        public Random r = new Random();
        public string answer;
        public string[] name;
        public int count;
        public string category;
        public bool x;
        //public bool istrue = true;
        public int score = 0;
        public string acc;
        public Label labelX = new Label();
        
        // public PictureBox pictureBox_incorrect;
        public Form2(string s)
        {
            category = s;
            InitializeComponent();
            GetResourceImages();
            this.CenterToScreen();
            pictureBox2.Hide();
            label2.BackColor = Color.FromArgb(236, 232, 33);
            
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox_table.PointToClient(pos);
            label1.Parent = pictureBox_table;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;

            pos = this.PointToScreen(pictureBox_incorrecttext.Location);
            pos = pictureBox2.PointToClient(pos);
            pictureBox_incorrecttext.Parent = pictureBox2;
            pictureBox_incorrecttext.Location = pos;
            pictureBox_incorrecttext.BackColor = Color.Transparent;
            pictureBox_incorrecttext.Hide();
            pos = this.PointToScreen(pictureBox_correcttext.Location);
            pos = pictureBox2.PointToClient(pos);
            pictureBox_correcttext.Parent = pictureBox2;
            pictureBox_correcttext.Location = pos;
            pictureBox_correcttext.BackColor = Color.Transparent;
            pictureBox_correcttext.Hide();
            pos = this.PointToScreen(label3.Location);
            pos = pictureBox2.PointToClient(pos);
            label3.Parent = pictureBox2;
            label3.Location = pos;
            label3.BackColor = Color.Transparent;
            label3.Hide();
            textBox1.Enabled = false;
            label_nameend.Hide();
            label_scoreend.Hide();
            
        }
        private void GetResourceImages()
        {
            PropertyInfo[] props = { };
            switch (category)
            {
                case "animal":
                    props = typeof(Animal).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                case "fruit":
                    props = typeof(Fruit).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                case "vegetable":
                    props = typeof(Vegetable).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                case "transport":
                    props = typeof(Transport).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                case "job":
                    props = typeof(Job).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                default:
                    break;
            }

            images = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.GetValue(null, null) as Bitmap).ToArray();
            name = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.Name as string).ToArray();
        }
        private void RandomizePicture()
        {

            x = true;
            if (images == null || images.Length == 0)
            {
                GetResourceImages();
            }

            int maxValue = images.Length;
            int idx = r.Next(maxValue);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Image = images[idx];

            answer = name[idx];
            images = images.Where(val => val != images[idx]).ToArray();
            name = name.Where(val => val != name[idx]).ToArray();
            count++;
            this.label1.Text = "Question: " + count.ToString();
            label2.Text = score.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                
                this.pictureBox2.Enabled = true;
                pictureBox4.Hide();
                pictureBox5.Hide();
                label3.Show();
                label3.Text = "";
                this.textBox1.Hide();
                this.pictureBox1.Hide();
                pictureBox2.Image = Addition.space;
                pictureBox2.Show();
                this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                this.label2.Hide();
                this.pictureBox3.Hide();
                this.label1.Hide();
                this.pictureBox_table.Hide();
                //if (answer.ToLower().Trim() == this.textBox1.Text.ToLower().Replace('_', ' ').Trim())

                if (answer.ToLower() == this.textBox1.Text.ToLower().Replace('_',' '))
                {
                    pictureBox_correcttext.Show();
                    string s = answer + " is the correct answer";
                    score++;
                    result_newimage(s);
                }
                else
                {
                    pictureBox_incorrecttext.Show();
                    string s = "the correct answer is " + answer;
                    result_newimage(s);
                }
            }
        }
        private void result_newimage(string s)
        {
            Task.Run(() =>
            {
                Thread.Sleep(900);
                for (int i = 1; i <= s.Length; i++)
                {
                    Thread.Sleep(100);
                    this.Invoke(new Action(() =>
                    {
                        label3.Text = s.Substring(0, i);
                    }));
                }
                Thread.Sleep(1000);
                
                this.Invoke(new Action(() =>
                {
                this.textBox1.Text = "";
                   
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox_incorrecttext.Hide();
                pictureBox_correcttext.Hide();
                pictureBox2.Hide();
                this.textBox1.Show();
                this.pictureBox1.Show();
                this.label2.Show();
                this.pictureBox3.Show();
                this.label1.Show();
                this.pictureBox_table.Show();
                    if (count < 10)
                    {
                        RandomizePicture();
                    }
                    else
                    {
                        switch (category)
                        {
                            case "animal":
                                {
                                    string s1 = Properties.Settings.Default.animal_first;
                                    string s2 = Properties.Settings.Default.animal_second;
                                    string s3 = Properties.Settings.Default.animal_third;
                                    rerank(ref s1, ref s2, ref s3);
                                    Properties.Settings.Default.animal_first = s1;
                                    Properties.Settings.Default.animal_second = s2;
                                    Properties.Settings.Default.animal_third = s3;
                                    break;
                                }
                            case "vegetable":
                                {
                                    string s1 = Properties.Settings.Default.vegetable_first;
                                    string s2 = Properties.Settings.Default.vegetable_second;
                                    string s3 = Properties.Settings.Default.vegetable_third;
                                    rerank(ref s1, ref s2, ref s3);
                                    Properties.Settings.Default.vegetable_first = s1;
                                    Properties.Settings.Default.vegetable_second = s2;
                                    Properties.Settings.Default.vegetable_third = s3;
                                    break;
                                }
                            case "fruit":
                                {
                                    string s1 = Properties.Settings.Default.fruit_first;
                                    string s2 = Properties.Settings.Default.fruit_second;
                                    string s3 = Properties.Settings.Default.fruit_third;
                                    rerank(ref s1, ref s2, ref s3);
                                    Properties.Settings.Default.fruit_first = s1;
                                    Properties.Settings.Default.fruit_second = s2;
                                    Properties.Settings.Default.fruit_third = s3;
                                    break;
                                }
                            case "transport":
                                {
                                    string s1 = Properties.Settings.Default.transport_first;
                                    string s2 = Properties.Settings.Default.transport_second;
                                    string s3 = Properties.Settings.Default.transport_third;
                                    rerank(ref s1, ref s2, ref s3);
                                    Properties.Settings.Default.transport_first = s1;
                                    Properties.Settings.Default.transport_second = s2;
                                    Properties.Settings.Default.transport_third = s3;
                                    break;
                                }
                            case "job":
                                {
                                    string s1 = Properties.Settings.Default.job_first;
                                    string s2 = Properties.Settings.Default.job_second;
                                    string s3 = Properties.Settings.Default.job_third;
                                    rerank(ref s1, ref s2, ref s3);
                                    Properties.Settings.Default.job_first = s1;
                                    Properties.Settings.Default.job_second = s2;
                                    Properties.Settings.Default.job_third = s3;
                                    break;
                                }
                            default:
                                break;
                        }

                        this.pictureBox_name.Image = Addition.name;
                        this.pictureBox_name.Show();
                        this.pictureBox_name.SizeMode = PictureBoxSizeMode.StretchImage;
                        Properties.Settings.Default.Save();


                        var pos = this.PointToScreen(label_nameend.Location);
                        pos = pictureBox_name.PointToClient(pos);
                        label_nameend.Parent = pictureBox_name;
                        label_nameend.Location = pos;
                        label_nameend.BackColor = Color.Transparent;

                        pos = this.PointToScreen(label_scoreend.Location);
                        pos = pictureBox_name.PointToClient(pos);
                        label_scoreend.Parent = pictureBox_name;
                        label_scoreend.Location = pos;
                        label_scoreend.BackColor = Color.Transparent;

                        label_scoreend.Text = "Score: " + score.ToString();

                        if (acc == "")
                        {
                            label_nameend.Text = "Player: unnamed player";
                        }
                        else
                        {
                            label_nameend.Text = "Player: " + acc;
                        }
                        pos = this.PointToScreen(pictureBox5.Location);
                        pos = pictureBox_name.PointToClient(pos);
                        pictureBox5.Parent = pictureBox_name;
                        pictureBox5.Location = pos;
                        pictureBox5.BackColor = Color.Transparent;

                        label_scoreend.Show();
                        label_nameend.Show();
                    }
                }));
            });
            //this.pictureBox2.Hide();
            
        }
        private void rerank(ref string s1, ref string s2, ref string s3)
        {
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            if (s1.Length > 1)
            {
                string[] strscore = s1.Split('_');
                score1 = Convert.ToInt32(strscore[strscore.Length - 1]);
            }
            if (s2.Length > 1)
            {
                string[] strscore = s2.Split('_');
                score2 = Convert.ToInt32(strscore[strscore.Length - 1]);
            }
            if (s3.Length > 1)
            {
                string[] strscore = s3.Split('_');
                score3 = Convert.ToInt32(strscore[strscore.Length - 1]);
            }
            if (acc == "")
            {
                acc = "unnamed player";
            }    
                if (score >= score1)
            {
                s3 = s2;
                s2 = s1;
                s1 = acc + "_" + score.ToString();
                

            }
            else if (score >= score2)
            {
                s3 = s2;
                s2 = acc + "_" + score.ToString();
                

            }
            else if (score >= score3)
            {
                s3 = acc + "_" + score.ToString();
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox_namet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                acc = this.richTextBox_namet.Text;
                this.richTextBox_namet.Hide();
                this.pictureBox_name.Hide();
                this.pictureBox_name1.Hide();
                this.pictureBox_name3.Hide();
                this.pictureBox_name2.Hide();
                this.pictureBox_name4.Hide();
                this.label_name.Hide();
                RandomizePicture();
                textBox1.Enabled = true;
            }
        }

        private void pictureBox_name_Click(object sender, EventArgs e)
        {

        }
    }
}

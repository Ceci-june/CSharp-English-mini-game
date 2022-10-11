using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai01
{
    public partial class Form4 : Form
    {
        public Bitmap[] images;
        public string[] name;
        public Random r = new Random();
        public Bitmap pic;
        public string pic_name;
        public Form4()
        {
            
            InitializeComponent();
            GetResourceImages();
            this.CenterToScreen();
            label_finish.Hide();
            ListViewItem item = new ListViewItem();
            //listView1.SmallImageList = images;
            int maxValue = images.Length;
            ImageList imageList = new ImageList { ImageSize = new Size(200, 200) };

            for (int i = 0; i < maxValue; i++)
            {
                //item. = imanges[i];
                imageList.Images.Add( images[i]);
                this.listView1.Items.Add(name[i].Replace('_', ' '), i);
            }
            
            this.listView1.View = View.LargeIcon;
       
            
            this.listView1.LargeImageList = imageList;
            label_cate.BackColor = Color.Transparent;
            this.pictureBox_card.Hide();
            this.label_card.Hide();
            this.button_good.Hide();
            this.button_replay.Hide();  
            RandomizePicture();
            if (Form1.soundon)
            {
                pictureBox_speaker.BackgroundImage = Addition.speaker;
            }
            else
            {
                pictureBox_speaker.BackgroundImage = Addition.mute;
            }
        }
        private void GetResourceImages()
        {
            PropertyInfo[] props = { };
            switch (Form1.category)
            {
                case "animal":
                    label_cate.Text = "Animals";
                    props = typeof(Animal).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                case "fruit":
                    label_cate.Text = "Fruits";
                    props = typeof(Fruit).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                case "vegetable":
                    label_cate.Text = "Vegetables";
                    props = typeof(Vegetable).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                case "transport":
                    label_cate.Text = "Transports";
                    props = typeof(Transport).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                case "job":
                    label_cate.Text = "Jobs";
                    props = typeof(Job).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
                    break;
                default:
                    break;
            }
            images = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.GetValue(null, null) as Bitmap).ToArray();
            name = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.Name as string).ToArray();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.listView1.Hide();
            if (images.Length == 0)
            {
                label_card.Hide();
                pictureBox_card.Hide();
                button_good.Hide();
                button_replay.Hide();
                label_finish.Show();
            }
            else
            {
                this.pictureBox_card.Show();
                this.label_card.Show();
                
                this.button_good.Show();
                this.button_replay.Show();
            }    

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox_card.Hide();
            this.label_card.Hide();
            this.listView1.Show();
            this.button_good.Hide();
            this.button_replay.Hide();
            this.label_finish.Hide();
        }
        private void RandomizePicture()
        {
     

            int maxValue = images.Length;
            int idx = r.Next(maxValue);
            this.pictureBox_card.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox_card.Image = images[idx];
            pic = images[idx];
            pic_name = name[idx];
            
            this.label_card.Text = pic_name.Replace('_', ' ');
            //this.textBox1.Text = answer;
        }

        private void button_replay_Click(object sender, EventArgs e)
        {
            label_finish.Hide();
            RandomizePicture();
        }

        private void button_good_Click(object sender, EventArgs e)
        {
            images = images.Where(val => val != pic).ToArray();
            name = name.Where(val => val != pic_name).ToArray();
            if(images.Length == 0)
            {
                label_card.Hide();
                pictureBox_card.Hide();
                button_good.Hide();
                button_replay.Hide();
                label_finish.Show();
            }
            else
            {
                RandomizePicture();
            }
                
        }

        private void pictureBox_speaker_Click(object sender, EventArgs e)
        {
            if (Form1.soundon)
            {
                Form1.wmp.Ctlcontrols.stop();
                pictureBox_speaker.BackgroundImage = Addition.mute;
            }
            else
            {
                Form1.wmp.Ctlcontrols.play();
                pictureBox_speaker.BackgroundImage = Addition.speaker;
            }
            Form1.soundon = !Form1.soundon;
        }
    }
}

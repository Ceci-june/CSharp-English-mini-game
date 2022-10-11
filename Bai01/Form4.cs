using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
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
        public string category;
        public Random r = new Random();
        public Bitmap pic;
        public string pic_name;
        public Form4(string s)
        {
            category = s;
            InitializeComponent();
            GetResourceImages();
            ListViewItem item = new ListViewItem();
            //listView1.SmallImageList = images;
            int maxValue = images.Length;
            ImageList imageList = new ImageList { ImageSize = new Size(200, 200) };

            for (int i = 0; i < maxValue; i++)
            {
                //item. = imanges[i];
                imageList.Images.Add( images[i]);
                this.listView1.Items.Add(name[i],i);
            }
            
            this.listView1.View = View.LargeIcon;
       
            
            this.listView1.LargeImageList = imageList;
            label_animal.BackColor = Color.Transparent;
            this.pictureBox_card.Hide();
            this.label_card.Hide();
            this.button_good.Hide();
            this.button_replay.Hide();  
            RandomizePicture();
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
                    props = typeof(Vegetabel).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
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
            this.pictureBox_card.Show();
            this.label_card.Show();
            this.listView1.Hide();
            this.button_good.Show();
            this.button_replay.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox_card.Hide();
            this.label_card.Hide();
            this.listView1.Show();
            this.button_good.Hide();
            this.button_replay.Hide();
        }
        private void RandomizePicture()
        {
     

            int maxValue = images.Length;
            int idx = r.Next(maxValue);
            this.pictureBox_card.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox_card.Image = images[idx];
            pic = images[idx];
            pic_name = name[idx];
            
            this.label_card.Text = pic_name;
            //this.textBox1.Text = answer;
        }

        private void button_replay_Click(object sender, EventArgs e)
        {
            RandomizePicture();
        }

        private void button_good_Click(object sender, EventArgs e)
        {
            images = images.Where(val => val != pic).ToArray();
            name = name.Where(val => val != pic_name).ToArray();
            RandomizePicture();
        }
    }
}

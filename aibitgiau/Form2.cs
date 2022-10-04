using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aibitgiau
{
    
    public partial class Form2 : Form
    {
        public Bitmap[] images;
        public Random r = new Random();
        public string answer ;
        public string[] name; 
        public Form2()
        {
            InitializeComponent();
            GetResourceImages();
            RandomizePicture();
            RandomizePicture();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void GetResourceImages()
        {
            PropertyInfo[] props = typeof(Animal).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
            images = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.GetValue(null, null) as Bitmap).ToArray();
            name = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.Name as string).ToArray();
        }
        private void RandomizePicture()
        {
            
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

            this.textBox1.Text = answer;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RandomizePicture();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

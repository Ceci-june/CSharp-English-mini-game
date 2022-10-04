using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aibitgiau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_load()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("En", typeof(string));
            dt.Columns.Add("Vn", typeof(string));

            dt.Rows.Add("1", "Apple", "Táo");
            dt.Rows.Add("2", "", "");
            dt.Rows.Add("3", "", "");
            dt.Rows.Add("4", "", "");
            dt.Rows.Add("5", "", "");
            dt.Rows.Add("6", "", "");
            dt.Rows.Add("7", "", "");
            dt.Rows.Add("8", "", "");
            dt.Rows.Add("9", "", "");
            dt.Rows.Add("10", "", "");

            //dataGridView1.DataSource = dt;
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}

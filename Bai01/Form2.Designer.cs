namespace Bai01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox_table = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox_incorrecttext = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_name = new System.Windows.Forms.PictureBox();
            this.richTextBox_namet = new System.Windows.Forms.RichTextBox();
            this.pictureBox_name1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_name2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_name3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_name4 = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_incorrecttext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(174, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 343);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 438);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1051, 622);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Bai01.Addition.score;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(2, 360);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 149);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(57, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Bai01.Addition.Exit;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(884, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 43);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(25, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 50);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox_table
            // 
            this.pictureBox_table.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_table.BackgroundImage = global::Bai01.Addition.question;
            this.pictureBox_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_table.Location = new System.Drawing.Point(722, 225);
            this.pictureBox_table.Name = "pictureBox_table";
            this.pictureBox_table.Size = new System.Drawing.Size(255, 294);
            this.pictureBox_table.TabIndex = 9;
            this.pictureBox_table.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(762, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Question: 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_incorrecttext
            // 
            this.pictureBox_incorrecttext.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_incorrecttext.BackgroundImage = global::Bai01.Addition.incorrect_text;
            this.pictureBox_incorrecttext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_incorrecttext.Location = new System.Drawing.Point(260, 19);
            this.pictureBox_incorrecttext.Name = "pictureBox_incorrecttext";
            this.pictureBox_incorrecttext.Size = new System.Drawing.Size(478, 86);
            this.pictureBox_incorrecttext.TabIndex = 11;
            this.pictureBox_incorrecttext.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 67);
            this.label3.TabIndex = 12;
            this.label3.Text = "    ";
            // 
            // pictureBox_name
            // 
            this.pictureBox_name.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_name.BackgroundImage = global::Bai01.Addition.name;
            this.pictureBox_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_name.Location = new System.Drawing.Point(2, 12);
            this.pictureBox_name.Name = "pictureBox_name";
            this.pictureBox_name.Size = new System.Drawing.Size(975, 532);
            this.pictureBox_name.TabIndex = 13;
            this.pictureBox_name.TabStop = false;
            this.pictureBox_name.Click += new System.EventHandler(this.pictureBox_name_Click);
            // 
            // richTextBox_namet
            // 
            this.richTextBox_namet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_namet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_namet.Location = new System.Drawing.Point(390, 410);
            this.richTextBox_namet.Name = "richTextBox_namet";
            this.richTextBox_namet.Size = new System.Drawing.Size(224, 44);
            this.richTextBox_namet.TabIndex = 15;
            this.richTextBox_namet.Text = "";
            this.richTextBox_namet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_namet_KeyPress);
            // 
            // pictureBox_name1
            // 
            this.pictureBox_name1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox_name1.Location = new System.Drawing.Point(229, 48);
            this.pictureBox_name1.Name = "pictureBox_name1";
            this.pictureBox_name1.Size = new System.Drawing.Size(530, 422);
            this.pictureBox_name1.TabIndex = 16;
            this.pictureBox_name1.TabStop = false;
            // 
            // pictureBox_name2
            // 
            this.pictureBox_name2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox_name2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_name2.Location = new System.Drawing.Point(381, 106);
            this.pictureBox_name2.Name = "pictureBox_name2";
            this.pictureBox_name2.Size = new System.Drawing.Size(238, 285);
            this.pictureBox_name2.TabIndex = 18;
            this.pictureBox_name2.TabStop = false;
            // 
            // pictureBox_name3
            // 
            this.pictureBox_name3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox_name3.BackgroundImage = global::Bai01.Addition.Amongus05;
            this.pictureBox_name3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_name3.Location = new System.Drawing.Point(402, 134);
            this.pictureBox_name3.Name = "pictureBox_name3";
            this.pictureBox_name3.Size = new System.Drawing.Size(194, 232);
            this.pictureBox_name3.TabIndex = 19;
            this.pictureBox_name3.TabStop = false;
            // 
            // pictureBox_name4
            // 
            this.pictureBox_name4.BackColor = System.Drawing.Color.Teal;
            this.pictureBox_name4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_name4.Location = new System.Drawing.Point(383, 404);
            this.pictureBox_name4.Name = "pictureBox_name4";
            this.pictureBox_name4.Size = new System.Drawing.Size(238, 57);
            this.pictureBox_name4.TabIndex = 20;
            this.pictureBox_name4.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoEllipsis = true;
            this.label_name.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(310, 56);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(389, 47);
            this.label_name.TabIndex = 21;
            this.label_name.Text = "Enter your name";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bai01.Addition.Chat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 531);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.richTextBox_namet);
            this.Controls.Add(this.pictureBox_name4);
            this.Controls.Add(this.pictureBox_name3);
            this.Controls.Add(this.pictureBox_name2);
            this.Controls.Add(this.pictureBox_name1);
            this.Controls.Add(this.pictureBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_incorrecttext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_incorrecttext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_name4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox_table;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox_incorrecttext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_name;
        private System.Windows.Forms.RichTextBox richTextBox_namet;
        private System.Windows.Forms.PictureBox pictureBox_name1;
        private System.Windows.Forms.PictureBox pictureBox_name2;
        private System.Windows.Forms.PictureBox pictureBox_name3;
        private System.Windows.Forms.PictureBox pictureBox_name4;
        private System.Windows.Forms.Label label_name;
    }
}
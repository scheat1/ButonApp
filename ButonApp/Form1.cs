﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonApp
{
    public partial class Form1 : Form
    {
        static int puan, sure = 30;
        static string path = "C:/ButonOyunuPuanlar.txt";

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            lblPuan.Text = "Puan";
            lblSure.Text = "Süre";


        }

        private void btnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Dispose();

            puan += int.Parse(b.Text);
            lblPuan.Text = $" Puan = {puan}";
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if (sure > 0)
            {
                sure--;
                lblSure.Text = "Süre : " + sure.ToString();
            }
            else
            {
                time.Stop();
                game.Stop();
                dynamic result = MessageBox.Show("Süre Bitti \nPuanınız: " + lblPuan.Text + "\nYeniden Oynama İster Misiniz ?",
                "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FileWriter();
                    Application.Restart();
                }

                if (result == DialogResult.No)
                {
                    FileWriter();
                    Application.Exit();
                }
            }
        }

        private void game_Tick(object sender, EventArgs e)
        {
            if (sure > 0)
            {
                Button btn = new Button();
                btn.Size = new Size(70, 35);
                btn.Text = rnd.Next(100).ToString();
                btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlPuan.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
                btn.Visible = true;
                this.Controls.Add(btn);
                btn.Click += btnClick;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game.Start();
            time.Start();
        }

        private void FileWriter()
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now + " " + "Puan: " + puan);
            fs.Flush();
            sw.Close();
            fs.Close();
        }

    }
}


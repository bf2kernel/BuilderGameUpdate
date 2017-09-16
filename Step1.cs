using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Builder_Game_Update
{
    public partial class Step1 : Form
    {
        public Step1()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMIExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangePathClient_Click(object sender, EventArgs e)
        {
            DialogResult res = FBD_PathClient.ShowDialog();

            if (res == DialogResult.OK)
            {
                string path = FBD_PathClient.SelectedPath;
                this.PathClient.Text = path;
                Properties.Settings.Default.PathClient = path;
                Properties.Settings.Default.Save();
            }
        }

        private void ChangePathTo_Click(object sender, EventArgs e)
        {
            DialogResult res = FBD_PathTo.ShowDialog();

            if (res == DialogResult.OK)
            {
                string path = FBD_PathTo.SelectedPath;
                this.PathTo.Text = path;
                Properties.Settings.Default.PathTo = path;
                Properties.Settings.Default.Save();
            }
        }

        private void Step1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PathClient.Length > 0)
            {
                this.PathClient.Text = Properties.Settings.Default.PathClient;
            }

            if (Properties.Settings.Default.PathTo.Length > 0)
            {
                this.PathTo.Text = Properties.Settings.Default.PathTo;
            }
        }

        private void TSMIAbout_Click(object sender, EventArgs e)
        {
            Form About = new About();
            About.ShowDialog();
        }

        private void ToStep2_Click(object sender, EventArgs e)
        {   
            int err = 0;

            if (this.PathClient.Text == "")
            {
                MessageBox.Show("Не указана папка с клиентом");
                err = 1;
            }

            if (this.PathTo.Text == "")
            {
                MessageBox.Show("Не указан путь обновлений");
                err = 1;
            }

            if (this.PathClient.Text == this.PathTo.Text)
            {
                MessageBox.Show("В одну и туже папку ? Да ну нах!");
                err = 1;
            }

            if (err == 0)
            {
                Form Step2 = new Step2();
                Step2.Show();
                this.Hide();
            }
        }
    }
}


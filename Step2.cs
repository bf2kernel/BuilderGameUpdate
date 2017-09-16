using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Builder_Game_Update
{
    public partial class Step2 : Form
    {
        public Step2()
        {
            InitializeComponent();
        }
        private string PathClient = Properties.Settings.Default.PathClient;
        private string PathTo = Properties.Settings.Default.PathTo;
        private Int64 AllFilesSize;
        private Int64 DriveFreeSize;
        int AllFilesCnt = 0;

        private bool CheckFreeSpace()
        {
            DirectoryInfo diPT = new DirectoryInfo(@PathTo);
            DriveInfo di = new DriveInfo(diPT.Root.ToString());
            DriveFreeSize = di.AvailableFreeSpace;

            if (DriveFreeSize < AllFilesSize)
                return false;
            else
                return true;
        }

        private void Step2_Load(object sender, EventArgs e)
        {
            DirectoryInfo fFromDir = new DirectoryInfo(@PathClient);

            foreach (FileInfo Fname in fFromDir.GetFiles("*", SearchOption.AllDirectories))
            {

                FileAttributes attributes = File.GetAttributes(Fname.FullName);
                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    File.SetAttributes(Fname.FullName, FileAttributes.Normal);
                }

                FileInfo ufInfo = new FileInfo(Fname.FullName);
                AllFilesSize = AllFilesSize + ufInfo.Length;

                string FullDirName = Fname.FullName;
                string DirName = FullDirName.Replace(PathClient + "\\", "").Replace(Fname.Name, "");

                LB_FULL.Items.Add(DirName + Fname.Name);
                AllFilesCnt++;
                Properties.Settings.Default.AllFilesCnt = AllFilesCnt;
            }

            if (!CheckFreeSpace())
            {
                MessageBox.Show("Недостаточно места на диске для создания обновлений");
            }
        }

        private void Step2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ToRight_Click(object sender, EventArgs e)
        {
            ArrayList sel = new ArrayList(LB_FULL.SelectedItems);
            foreach (Object SelectedItem in sel)
            {
                if (!LB_CRITICAL.Items.Contains(SelectedItem))
                    LB_CRITICAL.Items.Add(SelectedItem);                                
            }
        }

        private void ToLeft_Click(object sender, EventArgs e)
        {
            ArrayList sel = new ArrayList(LB_CRITICAL.SelectedItems);
            foreach (Object SelectedItem in sel)
                LB_CRITICAL.Items.Remove(SelectedItem);
        }

        private void ToStep3_Click(object sender, EventArgs e)
        {
            this.GoToStep3();
        }

        private void SaveParams_Click(object sender, EventArgs e)
        {
            ArrayList CL = new ArrayList(LB_CRITICAL.Items);
            Properties.Settings.Default.CriticalList = CL;
            Properties.Settings.Default.Save();
        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_Run_Click(object sender, EventArgs e)
        {
            this.GoToStep3();
        }
        private void GoToStep3()
        {
            ArrayList CL = new ArrayList(LB_CRITICAL.Items);
            Properties.Settings.Default.CriticalList = CL;
            Properties.Settings.Default.Save();

            if (CheckFreeSpace())
            {
                Form Step3 = new Step3();
                Step3.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Недостаточно места на диске для создания обновлений");        
        }
    }
}

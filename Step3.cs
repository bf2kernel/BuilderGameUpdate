using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Ionic.Zip;

namespace Builder_Game_Update
{
    public partial class Step3 : Form
    {
        public Step3()
        {
            InitializeComponent();
        }

        // in params
        private string VERSION_FILE = "update.version";
        private int AllFiles = Properties.Settings.Default.AllFilesCnt;
        private string PathClient = Properties.Settings.Default.PathClient;
        private string PathTo = Properties.Settings.Default.PathTo;
        ArrayList CL = Properties.Settings.Default.CriticalList;
        private string[] delimeter = { "|" };
        //Delegate
        private delegate void updateProgressFullDelegate(int val);
        private delegate void updateFileProgressDelegate(int val);
        private delegate void ShowMsgProgressDelegate(string val);
        
        private void UpdateProgressFull(int val)
        {
            if (this.PB_FULL.InvokeRequired)
                this.PB_FULL.Invoke(new updateProgressFullDelegate(UpdateProgressFull), val);
            else
                this.PB_FULL.Value = val;
        }

        private void UpdateFileProgress(int val)
        {
            if (this.PB_FILE.InvokeRequired)
                this.PB_FILE.Invoke(new updateFileProgressDelegate(UpdateFileProgress), val);
            else
                this.PB_FILE.Value = val;
        }

        private void ShowMsgProgress(string val)
        {
            if (this.StatusMsg.InvokeRequired)
                this.StatusMsg.Invoke(new ShowMsgProgressDelegate(ShowMsgProgress), val);
            else
                this.StatusMsg.Text = val;
        }

        private int GetPatchVersion(bool delete)
        {
            if (File.Exists(PathTo + "\\" + VERSION_FILE))
            {
                //читаем его и получаем версию патча
                string VersionFileLine;
                int PatchVersion = 0;
                StreamReader VersionFile = new StreamReader(PathTo + "\\" +VERSION_FILE);
                while ((VersionFileLine = VersionFile.ReadLine()) != null)
                {
                    if (VersionFileLine != "")
                    {
                        PatchVersion = Convert.ToInt16(VersionFileLine);
                    }
                }
                VersionFile.Close();

                //удаляем файл
                if (delete == true)
                    File.Delete(PathTo + "\\" +VERSION_FILE);

                return PatchVersion;
            }
            return 0;
        }

        private void PlusPatchVersion()
        {
            int pVersion = this.GetPatchVersion(true);
            pVersion++;
            if (File.Exists(PathTo + "\\" + VERSION_FILE))
                File.Delete(PathTo + "\\" + VERSION_FILE);

            FileStream vFile = new FileStream(PathTo + "\\" +VERSION_FILE, FileMode.Create, FileAccess.Write);
            StreamWriter svFl = new StreamWriter(vFile);
            svFl.WriteLine(pVersion.ToString());
            svFl.Close();
            vFile.Close();
        }

        private void Step3_Load(object sender, EventArgs e)
        {
            PB_FULL.Maximum = AllFiles;

            this.PlusPatchVersion();

            // создаем наши 2 главных файла
           
            ShowMsgProgress("Проверяем наличие файла full.list");
            if (System.IO.File.Exists(PathTo + "\\full.list"))
            {
                ShowMsgProgress("Файл full.list найден");
                if (File.Exists(PathTo + "\\_full.list"))
                {
                    File.Delete(PathTo + "\\_full.list");
                }

                ShowMsgProgress("Переименовываем full.list в _full.list");
                File.Move(PathTo + "\\full.list", PathTo + "\\_full.list");
            }
            ShowMsgProgress("Создаем файл full.list");
            FileStream fFl = new FileStream(PathTo + "\\full.list", FileMode.Create, FileAccess.Write);
            fFl.Close();

            ShowMsgProgress("Проверяем наличие файла critical.list");
            if (System.IO.File.Exists(PathTo + "\\critical.list"))
            {
                ShowMsgProgress("Файл critical.list найден, убиваем нахуй");
                File.Delete(PathTo + "\\critical.list");
            }
            else
            {
                ShowMsgProgress("Файл critical.list не найден, да и хуй с ним.");
            }

            ShowMsgProgress("Создаем файл critical.list");
            FileStream cFl = new FileStream(PathTo + "\\critical.list", FileMode.Create, FileAccess.Write);
            cFl.Close();
            // усе файлы есть, погнали дальше
            this.BW_MAIN.RunWorkerAsync(2000);
        }

        private void Step3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BW_MAIN_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            this.Compile();
        }

        private void Compile()
        {
            Crc32 crc32 = new Crc32();

            int FullFileProgress = 0;
            bool FulFileExist = false;
            bool CriticalExist = true;

            if (CL.Count <= 0)
                CriticalExist = false;

            if (CriticalExist)
            {
                ShowMsgProgress("Есть критические файлы в обновлении");
            }
            ShowMsgProgress("Открываем файл critical.list на запись");

            FileStream fsCU = new FileStream(PathTo + "\\critical.list", FileMode.Open, FileAccess.Write);
            StreamWriter sCU = new StreamWriter(fsCU);


            ShowMsgProgress("Открываем файл full.list на запись");

            FileStream fsFU = new FileStream(PathTo + "\\full.list", FileMode.Open, FileAccess.Write);
            StreamWriter sFU = new StreamWriter(fsFU);

            ShowMsgProgress("Проверяем наличие файла _full.list");
            if (File.Exists(PathTo + "\\_full.list"))
                FulFileExist = true;

            if (FulFileExist)
            {
                ShowMsgProgress("Файл предшествующего обновления найден!");
                ShowMsgProgress("При обновлении будем учитывать его данные");            
            }

            ShowMsgProgress("Начинаем педалить");
            DirectoryInfo fFromDir = new DirectoryInfo(@PathClient);
        
                foreach (FileInfo Fname in fFromDir.GetFiles("*", SearchOption.AllDirectories))
            {
                string FullDirName = Fname.FullName;
                    string DirName = FullDirName.Replace(PathClient + "\\", "").Replace(Fname.Name, "");

                ShowMsgProgress("Читаем директорию: " + DirName);

                    //params
                    bool ToZip = true;

                    UpdateFileProgress(0);

                    ShowMsgProgress("Проверяем есть ли в обновлениях директория: " + DirName);
                    if (!System.IO.Directory.Exists(PathTo + "\\" + DirName))
                    {
                        
                        ShowMsgProgress("Нихера нету, создаем директорию: " + DirName);
                        System.IO.Directory.CreateDirectory(PathTo + "\\" + DirName);
                    }

                    ShowMsgProgress("Собираем информацию о файле: " + Fname.Name);

                    string FileHash = crc32.Get(Fname.FullName);

                    if (FulFileExist)
                    {
                        string line;

                        StreamReader readLastAllFile = new StreamReader(@PathTo + "\\_full.list");
                        //readLastAllFile.
                        while ((line = readLastAllFile.ReadLine()) != null)
                        {
                            string[] sLine = line.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
                            if (sLine[0].Trim() == DirName + "\\" + Fname.Name)
                            {
                                if (File.Exists(PathTo + "\\" + sLine[0] + ".zip"))
                                {
                                    ShowMsgProgress("Файл: " + Fname.Name + " уже есть в обновлениях.");
                                    ShowMsgProgress("Проверяем файл: " + Fname.Name + " на наличие модификаций");

                                    if (FileHash == sLine[2].Trim() && sLine[4].Trim() == crc32.Get(PathTo + "\\" + sLine[0] + ".zip"))
                                    {
                                        ShowMsgProgress("Хеш файла: " + Fname.Name + " совпал, файл не обновлялся. Пропускаем");
                                        ToZip = false;
                                    }
                                }
                            }
                        }
                        readLastAllFile.Close();
                    }

                    if (ToZip)
                    {
                        ShowMsgProgress("Архивируем файл: " + Fname.FullName);
                        using (ZipFile zip = new ZipFile()) // Создаем объект для работы с архивом
                        {
                            zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression; // Задаем максимальную степень сжатия
                            zip.AddFile(Fname.FullName, "");
                            zip.Save(@PathTo + "\\" + DirName + "\\" + Fname.Name + ".zip"); // Создаем архив                             
                        }
                    }
                    ShowMsgProgress("Собираем информацию о файле для обновлений");

                    FileInfo SizecF = new FileInfo(Fname.FullName);
                    FileInfo SizecFz = new FileInfo(PathTo + "\\" + DirName + "\\" + Fname.Name + ".zip");
                    string ZFHash = crc32.Get(PathTo + "\\" + DirName + "\\" + Fname.Name + ".zip").ToString();

                    sFU.WriteLine(DirName + Fname.Name + "|" + SizecF.Length + "|" + FileHash.ToString() + "|" + SizecFz.Length + "|" + ZFHash);

                    if (CL.Contains(DirName + Fname.Name))
                    {
                        sCU.WriteLine(DirName + Fname.Name + "|" + SizecF.Length + "|" + FileHash.ToString() + "|" + SizecFz.Length + "|" + ZFHash);
                    }


                    //tick
                    FullFileProgress++;                    
                    UpdateProgressFull(FullFileProgress);
                
            }
            ShowMsgProgress("Завершение операций");

            if (CriticalExist)
            {
                sCU.Close();
            }

            sFU.Close();
            

            if (FulFileExist)
                File.Delete(PathTo + "\\_full.list");

            ShowMsgProgress("Создание обновления успешно завершено");
        }

        private void BW_MAIN_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.PB_FILE.Style = ProgressBarStyle.Blocks;
        }
    }
}

namespace Builder_Game_Update
{
    partial class Step3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step3));
            this.Action = new System.Windows.Forms.Label();
            this.PB_FILE = new System.Windows.Forms.ProgressBar();
            this.PB_FULL = new System.Windows.Forms.ProgressBar();
            this.StatusFile = new System.Windows.Forms.Label();
            this.StatusFull = new System.Windows.Forms.Label();
            this.StatusMsg = new System.Windows.Forms.Label();
            this.BW_MAIN = new System.ComponentModel.BackgroundWorker();
            this.T_MAIN = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Action.Location = new System.Drawing.Point(12, 22);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(206, 26);
            this.Action.TabIndex = 0;
            this.Action.Text = "Текущее действие:";
            // 
            // PB_FILE
            // 
            this.PB_FILE.Location = new System.Drawing.Point(227, 66);
            this.PB_FILE.Name = "PB_FILE";
            this.PB_FILE.Size = new System.Drawing.Size(497, 23);
            this.PB_FILE.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PB_FILE.TabIndex = 1;
            // 
            // PB_FULL
            // 
            this.PB_FULL.Location = new System.Drawing.Point(227, 99);
            this.PB_FULL.Name = "PB_FULL";
            this.PB_FULL.Size = new System.Drawing.Size(497, 23);
            this.PB_FULL.TabIndex = 2;
            // 
            // StatusFile
            // 
            this.StatusFile.AutoSize = true;
            this.StatusFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusFile.Location = new System.Drawing.Point(12, 63);
            this.StatusFile.Name = "StatusFile";
            this.StatusFile.Size = new System.Drawing.Size(174, 26);
            this.StatusFile.TabIndex = 3;
            this.StatusFile.Text = "Прогресс файл:";
            // 
            // StatusFull
            // 
            this.StatusFull.AutoSize = true;
            this.StatusFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusFull.Location = new System.Drawing.Point(12, 96);
            this.StatusFull.Name = "StatusFull";
            this.StatusFull.Size = new System.Drawing.Size(195, 26);
            this.StatusFull.TabIndex = 4;
            this.StatusFull.Text = "Полный прогресс:";
            // 
            // StatusMsg
            // 
            this.StatusMsg.AutoSize = true;
            this.StatusMsg.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.StatusMsg.Location = new System.Drawing.Point(224, 31);
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(63, 13);
            this.StatusMsg.TabIndex = 5;
            this.StatusMsg.Text = "Колбасим";
            // 
            // BW_MAIN
            // 
            this.BW_MAIN.WorkerReportsProgress = true;
            this.BW_MAIN.WorkerSupportsCancellation = true;
            this.BW_MAIN.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_MAIN_DoWork);
            this.BW_MAIN.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_MAIN_RunWorkerCompleted);
            // 
            // Step3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(746, 146);
            this.Controls.Add(this.StatusMsg);
            this.Controls.Add(this.StatusFull);
            this.Controls.Add(this.StatusFile);
            this.Controls.Add(this.PB_FULL);
            this.Controls.Add(this.PB_FILE);
            this.Controls.Add(this.Action);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Step3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder Game Update [Step 3]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Step3_FormClosed);
            this.Load += new System.EventHandler(this.Step3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Action;
        private System.Windows.Forms.ProgressBar PB_FILE;
        private System.Windows.Forms.ProgressBar PB_FULL;
        private System.Windows.Forms.Label StatusFile;
        private System.Windows.Forms.Label StatusFull;
        private System.Windows.Forms.Label StatusMsg;
        private System.ComponentModel.BackgroundWorker BW_MAIN;
        private System.Windows.Forms.Timer T_MAIN;
    }
}
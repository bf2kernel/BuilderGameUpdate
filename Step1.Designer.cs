namespace Builder_Game_Update
{
    partial class Step1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step1));
            this.PathClientMsg = new System.Windows.Forms.Label();
            this.PathToMsg = new System.Windows.Forms.Label();
            this.PathClient = new System.Windows.Forms.TextBox();
            this.PathTo = new System.Windows.Forms.TextBox();
            this.ChangePathClient = new System.Windows.Forms.Button();
            this.ChangePathTo = new System.Windows.Forms.Button();
            this.ToStep2 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.FBD_PathClient = new System.Windows.Forms.FolderBrowserDialog();
            this.FBD_PathTo = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // PathClientMsg
            // 
            this.PathClientMsg.AutoSize = true;
            this.PathClientMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathClientMsg.Location = new System.Drawing.Point(12, 60);
            this.PathClientMsg.Name = "PathClientMsg";
            this.PathClientMsg.Size = new System.Drawing.Size(343, 26);
            this.PathClientMsg.TabIndex = 0;
            this.PathClientMsg.Text = "Путь до директории с клиентом:";
            // 
            // PathToMsg
            // 
            this.PathToMsg.AutoSize = true;
            this.PathToMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathToMsg.Location = new System.Drawing.Point(14, 112);
            this.PathToMsg.Name = "PathToMsg";
            this.PathToMsg.Size = new System.Drawing.Size(350, 26);
            this.PathToMsg.TabIndex = 1;
            this.PathToMsg.Text = "Путь до директории обновлений:";
            // 
            // PathClient
            // 
            this.PathClient.Location = new System.Drawing.Point(366, 66);
            this.PathClient.Name = "PathClient";
            this.PathClient.ReadOnly = true;
            this.PathClient.Size = new System.Drawing.Size(365, 20);
            this.PathClient.TabIndex = 2;
            // 
            // PathTo
            // 
            this.PathTo.Location = new System.Drawing.Point(366, 118);
            this.PathTo.Name = "PathTo";
            this.PathTo.ReadOnly = true;
            this.PathTo.Size = new System.Drawing.Size(365, 20);
            this.PathTo.TabIndex = 3;
            // 
            // ChangePathClient
            // 
            this.ChangePathClient.Location = new System.Drawing.Point(750, 66);
            this.ChangePathClient.Name = "ChangePathClient";
            this.ChangePathClient.Size = new System.Drawing.Size(46, 23);
            this.ChangePathClient.TabIndex = 4;
            this.ChangePathClient.Text = "...";
            this.ChangePathClient.UseVisualStyleBackColor = true;
            this.ChangePathClient.Click += new System.EventHandler(this.ChangePathClient_Click);
            // 
            // ChangePathTo
            // 
            this.ChangePathTo.Location = new System.Drawing.Point(750, 112);
            this.ChangePathTo.Name = "ChangePathTo";
            this.ChangePathTo.Size = new System.Drawing.Size(46, 23);
            this.ChangePathTo.TabIndex = 5;
            this.ChangePathTo.Text = "...";
            this.ChangePathTo.UseVisualStyleBackColor = true;
            this.ChangePathTo.Click += new System.EventHandler(this.ChangePathTo_Click);
            // 
            // ToStep2
            // 
            this.ToStep2.Location = new System.Drawing.Point(627, 171);
            this.ToStep2.Name = "ToStep2";
            this.ToStep2.Size = new System.Drawing.Size(75, 23);
            this.ToStep2.TabIndex = 6;
            this.ToStep2.Text = "Далее >>";
            this.ToStep2.UseVisualStyleBackColor = true;
            this.ToStep2.Click += new System.EventHandler(this.ToStep2_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(727, 171);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FBD_PathClient
            // 
            this.FBD_PathClient.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FBD_PathClient.ShowNewFolderButton = false;
            // 
            // FBD_PathTo
            // 
            this.FBD_PathTo.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(814, 204);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ToStep2);
            this.Controls.Add(this.ChangePathTo);
            this.Controls.Add(this.ChangePathClient);
            this.Controls.Add(this.PathTo);
            this.Controls.Add(this.PathClient);
            this.Controls.Add(this.PathToMsg);
            this.Controls.Add(this.PathClientMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Step1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder Game Update [Step 1]";
            this.Load += new System.EventHandler(this.Step1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathClientMsg;
        private System.Windows.Forms.Label PathToMsg;
        private System.Windows.Forms.TextBox PathClient;
        private System.Windows.Forms.TextBox PathTo;
        private System.Windows.Forms.Button ChangePathClient;
        private System.Windows.Forms.Button ChangePathTo;
        private System.Windows.Forms.Button ToStep2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.FolderBrowserDialog FBD_PathClient;
        private System.Windows.Forms.FolderBrowserDialog FBD_PathTo;
    }
}


namespace Builder_Game_Update
{
    partial class Step2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step2));
            this.LB_FULL = new System.Windows.Forms.ListBox();
            this.LB_CRITICAL = new System.Windows.Forms.ListBox();
            this.ToRight = new System.Windows.Forms.Button();
            this.ToLeft = new System.Windows.Forms.Button();
            this.ToStep3 = new System.Windows.Forms.Button();
            this.SaveParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_FULL
            // 
            this.LB_FULL.FormattingEnabled = true;
            this.LB_FULL.Location = new System.Drawing.Point(33, 36);
            this.LB_FULL.Name = "LB_FULL";
            this.LB_FULL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LB_FULL.Size = new System.Drawing.Size(230, 407);
            this.LB_FULL.TabIndex = 0;
            // 
            // LB_CRITICAL
            // 
            this.LB_CRITICAL.FormattingEnabled = true;
            this.LB_CRITICAL.Location = new System.Drawing.Point(426, 36);
            this.LB_CRITICAL.Name = "LB_CRITICAL";
            this.LB_CRITICAL.Size = new System.Drawing.Size(230, 407);
            this.LB_CRITICAL.TabIndex = 1;
            // 
            // ToRight
            // 
            this.ToRight.Location = new System.Drawing.Point(307, 146);
            this.ToRight.Name = "ToRight";
            this.ToRight.Size = new System.Drawing.Size(75, 23);
            this.ToRight.TabIndex = 2;
            this.ToRight.Text = ">>>";
            this.ToRight.UseVisualStyleBackColor = true;
            this.ToRight.Click += new System.EventHandler(this.ToRight_Click);
            // 
            // ToLeft
            // 
            this.ToLeft.Location = new System.Drawing.Point(307, 186);
            this.ToLeft.Name = "ToLeft";
            this.ToLeft.Size = new System.Drawing.Size(75, 23);
            this.ToLeft.TabIndex = 3;
            this.ToLeft.Text = "<<<";
            this.ToLeft.UseVisualStyleBackColor = true;
            this.ToLeft.Click += new System.EventHandler(this.ToLeft_Click);
            // 
            // ToStep3
            // 
            this.ToStep3.Location = new System.Drawing.Point(489, 462);
            this.ToStep3.Name = "ToStep3";
            this.ToStep3.Size = new System.Drawing.Size(167, 23);
            this.ToStep3.TabIndex = 7;
            this.ToStep3.Text = "Создать обновления >>>";
            this.ToStep3.UseVisualStyleBackColor = true;
            this.ToStep3.Click += new System.EventHandler(this.ToStep3_Click);
            // 
            // SaveParams
            // 
            this.SaveParams.Location = new System.Drawing.Point(33, 462);
            this.SaveParams.Name = "SaveParams";
            this.SaveParams.Size = new System.Drawing.Size(148, 23);
            this.SaveParams.TabIndex = 8;
            this.SaveParams.Text = "Сохранить параметры";
            this.SaveParams.UseVisualStyleBackColor = true;
            this.SaveParams.Click += new System.EventHandler(this.SaveParams_Click);
            // 
            // Step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 494);
            this.Controls.Add(this.SaveParams);
            this.Controls.Add(this.ToStep3);
            this.Controls.Add(this.ToLeft);
            this.Controls.Add(this.ToRight);
            this.Controls.Add(this.LB_CRITICAL);
            this.Controls.Add(this.LB_FULL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Step2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder Game Update [Step 2]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Step2_FormClosed);
            this.Load += new System.EventHandler(this.Step2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_FULL;
        private System.Windows.Forms.ListBox LB_CRITICAL;
        private System.Windows.Forms.Button ToRight;
        private System.Windows.Forms.Button ToLeft;
        private System.Windows.Forms.Button ToStep3;
        private System.Windows.Forms.Button SaveParams;
    }
}
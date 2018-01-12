namespace RelaxAram
{
    partial class RelaxTime
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
            this.bStart = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.mTBHour = new System.Windows.Forms.MaskedTextBox();
            this.mTBMinute = new System.Windows.Forms.MaskedTextBox();
            this.mTBSecond = new System.Windows.Forms.MaskedTextBox();
            this.bSet = new System.Windows.Forms.Button();
            this.lHour = new System.Windows.Forms.Label();
            this.lMinute = new System.Windows.Forms.Label();
            this.lSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 10);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(12, 65);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 2;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // tbTime
            // 
            this.tbTime.Enabled = false;
            this.tbTime.Location = new System.Drawing.Point(26, 94);
            this.tbTime.Name = "tbTime";
            this.tbTime.ShortcutsEnabled = false;
            this.tbTime.Size = new System.Drawing.Size(49, 20);
            this.tbTime.TabIndex = 9;
            this.tbTime.TabStop = false;
            this.tbTime.Text = "01:00:00";
            // 
            // mTBHour
            // 
            this.mTBHour.Location = new System.Drawing.Point(127, 25);
            this.mTBHour.Mask = "00";
            this.mTBHour.Name = "mTBHour";
            this.mTBHour.Size = new System.Drawing.Size(20, 20);
            this.mTBHour.TabIndex = 3;
            this.mTBHour.ValidatingType = typeof(int);
            // 
            // mTBMinute
            // 
            this.mTBMinute.Location = new System.Drawing.Point(127, 51);
            this.mTBMinute.Mask = "00";
            this.mTBMinute.Name = "mTBMinute";
            this.mTBMinute.Size = new System.Drawing.Size(20, 20);
            this.mTBMinute.TabIndex = 4;
            this.mTBMinute.ValidatingType = typeof(int);
            // 
            // mTBSecond
            // 
            this.mTBSecond.Location = new System.Drawing.Point(127, 77);
            this.mTBSecond.Mask = "00";
            this.mTBSecond.Name = "mTBSecond";
            this.mTBSecond.Size = new System.Drawing.Size(20, 20);
            this.mTBSecond.TabIndex = 5;
            this.mTBSecond.ValidatingType = typeof(int);
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(12, 37);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(75, 23);
            this.bSet.TabIndex = 1;
            this.bSet.Text = "Set";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // lHour
            // 
            this.lHour.AutoSize = true;
            this.lHour.Location = new System.Drawing.Point(103, 28);
            this.lHour.Name = "lHour";
            this.lHour.Size = new System.Drawing.Size(18, 13);
            this.lHour.TabIndex = 13;
            this.lHour.Text = "H:";
            // 
            // lMinute
            // 
            this.lMinute.AutoSize = true;
            this.lMinute.Location = new System.Drawing.Point(103, 54);
            this.lMinute.Name = "lMinute";
            this.lMinute.Size = new System.Drawing.Size(19, 13);
            this.lMinute.TabIndex = 14;
            this.lMinute.Text = "M:";
            // 
            // lSecond
            // 
            this.lSecond.AutoSize = true;
            this.lSecond.Location = new System.Drawing.Point(103, 80);
            this.lSecond.Name = "lSecond";
            this.lSecond.Size = new System.Drawing.Size(17, 13);
            this.lSecond.TabIndex = 15;
            this.lSecond.Text = "S:";
            // 
            // RelaxTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 121);
            this.Controls.Add(this.lSecond);
            this.Controls.Add(this.lMinute);
            this.Controls.Add(this.lHour);
            this.Controls.Add(this.bSet);
            this.Controls.Add(this.mTBSecond);
            this.Controls.Add(this.mTBMinute);
            this.Controls.Add(this.mTBHour);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bStart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(185, 160);
            this.MinimumSize = new System.Drawing.Size(185, 160);
            this.Name = "RelaxTime";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.MaskedTextBox mTBHour;
        private System.Windows.Forms.MaskedTextBox mTBMinute;
        private System.Windows.Forms.MaskedTextBox mTBSecond;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.Label lHour;
        private System.Windows.Forms.Label lMinute;
        private System.Windows.Forms.Label lSecond;
    }
}


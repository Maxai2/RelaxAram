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
            this.bSet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mTBWSecond = new System.Windows.Forms.MaskedTextBox();
            this.lSecond = new System.Windows.Forms.Label();
            this.mTBWMinute = new System.Windows.Forms.MaskedTextBox();
            this.lMinute = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mTBRSecond = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTBRMinute = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mTBWSecond);
            this.groupBox1.Controls.Add(this.lSecond);
            this.groupBox1.Controls.Add(this.mTBWMinute);
            this.groupBox1.Controls.Add(this.lMinute);
            this.groupBox1.Location = new System.Drawing.Point(113, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 76);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Time";
            // 
            // mTBWSecond
            // 
            this.mTBWSecond.Location = new System.Drawing.Point(50, 44);
            this.mTBWSecond.Mask = "00";
            this.mTBWSecond.Name = "mTBWSecond";
            this.mTBWSecond.Size = new System.Drawing.Size(20, 20);
            this.mTBWSecond.TabIndex = 17;
            this.mTBWSecond.ValidatingType = typeof(int);
            // 
            // lSecond
            // 
            this.lSecond.AutoSize = true;
            this.lSecond.Location = new System.Drawing.Point(26, 47);
            this.lSecond.Name = "lSecond";
            this.lSecond.Size = new System.Drawing.Size(17, 13);
            this.lSecond.TabIndex = 19;
            this.lSecond.Text = "S:";
            // 
            // mTBWMinute
            // 
            this.mTBWMinute.Location = new System.Drawing.Point(50, 18);
            this.mTBWMinute.Mask = "00";
            this.mTBWMinute.Name = "mTBWMinute";
            this.mTBWMinute.Size = new System.Drawing.Size(20, 20);
            this.mTBWMinute.TabIndex = 16;
            this.mTBWMinute.ValidatingType = typeof(int);
            // 
            // lMinute
            // 
            this.lMinute.AutoSize = true;
            this.lMinute.Location = new System.Drawing.Point(26, 21);
            this.lMinute.Name = "lMinute";
            this.lMinute.Size = new System.Drawing.Size(19, 13);
            this.lMinute.TabIndex = 18;
            this.lMinute.Text = "M:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mTBRSecond);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mTBRMinute);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(245, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 76);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rest Time";
            // 
            // mTBRSecond
            // 
            this.mTBRSecond.Location = new System.Drawing.Point(50, 44);
            this.mTBRSecond.Mask = "00";
            this.mTBRSecond.Name = "mTBRSecond";
            this.mTBRSecond.Size = new System.Drawing.Size(20, 20);
            this.mTBRSecond.TabIndex = 17;
            this.mTBRSecond.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "S:";
            // 
            // mTBRMinute
            // 
            this.mTBRMinute.Location = new System.Drawing.Point(50, 18);
            this.mTBRMinute.Mask = "00";
            this.mTBRMinute.Name = "mTBRMinute";
            this.mTBRMinute.Size = new System.Drawing.Size(20, 20);
            this.mTBRMinute.TabIndex = 16;
            this.mTBRMinute.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "M:";
            // 
            // RelaxTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 125);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSet);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RelaxTime";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mTBWSecond;
        private System.Windows.Forms.Label lSecond;
        private System.Windows.Forms.MaskedTextBox mTBWMinute;
        private System.Windows.Forms.Label lMinute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mTBRSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTBRMinute;
        private System.Windows.Forms.Label label2;
    }
}


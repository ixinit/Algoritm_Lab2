namespace Algoritm2._14
{
    partial class Algoritm114
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEchoSum = new System.Windows.Forms.Label();
            this.btbCalc = new System.Windows.Forms.Button();
            this.tbMinet = new System.Windows.Forms.TextBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество минут";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена";
            // 
            // lblEchoSum
            // 
            this.lblEchoSum.AutoSize = true;
            this.lblEchoSum.Location = new System.Drawing.Point(197, 101);
            this.lblEchoSum.Name = "lblEchoSum";
            this.lblEchoSum.Size = new System.Drawing.Size(0, 13);
            this.lblEchoSum.TabIndex = 2;
            // 
            // btbCalc
            // 
            this.btbCalc.Location = new System.Drawing.Point(111, 149);
            this.btbCalc.Name = "btbCalc";
            this.btbCalc.Size = new System.Drawing.Size(75, 23);
            this.btbCalc.TabIndex = 3;
            this.btbCalc.Text = "Решить";
            this.btbCalc.UseVisualStyleBackColor = true;
            this.btbCalc.Click += new System.EventHandler(this.btbCalc_Click);
            // 
            // tbMinet
            // 
            this.tbMinet.Location = new System.Drawing.Point(184, 43);
            this.tbMinet.Name = "tbMinet";
            this.tbMinet.Size = new System.Drawing.Size(100, 20);
            this.tbMinet.TabIndex = 4;
            // 
            // cbDay
            // 
            this.cbDay.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDay.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.cbDay.Location = new System.Drawing.Point(427, 43);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 21);
            this.cbDay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "День недели";
            // 
            // Algoritm114
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.tbMinet);
            this.Controls.Add(this.btbCalc);
            this.Controls.Add(this.lblEchoSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Algoritm114";
            this.Text = "Algoritm114";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEchoSum;
        private System.Windows.Forms.Button btbCalc;
        private System.Windows.Forms.TextBox tbMinet;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label3;
    }
}
namespace N11310019_GUI_Class
{
    partial class FormButton
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
            this.btnBotton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.lab2 = new System.Windows.Forms.Label();
            this.btnCount2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBotton
            // 
            this.btnBotton.Location = new System.Drawing.Point(120, 107);
            this.btnBotton.Name = "btnBotton";
            this.btnBotton.Size = new System.Drawing.Size(101, 60);
            this.btnBotton.TabIndex = 5;
            this.btnBotton.Text = "請按我一下";
            this.btnBotton.UseVisualStyleBackColor = true;
            this.btnBotton.Click += new System.EventHandler(this.btnBotton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(568, 81);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(11, 12);
            this.labCount.TabIndex = 9;
            this.labCount.Text = "0";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(559, 143);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 8;
            this.btnCount.Text = "加1";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(703, 82);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(11, 12);
            this.lab2.TabIndex = 11;
            this.lab2.Text = "0";
            // 
            // btnCount2
            // 
            this.btnCount2.Location = new System.Drawing.Point(694, 144);
            this.btnCount2.Name = "btnCount2";
            this.btnCount2.Size = new System.Drawing.Size(75, 23);
            this.btnCount2.TabIndex = 10;
            this.btnCount2.Text = "減1";
            this.btnCount2.UseVisualStyleBackColor = true;
            this.btnCount2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.btnCount2);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBotton);
            this.Name = "FormButton";
            this.Text = "FormButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBotton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Button btnCount2;
    }
}
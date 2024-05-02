namespace N11310019_GUI_Class
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBotton = new System.Windows.Forms.Button();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnTextBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("細明體-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "多遊二甲";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.Font = new System.Drawing.Font("細明體-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(318, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "N11310019";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Plum;
            this.label3.Font = new System.Drawing.Font("細明體-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(582, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "蘇美芳";
            // 
            // btnBotton
            // 
            this.btnBotton.Location = new System.Drawing.Point(75, 192);
            this.btnBotton.Name = "btnBotton";
            this.btnBotton.Size = new System.Drawing.Size(101, 60);
            this.btnBotton.TabIndex = 4;
            this.btnBotton.Text = "按鈕";
            this.btnBotton.UseVisualStyleBackColor = true;
            this.btnBotton.Click += new System.EventHandler(this.btnBotton_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(75, 270);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(101, 50);
            this.btnBMI.TabIndex = 5;
            this.btnBMI.Text = "BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            // 
            // btnTextBox
            // 
            this.btnTextBox.Location = new System.Drawing.Point(263, 192);
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(101, 60);
            this.btnTextBox.TabIndex = 6;
            this.btnTextBox.Text = "輸入框";
            this.btnTextBox.UseVisualStyleBackColor = true;
            this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTextBox);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.btnBotton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "開始";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBotton;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button btnTextBox;
        private System.Windows.Forms.Button button1;
    }
}


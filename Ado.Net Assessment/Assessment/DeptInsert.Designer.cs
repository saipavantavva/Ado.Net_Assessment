namespace Assessment
{
    partial class DeptInsert
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Deptidtxt = new System.Windows.Forms.TextBox();
            this.Deptnametxt = new System.Windows.Forms.TextBox();
            this.Deptloctxt = new System.Windows.Forms.TextBox();
            this.Manaderidtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEPTNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DEPTLOCATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "MANAGERID";
            // 
            // Deptidtxt
            // 
            this.Deptidtxt.Location = new System.Drawing.Point(426, 106);
            this.Deptidtxt.Name = "Deptidtxt";
            this.Deptidtxt.Size = new System.Drawing.Size(100, 20);
            this.Deptidtxt.TabIndex = 4;
            // 
            // Deptnametxt
            // 
            this.Deptnametxt.Location = new System.Drawing.Point(426, 151);
            this.Deptnametxt.Name = "Deptnametxt";
            this.Deptnametxt.Size = new System.Drawing.Size(100, 20);
            this.Deptnametxt.TabIndex = 5;
            // 
            // Deptloctxt
            // 
            this.Deptloctxt.Location = new System.Drawing.Point(426, 200);
            this.Deptloctxt.Name = "Deptloctxt";
            this.Deptloctxt.Size = new System.Drawing.Size(100, 20);
            this.Deptloctxt.TabIndex = 6;
            // 
            // Manaderidtxt
            // 
            this.Manaderidtxt.Location = new System.Drawing.Point(426, 239);
            this.Manaderidtxt.Name = "Manaderidtxt";
            this.Manaderidtxt.Size = new System.Drawing.Size(100, 20);
            this.Manaderidtxt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "INSERT DEPARTMENT RECORD";
            // 
            // DeptInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Manaderidtxt);
            this.Controls.Add(this.Deptloctxt);
            this.Controls.Add(this.Deptnametxt);
            this.Controls.Add(this.Deptidtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeptInsert";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Deptidtxt;
        private System.Windows.Forms.TextBox Deptnametxt;
        private System.Windows.Forms.TextBox Deptloctxt;
        private System.Windows.Forms.TextBox Manaderidtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}


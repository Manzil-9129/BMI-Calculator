
namespace BMI_Calculator
{
    partial class BMI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Metricbutton = new System.Windows.Forms.RadioButton();
            this.Imperialbutton = new System.Windows.Forms.RadioButton();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Errorlabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Errorlabel2 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(22, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "WEIGHT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your BMI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // Metricbutton
            // 
            this.Metricbutton.AutoSize = true;
            this.Metricbutton.ForeColor = System.Drawing.Color.Yellow;
            this.Metricbutton.Location = new System.Drawing.Point(33, 12);
            this.Metricbutton.Name = "Metricbutton";
            this.Metricbutton.Size = new System.Drawing.Size(67, 21);
            this.Metricbutton.TabIndex = 6;
            this.Metricbutton.TabStop = true;
            this.Metricbutton.Text = "Metric";
            this.Metricbutton.UseVisualStyleBackColor = true;
            // 
            // Imperialbutton
            // 
            this.Imperialbutton.AutoSize = true;
            this.Imperialbutton.ForeColor = System.Drawing.Color.Yellow;
            this.Imperialbutton.Location = new System.Drawing.Point(194, 12);
            this.Imperialbutton.Name = "Imperialbutton";
            this.Imperialbutton.Size = new System.Drawing.Size(78, 21);
            this.Imperialbutton.TabIndex = 7;
            this.Imperialbutton.TabStop = true;
            this.Imperialbutton.Text = "Imperial";
            this.Imperialbutton.UseVisualStyleBackColor = true;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.BackColor = System.Drawing.Color.Yellow;
            this.Calculatebutton.ForeColor = System.Drawing.Color.Black;
            this.Calculatebutton.Location = new System.Drawing.Point(17, 226);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(117, 32);
            this.Calculatebutton.TabIndex = 8;
            this.Calculatebutton.Text = "CALCULATE";
            this.Calculatebutton.UseVisualStyleBackColor = false;
            this.Calculatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "RESULTS";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(166, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HEIGTH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "BMI SCALE";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(166, 402);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.Yellow;
            this.Resetbutton.ForeColor = System.Drawing.Color.Black;
            this.Resetbutton.Location = new System.Drawing.Point(172, 226);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(117, 32);
            this.Resetbutton.TabIndex = 12;
            this.Resetbutton.Text = "RESET";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // Errorlabel
            // 
            this.Errorlabel.AutoSize = true;
            this.Errorlabel.Location = new System.Drawing.Point(169, 119);
            this.Errorlabel.Name = "Errorlabel";
            this.Errorlabel.Size = new System.Drawing.Size(0, 17);
            this.Errorlabel.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Errorlabel2
            // 
            this.Errorlabel2.AutoSize = true;
            this.Errorlabel2.Location = new System.Drawing.Point(159, 200);
            this.Errorlabel2.Name = "Errorlabel2";
            this.Errorlabel2.Size = new System.Drawing.Size(0, 17);
            this.Errorlabel2.TabIndex = 14;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(302, 553);
            this.Controls.Add(this.Errorlabel2);
            this.Controls.Add(this.Errorlabel);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.Imperialbutton);
            this.Controls.Add(this.Metricbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMI_FormClosing);
            this.Load += new System.EventHandler(this.BMI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton Metricbutton;
        private System.Windows.Forms.RadioButton Imperialbutton;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Label Errorlabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Errorlabel2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
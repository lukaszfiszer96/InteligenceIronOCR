namespace InteligencjaOCR
{
    partial class Form1
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
            this.btn_readFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lb_timeAutoOCR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_timeAdvancedOCR = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_generateRaport = new System.Windows.Forms.Button();
            this.btn_closeApp = new System.Windows.Forms.Button();
            this.lb_wait = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_readFile
            // 
            this.btn_readFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_readFile.Location = new System.Drawing.Point(20, 448);
            this.btn_readFile.Name = "btn_readFile";
            this.btn_readFile.Size = new System.Drawing.Size(550, 50);
            this.btn_readFile.TabIndex = 0;
            this.btn_readFile.Text = "Wybierz obraz do OCR";
            this.btn_readFile.UseVisualStyleBackColor = true;
            this.btn_readFile.Click += new System.EventHandler(this.btn_readFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.lb_timeAutoOCR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 430);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkRed;
            this.richTextBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 352);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lb_timeAutoOCR
            // 
            this.lb_timeAutoOCR.AutoSize = true;
            this.lb_timeAutoOCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_timeAutoOCR.Location = new System.Drawing.Point(21, 398);
            this.lb_timeAutoOCR.Name = "lb_timeAutoOCR";
            this.lb_timeAutoOCR.Size = new System.Drawing.Size(145, 24);
            this.lb_timeAutoOCR.TabIndex = 5;
            this.lb_timeAutoOCR.Text = "Czas wykonania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(211, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "AutoOCR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.lb_timeAdvancedOCR);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(600, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 430);
            this.panel2.TabIndex = 2;
            // 
            // lb_timeAdvancedOCR
            // 
            this.lb_timeAdvancedOCR.AutoSize = true;
            this.lb_timeAdvancedOCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_timeAdvancedOCR.Location = new System.Drawing.Point(23, 398);
            this.lb_timeAdvancedOCR.Name = "lb_timeAdvancedOCR";
            this.lb_timeAdvancedOCR.Size = new System.Drawing.Size(145, 24);
            this.lb_timeAdvancedOCR.TabIndex = 6;
            this.lb_timeAdvancedOCR.Text = "Czas wykonania";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.DarkRed;
            this.richTextBox2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox2.Location = new System.Drawing.Point(26, 43);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(500, 352);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(184, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Advanced OCR";
            // 
            // btn_generateRaport
            // 
            this.btn_generateRaport.BackColor = System.Drawing.Color.Transparent;
            this.btn_generateRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_generateRaport.Location = new System.Drawing.Point(20, 448);
            this.btn_generateRaport.Name = "btn_generateRaport";
            this.btn_generateRaport.Size = new System.Drawing.Size(550, 52);
            this.btn_generateRaport.TabIndex = 3;
            this.btn_generateRaport.Text = "Generuj raport";
            this.btn_generateRaport.UseVisualStyleBackColor = false;
            this.btn_generateRaport.Visible = false;
            this.btn_generateRaport.Click += new System.EventHandler(this.btn_generateRaport_Click);
            // 
            // btn_closeApp
            // 
            this.btn_closeApp.BackColor = System.Drawing.Color.Transparent;
            this.btn_closeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_closeApp.Location = new System.Drawing.Point(600, 446);
            this.btn_closeApp.Name = "btn_closeApp";
            this.btn_closeApp.Size = new System.Drawing.Size(550, 52);
            this.btn_closeApp.TabIndex = 4;
            this.btn_closeApp.Text = "Wyłącz program";
            this.btn_closeApp.UseVisualStyleBackColor = false;
            this.btn_closeApp.Click += new System.EventHandler(this.btn_closeApp_Click);
            // 
            // lb_wait
            // 
            this.lb_wait.AutoSize = true;
            this.lb_wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_wait.Location = new System.Drawing.Point(99, 464);
            this.lb_wait.Name = "lb_wait";
            this.lb_wait.Size = new System.Drawing.Size(125, 20);
            this.lb_wait.TabIndex = 6;
            this.lb_wait.Text = "Proces trwa .... ";
            this.lb_wait.Visible = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1162, 511);
            this.Controls.Add(this.lb_wait);
            this.Controls.Add(this.btn_closeApp);
            this.Controls.Add(this.btn_generateRaport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_readFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_readFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btn_generateRaport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_timeAutoOCR;
        private System.Windows.Forms.Label lb_timeAdvancedOCR;
        private System.Windows.Forms.Button btn_closeApp;
        private System.Windows.Forms.Label lb_wait;
    }
}


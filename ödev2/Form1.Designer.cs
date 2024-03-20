namespace ödev2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblSonuc = new Label();
            textbox2 = new TextBox();
            textbox1 = new TextBox();
            btnBol = new Button();
            btnTopla = new Button();
            btnCarp = new Button();
            btnCikar = new Button();
            tabPage2 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textbox3 = new TextBox();
            button1 = new Button();
            tabPage3 = new TabPage();
            btn6 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            pb1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblSonuc);
            tabPage1.Controls.Add(textbox2);
            tabPage1.Controls.Add(textbox1);
            tabPage1.Controls.Add(btnBol);
            tabPage1.Controls.Add(btnTopla);
            tabPage1.Controls.Add(btnCarp);
            tabPage1.Controls.Add(btnCikar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(186, 151);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(47, 15);
            lblSonuc.TabIndex = 6;
            lblSonuc.Text = "SONUÇ";
            // 
            // textbox2
            // 
            textbox2.Location = new Point(227, 64);
            textbox2.Name = "textbox2";
            textbox2.Size = new Size(100, 23);
            textbox2.TabIndex = 5;
            // 
            // textbox1
            // 
            textbox1.Location = new Point(91, 63);
            textbox1.Name = "textbox1";
            textbox1.Size = new Size(100, 23);
            textbox1.TabIndex = 4;
            // 
            // btnBol
            // 
            btnBol.Location = new Point(587, 179);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(75, 39);
            btnBol.TabIndex = 3;
            btnBol.Text = "/";
            btnBol.UseVisualStyleBackColor = true;
            btnBol.Click += btnBol_Click;
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(445, 179);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(75, 39);
            btnTopla.TabIndex = 2;
            btnTopla.Text = "+";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // btnCarp
            // 
            btnCarp.Location = new Point(587, 64);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(75, 39);
            btnCarp.TabIndex = 1;
            btnCarp.Text = "*";
            btnCarp.UseVisualStyleBackColor = true;
            btnCarp.Click += btnCarp_Click;
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(445, 62);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(75, 39);
            btnCikar.TabIndex = 0;
            btnCikar.Text = "-";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textbox3);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(561, 145);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 54);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(200, 3);
            label4.Name = "label4";
            label4.Size = new Size(349, 21);
            label4.TabIndex = 7;
            label4.Text = "DAİRENİN ALANI VE ÇEVRESİNİ HESAPLAMA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 59);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Yarı Çap:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 145);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Alan:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 54);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Çevre:";
            // 
            // textbox3
            // 
            textbox3.Location = new Point(134, 54);
            textbox3.Name = "textbox3";
            textbox3.Size = new Size(100, 23);
            textbox3.TabIndex = 1;
            textbox3.TextChanged += textbox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(159, 141);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn6);
            tabPage3.Controls.Add(btn4);
            tabPage3.Controls.Add(btn3);
            tabPage3.Controls.Add(btn2);
            tabPage3.Controls.Add(btn1);
            tabPage3.Controls.Add(pb1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(128, 204);
            btn6.Name = "btn6";
            btn6.Size = new Size(95, 35);
            btn6.TabIndex = 5;
            btn6.Text = "Rastgele";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(406, 215);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 35);
            btn4.TabIndex = 4;
            btn4.Text = "Yukarı";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(406, 165);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 35);
            btn3.TabIndex = 3;
            btn3.Text = "Aşağı";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(406, 115);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 35);
            btn2.TabIndex = 2;
            btn2.Text = "Büyüt";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(406, 63);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 35);
            btn1.TabIndex = 1;
            btn1.Text = "Küçült";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // pb1
            // 
            pb1.Image = (Image)resources.GetObject("pb1.Image");
            pb1.Location = new Point(128, 39);
            pb1.Name = "pb1";
            pb1.Size = new Size(95, 96);
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb1.TabIndex = 0;
            pb1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblSonuc;
        private TextBox textbox2;
        private TextBox textbox1;
        private Button btnBol;
        private Button btnTopla;
        private Button btnCarp;
        private Button btnCikar;
        private TabPage tabPage3;
        private TextBox textbox3;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private PictureBox pb1;
        private Button btn6;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
    }
}

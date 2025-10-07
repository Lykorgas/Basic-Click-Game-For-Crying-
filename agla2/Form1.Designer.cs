namespace agla2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            gözyaşılabel = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            otoağlaTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(289, 98);
            button1.Name = "button1";
            button1.Size = new Size(532, 463);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += button1_MouseDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(345, 49);
            label1.Name = "label1";
            label1.Size = new Size(428, 46);
            label1.TabIndex = 1;
            label1.Text = "AĞLAMAK İÇİN TIKLAYIN";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(289, 564);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 2;
            label2.Text = "Gözyaşı sayısı:";
            // 
            // gözyaşılabel
            // 
            gözyaşılabel.Anchor = AnchorStyles.None;
            gözyaşılabel.BackColor = Color.Transparent;
            gözyaşılabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gözyaşılabel.ForeColor = Color.White;
            gözyaşılabel.Location = new Point(453, 564);
            gözyaşılabel.Name = "gözyaşılabel";
            gözyaşılabel.Size = new Size(368, 31);
            gözyaşılabel.TabIndex = 3;
            gözyaşılabel.Text = "0";
            gözyaşılabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(248, 68);
            button2.TabIndex = 4;
            button2.Text = "Ağlama gücünü arttır\r\n(50 gözyaşı)";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(5, 431);
            button3.Name = "button3";
            button3.Size = new Size(112, 29);
            button3.TabIndex = 5;
            button3.Text = "Ses AÇIK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.DarkSlateGray;
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 68);
            button4.Name = "button4";
            button4.Size = new Size(248, 68);
            button4.TabIndex = 6;
            button4.Text = "OTO-AĞLA v1.0\r\n(300 gözyaşı)";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // otoağlaTimer
            // 
            otoağlaTimer.Interval = 1000;
            otoağlaTimer.Tick += otoağlaTimer_Tick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(30, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 463);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1093, 655);
            Controls.Add(panel1);
            Controls.Add(gözyaşılabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Quick Ağla !!";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label gözyaşılabel;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer otoağlaTimer;
        private Panel panel1;
    }
}

namespace _017_WF_Basics
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
            TextLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            yes = new Button();
            no = new Button();
            LabelCount = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.BackColor = Color.Red;
            TextLabel.Font = new Font("Swis721 BlkEx BT", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextLabel.Location = new Point(100, 64);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(110, 32);
            TextLabel.TabIndex = 0;
            TextLabel.Text = "Hello";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // yes
            // 
            yes.BackColor = Color.Lime;
            yes.Location = new Point(237, 247);
            yes.Name = "yes";
            yes.Size = new Size(112, 46);
            yes.TabIndex = 1;
            yes.Text = "Start";
            yes.UseVisualStyleBackColor = false;
            yes.Click += yes_Click;
            // 
            // no
            // 
            no.BackColor = Color.Red;
            no.Location = new Point(392, 247);
            no.Name = "no";
            no.Size = new Size(109, 46);
            no.TabIndex = 2;
            no.Text = "Stop";
            no.UseVisualStyleBackColor = false;
            no.Click += no_Click;
            no.MouseMove += no_MouseMove;
            // 
            // LabelCount
            // 
            LabelCount.AutoSize = true;
            LabelCount.BackColor = Color.FromArgb(255, 192, 128);
            LabelCount.Font = new Font("Segoe UI", 20F);
            LabelCount.Location = new Point(453, 81);
            LabelCount.Name = "LabelCount";
            LabelCount.Size = new Size(32, 37);
            LabelCount.TabIndex = 3;
            LabelCount.Text = "0";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(679, 25);
            button3.Name = "button3";
            button3.Size = new Size(109, 46);
            button3.TabIndex = 4;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 489);
            Controls.Add(button3);
            Controls.Add(LabelCount);
            Controls.Add(no);
            Controls.Add(yes);
            Controls.Add(TextLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My window";
            MouseClick += Form1_MouseClick;
            MouseDoubleClick += Form1_MouseDoubleClick;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextLabel;
        private System.Windows.Forms.Timer timer1;
        private Button yes;
        private Button no;
        private Label LabelCount;
        private Button button3;
    }
}

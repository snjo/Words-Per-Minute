namespace WordsPerMinute
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
            textBox1 = new TextBox();
            buttonReset = new Button();
            labelResult = new Label();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            checkBox1 = new CheckBox();
            labelCharacters = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 136);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += handleKeys;
            textBox1.KeyUp += updateResultKeyPress;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonReset.Location = new Point(12, 154);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Reset (ESC)";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += clickReset;
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResult.Location = new Point(93, 155);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(71, 21);
            labelResult.TabIndex = 2;
            labelResult.Text = "WPM: ...";
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.ForeColor = SystemColors.GrayText;
            labelTime.Location = new Point(187, 155);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(96, 21);
            labelTime.TabIndex = 3;
            labelTime.Text = "Time: 00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += updateResultTimer;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(431, 159);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Password (black dots)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // labelCharacters
            // 
            labelCharacters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCharacters.AutoSize = true;
            labelCharacters.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCharacters.ForeColor = SystemColors.GrayText;
            labelCharacters.Location = new Point(289, 155);
            labelCharacters.Name = "labelCharacters";
            labelCharacters.Size = new Size(107, 21);
            labelCharacters.TabIndex = 5;
            labelCharacters.Text = "Characters: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 189);
            Controls.Add(labelCharacters);
            Controls.Add(checkBox1);
            Controls.Add(labelTime);
            Controls.Add(labelResult);
            Controls.Add(buttonReset);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Words Per Minute";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonReset;
        private Label labelResult;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBox1;
        private Label labelCharacters;
    }
}
namespace lab2
{
    partial class MainForm
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
            panel1 = new Panel();
            button1 = new Button();
            buttonFill = new RadioButton();
            radioButton1 = new RadioButton();
            CDA_THICC_button = new RadioButton();
            fill_color_button = new Button();
            color_button = new Button();
            use_button = new Button();
            Fill_radio = new RadioButton();
            Clear_button = new Button();
            CDA_radio = new RadioButton();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonFill);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(CDA_THICC_button);
            panel1.Controls.Add(fill_color_button);
            panel1.Controls.Add(color_button);
            panel1.Controls.Add(use_button);
            panel1.Controls.Add(Fill_radio);
            panel1.Controls.Add(Clear_button);
            panel1.Controls.Add(CDA_radio);
            panel1.Location = new Point(538, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 426);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(15, 328);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 9;
            button1.Text = "многоугольник";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // buttonFill
            // 
            buttonFill.AutoSize = true;
            buttonFill.Location = new Point(32, 149);
            buttonFill.Name = "buttonFill";
            buttonFill.Size = new Size(136, 24);
            buttonFill.TabIndex = 8;
            buttonFill.TabStop = true;
            buttonFill.Text = "закраска мн-ка";
            buttonFill.UseVisualStyleBackColor = true;
            buttonFill.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(33, 117);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(118, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Окружность ";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // CDA_THICC_button
            // 
            CDA_THICC_button.AutoSize = true;
            CDA_THICC_button.Location = new Point(33, 87);
            CDA_THICC_button.Name = "CDA_THICC_button";
            CDA_THICC_button.Size = new Size(208, 24);
            CDA_THICC_button.TabIndex = 6;
            CDA_THICC_button.TabStop = true;
            CDA_THICC_button.Text = "Обычный Цда(ТОЛСТЫЙ)";
            CDA_THICC_button.UseVisualStyleBackColor = true;
            // 
            // fill_color_button
            // 
            fill_color_button.Location = new Point(134, 226);
            fill_color_button.Name = "fill_color_button";
            fill_color_button.Size = new Size(94, 51);
            fill_color_button.TabIndex = 5;
            fill_color_button.Text = "Цвет заливки";
            fill_color_button.UseVisualStyleBackColor = true;
            fill_color_button.Click += fill_color_button_Click;
            // 
            // color_button
            // 
            color_button.Location = new Point(25, 226);
            color_button.Name = "color_button";
            color_button.Size = new Size(94, 51);
            color_button.TabIndex = 4;
            color_button.Text = "Цвет Линии";
            color_button.UseVisualStyleBackColor = true;
            color_button.Click += color_button_Click;
            // 
            // use_button
            // 
            use_button.Location = new Point(15, 283);
            use_button.Name = "use_button";
            use_button.Size = new Size(113, 29);
            use_button.TabIndex = 3;
            use_button.Text = "Применить";
            use_button.UseVisualStyleBackColor = true;
            use_button.Click += use_button_Click;
            // 
            // Fill_radio
            // 
            Fill_radio.AutoSize = true;
            Fill_radio.Location = new Point(33, 57);
            Fill_radio.Name = "Fill_radio";
            Fill_radio.Size = new Size(86, 24);
            Fill_radio.TabIndex = 2;
            Fill_radio.TabStop = true;
            Fill_radio.Text = "Заливка";
            Fill_radio.UseVisualStyleBackColor = true;
            // 
            // Clear_button
            // 
            Clear_button.Location = new Point(134, 283);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(94, 29);
            Clear_button.TabIndex = 1;
            Clear_button.Text = "Отчистить";
            Clear_button.UseVisualStyleBackColor = true;
            Clear_button.Click += Clear_button_Click;
            // 
            // CDA_radio
            // 
            CDA_radio.AutoSize = true;
            CDA_radio.Location = new Point(33, 27);
            CDA_radio.Name = "CDA_radio";
            CDA_radio.Size = new Size(129, 24);
            CDA_radio.TabIndex = 0;
            CDA_radio.TabStop = true;
            CDA_radio.Text = "Обычный Цда";
            CDA_radio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 426);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 447);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            Paint += MainForm_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Clear_button;
        private RadioButton CDA_radio;
        private PictureBox pictureBox1;
        private RadioButton Fill_radio;
        private ColorDialog colorDialog1;
        private Button use_button;
        private Button color_button;
        private Button fill_color_button;
        private RadioButton CDA_THICC_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton radioButton1;
        private RadioButton buttonFill;
        private Button button1;
    }
}

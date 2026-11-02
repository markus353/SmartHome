namespace SmartHome
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
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(239, 19);
            label1.TabIndex = 0;
            label1.Text = "Майстер налаштування Smart Home";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 74);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 1;
            label2.Text = "Введіть ім'я замовника:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.White;
            textBoxName.ForeColor = Color.Black;
            textBoxName.Location = new Point(35, 92);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(208, 23);
            textBoxName.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.ForeColor = Color.Black;
            buttonStart.Location = new Point(35, 141);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(208, 44);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Почати налаштування";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(284, 234);
            Controls.Add(buttonStart);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "В";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private Button buttonStart;
    }
}
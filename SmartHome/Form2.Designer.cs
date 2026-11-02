namespace SmartHome
{
    partial class Form2
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
            labelGreeting = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            labelRooms = new Label();
            comboBoxRooms = new ComboBox();
            buttonCalculate = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // labelGreeting
            // 
            labelGreeting.AutoSize = true;
            labelGreeting.ForeColor = Color.Black;
            labelGreeting.Location = new Point(12, 19);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(72, 15);
            labelGreeting.TabIndex = 0;
            labelGreeting.Text = "Проект для:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(130, 122);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип контролера";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(10, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(90, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Raspberry Pi";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(10, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "ESP8266";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(10, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Arduino Uno";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(148, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(190, 122);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Додаткові компоненти";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 47);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(159, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Сервопривід для дверей";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 97);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(143, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Матрична клавіатура";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 72);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(97, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "LCD дисплей";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(179, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Датчик температури TMP36";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelRooms
            // 
            labelRooms.AutoSize = true;
            labelRooms.ForeColor = Color.Black;
            labelRooms.Location = new Point(12, 185);
            labelRooms.Name = "labelRooms";
            labelRooms.Size = new Size(98, 15);
            labelRooms.TabIndex = 3;
            labelRooms.Text = "Кількість кімнат:";
            // 
            // comboBoxRooms
            // 
            comboBoxRooms.BackColor = Color.White;
            comboBoxRooms.ForeColor = Color.Black;
            comboBoxRooms.FormattingEnabled = true;
            comboBoxRooms.Location = new Point(116, 182);
            comboBoxRooms.Name = "comboBoxRooms";
            comboBoxRooms.Size = new Size(222, 23);
            comboBoxRooms.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            buttonCalculate.ForeColor = Color.Black;
            buttonCalculate.Location = new Point(12, 220);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(326, 35);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Розрахувати кошторис";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 270);
            Controls.Add(buttonCalculate);
            Controls.Add(comboBoxRooms);
            Controls.Add(labelRooms);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelGreeting);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGreeting;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private Label labelRooms;
        private ComboBox comboBoxRooms;
        private Button buttonCalculate;
    }
}
namespace SmartHome
{
    partial class Form3
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
            labelTitle = new Label();
            listBoxEquipment = new ListBox();
            labelTotalCost = new Label();
            buttonNewOrder = new Button();
            buttonExit = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 10F);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(199, 19);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Фінальний кошторис проекту:";
            // 
            // listBoxEquipment
            // 
            listBoxEquipment.BackColor = Color.White;
            listBoxEquipment.ForeColor = Color.Black;
            listBoxEquipment.FormattingEnabled = true;
            listBoxEquipment.Location = new Point(12, 67);
            listBoxEquipment.Name = "listBoxEquipment";
            listBoxEquipment.Size = new Size(260, 109);
            listBoxEquipment.TabIndex = 1;
            // 
            // labelTotalCost
            // 
            labelTotalCost.AutoSize = true;
            labelTotalCost.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelTotalCost.ForeColor = Color.Black;
            labelTotalCost.Location = new Point(12, 189);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(253, 25);
            labelTotalCost.TabIndex = 2;
            labelTotalCost.Text = "Разом до оплати: XXXX грн";
            // 
            // buttonNewOrder
            // 
            buttonNewOrder.BackColor = Color.Transparent;
            buttonNewOrder.ForeColor = Color.Black;
            buttonNewOrder.Location = new Point(12, 226);
            buttonNewOrder.Name = "buttonNewOrder";
            buttonNewOrder.Size = new Size(179, 23);
            buttonNewOrder.TabIndex = 3;
            buttonNewOrder.Text = "Оформити нове замовлення";
            buttonNewOrder.UseVisualStyleBackColor = false;
            buttonNewOrder.Click += new EventHandler(buttonNewOrder_Click); // Підключено подію повернення на 1 форму
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.ForeColor = Color.Black;
            buttonExit.Location = new Point(197, 226);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Вийти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += new EventHandler(buttonExit_Click); // Підключено подію виходу з програми
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(138, 19);
            label3.TabIndex = 5;
            label3.Text = "Обране обладнання";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(284, 261);
            Controls.Add(label3);
            Controls.Add(buttonExit);
            Controls.Add(buttonNewOrder);
            Controls.Add(labelTotalCost);
            Controls.Add(listBoxEquipment);
            Controls.Add(labelTitle);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private ListBox listBoxEquipment;
        private Label labelTotalCost;
        private Button buttonNewOrder;
        private Button buttonExit;
        private Label label3;
    }
}
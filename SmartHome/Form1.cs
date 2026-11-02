using System;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Перевірка, чи введено ім'я замовника[cite: 1]
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Будь ласка, введіть ім'я замовника!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Передаємо ім'я у другу форму, відкриваємо її та ховаємо поточну[cite: 1, 2]
            Form2 form2 = new Form2(textBoxName.Text);
            form2.Show();
            this.Hide();
        }
    }
}
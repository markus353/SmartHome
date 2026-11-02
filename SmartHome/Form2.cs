using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class Form2 : Form
    {
        private string customerName;

        public Form2(string name)
        {
            InitializeComponent();
            customerName = name;
            labelGreeting.Text = "Проект для: " + customerName;
            groupBox2.Text = "Додаткові компоненти";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Створюємо список, куди додаватимемо кожен компонент окремо
            List<string> equipmentList = new List<string>();
            decimal totalCost = 0;

            // 1. Перевіряємо контролер
            if (radioButton1.Checked)
            {
                equipmentList.Add($"{radioButton1.Text} - 300 грн");
                totalCost += 300;
            }
            else if (radioButton2.Checked)
            {
                equipmentList.Add($"{radioButton2.Text} - 200 грн");
                totalCost += 200;
            }
            else if (radioButton3.Checked)
            {
                equipmentList.Add($"{radioButton3.Text} - 1200 грн");
                totalCost += 1200;
            }

            // 2. Перевіряємо додаткові компоненти (CheckBox)
            if (checkBox1.Checked)
            {
                equipmentList.Add($"{checkBox1.Text} - 150 грн");
                totalCost += 150;
            }
            if (checkBox2.Checked)
            {
                equipmentList.Add($"{checkBox2.Text} - 250 грн");
                totalCost += 250;
            }
            if (checkBox3.Checked)
            {
                equipmentList.Add($"{checkBox3.Text} - 100 грн");
                totalCost += 100;
            }
            if (checkBox4.Checked)
            {
                equipmentList.Add($"{checkBox4.Text} - 400 грн");
                totalCost += 400;
            }

            // 3. Якщо нічого не обрано, додаємо базовий варіант
            if (equipmentList.Count == 0)
            {
                equipmentList.Add("Базова комплектація - 500 грн");
                totalCost = 500;
            }

            // Передаємо список на третю форму
            Form3 form3 = new Form3(customerName, equipmentList, totalCost);
            form3.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
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
    public partial class Form3 : Form
    {
        private string customerName;
        private List<string> equipmentList;
        private decimal totalCost;

        // Конструктор приймає список List<string> від другої форми
        public Form3(string name, List<string> equipment, decimal cost)
        {
            InitializeComponent();
            customerName = name;
            equipmentList = equipment;
            totalCost = cost;

            // Виводимо ім'я замовника у заголовок
            labelTitle.Text = "Фінальний кошторис проекту: " + customerName;

            // Очищуємо і додаємо кожен елемент окремим рядком
            listBoxEquipment.Items.Clear();
            foreach (string item in equipmentList)
            {
                listBoxEquipment.Items.Add(item);
            }

            // Виводимо загальну суму до оплати
            labelTotalCost.Text = $"Разом до оплати: {totalCost} грн";
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            // Кнопка «Оформити нове замовлення» — повертає на першу форму
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Кнопка «Вийти» — повністю закриває додаток
            Application.Exit();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Повністю закриває програму при закритті вікна хрестиком
            Application.Exit();
        }
    }
}
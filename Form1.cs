using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YalymovPV_01_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRemoveAt_Click(object sender, EventArgs e) //Дополнительня функция :)
        {
            if(listBoxSports.SelectedIndex!=-1)
            {
                listBoxSports.Items.RemoveAt(listBoxSports.SelectedIndex);
            }else
            {
                MessageBox.Show("Выберите объект для удаления");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxHeight.Text==""||textBoxWeight.Text==""||textBoxYear.Text==""||comboBoxTarget.SelectedIndex==-1)
                {
                    MessageBox.Show("Заполните все поля");
                }

                SportPeople man = new SportPeople();

                man.Weight = int.Parse(textBoxWeight.Text); //Накладываем данные на шаблон класса
                man.Height = int.Parse(textBoxHeight.Text);
                man.Year = int.Parse(textBoxYear.Text);
                man.P = comboBoxTarget.Text.ToString();

                double qp = man.CalculateQp();

                string result = $"Рост {man.Height}, Вес: {man.Weight}, Всего лет: {man.Year}, Цель {man.P} ->QP = {qp:F2}"; //Строчка вывода

                listBoxSports.Items.Add(result);
             
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

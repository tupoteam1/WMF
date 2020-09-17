using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm1 = new Form2();
            newForm1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wMF300DataSet.Identefication". При необходимости она может быть перемещена или удалена.
            comboBox1.Items.Add("Физическое_Лицо");
            comboBox1.Items.Add("Личный_Состав");
            comboBox1.Items.Add("Удостоверение_Служащего");
            comboBox1.Items.Add("Профессия");
            comboBox1.Items.Add("Штаб");
            comboBox1.Items.Add("Военная_База");
            comboBox1.Items.Add("Военная_Часть");
            comboBox1.Items.Add("Военная_Техника");
            comboBox1.Items.Add("Модель_Техники");
            comboBox1.Items.Add("Название_Техники"); 
        }

        private void identeficationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.identeficationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wMF300DataSet);

        }
    }
}

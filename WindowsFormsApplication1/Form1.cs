using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SqlConnection SqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataTable table = null;

        public Form1()
        {
            InitializeComponent();
        }
        // Открытие второй формы поверх первой
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm1 = new Form2();
            newForm1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //строка подключения к базе данных
            SqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ZyxoR\source\repos\WindowsFormsApplication1\WindowsFormsApplication1\WMF300.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlConnection.Open();
            //все строки их таблицы Physcial_Person
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Physical_Person", SqlConnection);
            table = new DataTable();
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wMF300DataSet.Identefication". При необходимости она может быть перемещена или удалена.
            this.identeficationTableAdapter.Fill(this.wMF300DataSet.Identefication);
            //добавлены элементы для combobox
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                table.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Physical_Person", SqlConnection);

                sqlDataAdapter.Fill(table);
                dataGridView1.DataSource = table;



            }
            if (comboBox1.SelectedIndex == 1)
            {
                table.Clear();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Personnel", SqlConnection);

                sqlDataAdapter.Fill(table);
                dataGridView1.DataSource = table;

            }
        }

        }
}

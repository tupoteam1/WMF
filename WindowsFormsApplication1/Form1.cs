using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
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

            //запрет на добавление и удаление строк
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            //выделение всей строки 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wMF300DataSet.Identefication". При необходимости она может быть перемещена или удалена.
            this.identeficationTableAdapter.Fill(this.wMF300DataSet.Identefication);
            //добавлены элементы для combobox
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
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Physical_Person", SqlConnection);
                sqlDataAdapter.Fill(table);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Personnel", SqlConnection);
                sqlDataAdapter.Fill(table);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Identefication", SqlConnection);
                sqlDataAdapter.Fill(table);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Profession", SqlConnection);
                sqlDataAdapter.Fill(table);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Staff", SqlConnection);
                sqlDataAdapter.Fill(table);
            }
            if (comboBox1.SelectedIndex == 5)
            {
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Military_Base", SqlConnection);
                sqlDataAdapter.Fill(table);
            }
            if (comboBox1.SelectedIndex == 6)
            {
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Military_Unit", SqlConnection);
                sqlDataAdapter.Fill(table);
            }
            if (comboBox1.SelectedIndex == 7)
            {
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Military_Tech", SqlConnection);
                sqlDataAdapter.Fill(table);
            }
            if (comboBox1.SelectedIndex == 8)
            {
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Tech_Model", SqlConnection);
                sqlDataAdapter.Fill(table);
            }
            if (comboBox1.SelectedIndex == 9)
            {
                table.Columns.Clear();
                table.Rows.Clear();

                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Technic_Name", SqlConnection);
                sqlDataAdapter.Fill(table);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table.Rows.Add();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

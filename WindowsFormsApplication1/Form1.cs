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
using WindowsFormsApplication1.WMF300DataSetTableAdapters;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SqlConnection SqlConnection = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private SqlCommandBuilder builder = null;

        private DataSet DataSet = null;

        string tname = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //строка подключения к базе данных
            SqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ZyxoR\source\repos\WindowsFormsApplication1\WindowsFormsApplication1\WMF300.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlConnection.Open();

            //запрет на добавление и удаление строк
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            //выделение всей строки 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wMF300DataSet.Identefication". При необходимости она может быть перемещена или удалена.
            this.identeficationTableAdapter.Fill(this.wMF300DataSet.Identefication);
            //добавлены элементы для combobox
            tname = "Physical_Person";
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                tname = "Physical_Person";
                LoadData();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                tname = "Personnel";
                LoadData();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                tname = "Identefication";
                LoadData();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                tname = "Profession";
                LoadData();

            }
            if (comboBox1.SelectedIndex == 4)
            {
                tname = "Staff";
                LoadData();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                tname = "Military_Base";
                LoadData();
            }
            if (comboBox1.SelectedIndex == 6)
            {
                tname = "Military_Unit";
                LoadData();
            }
            if (comboBox1.SelectedIndex == 7)
            {
                tname = "Military_Tech";
                LoadData();
            }
            if (comboBox1.SelectedIndex == 8)
            {
                //sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Tech_Model", SqlConnection);
                //sqlDataAdapter.Fill(table);
                tname = "Tech_Model";
                LoadData();
            }
            if (comboBox1.SelectedIndex == 9)
            {
                //DataSet.Columns.Clear();
                //DataSet.Rows.Clear();

                tname = "Technic_Name";
                LoadData();
            }

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Form2 newForm1 = new Form2();
            newForm1.Show();
        }

        private void LoadData()
        {
            try
            {
               sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {tname}", SqlConnection);

                builder = new SqlCommandBuilder(sqlDataAdapter);

                builder.GetInsertCommand();
                builder.GetUpdateCommand();
                builder.GetDeleteCommand();

                DataSet = new DataSet();

                sqlDataAdapter.Fill(DataSet, tname);

                dataGridView1.DataSource = DataSet.Tables[tname];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sqlDataAdapter.Update(DataSet, tname);
            DataSet.Tables[tname].Rows.Add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlDataAdapter.Update(DataSet, tname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

    }
}

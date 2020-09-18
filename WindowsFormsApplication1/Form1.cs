using com.sun.xml.@internal.bind.v2.model.core;
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
        DataSet dataset;
      
        private SqlConnection SqlConnection = null;

        SqlDataAdapter sqlDataAdapter;

        SqlCommandBuilder commandBuilder;

        private DataTable table = null;

        DataFromBase dataFromBase = new DataFromBase();

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
            this.personnelTableAdapter.Fill(this.wMF300DataSet.Personnel); 
            SqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TrueXz\Desktop\jjj\WMF300.mdf;Integrated Security=True;Connect Timeout=30;");
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Physical_Person", SqlConnection);
            table = new DataTable();
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false; 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.identeficationTableAdapter.Fill(this.wMF300DataSet.Identefication);
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


      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataRow row = dataset.Tables[0].NewRow();
            dataset.Tables[0].Rows.Add(row);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\TrueXz\Desktop\ДЩЫВ\WindowsFormsApplication1\WindowsFormsApplication1\WMF300.mdf; Integrated Security = True; Connect Timeout = 30;"))
            {
                
            }
        }
    }

    class DataFromBase
    {
    }
}

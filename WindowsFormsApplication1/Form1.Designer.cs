namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wMF300DataSet = new WindowsFormsApplication1.WMF300DataSet();
            this.identeficationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.identeficationTableAdapter = new WindowsFormsApplication1.WMF300DataSetTableAdapters.IdenteficationTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.WMF300DataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.wMF300DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.identeficationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Авторы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Физическое_лицо";
            // 
            // wMF300DataSet
            // 
            this.wMF300DataSet.DataSetName = "WMF300DataSet";
            this.wMF300DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // identeficationBindingSource
            // 
            this.identeficationBindingSource.DataMember = "Identefication";
            this.identeficationBindingSource.DataSource = this.wMF300DataSet;
            // 
            // identeficationTableAdapter
            // 
            this.identeficationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IdenteficationTableAdapter = this.identeficationTableAdapter;
            this.tableAdapterManager.Military_BaseTableAdapter = null;
            this.tableAdapterManager.Military_TechTableAdapter = null;
            this.tableAdapterManager.Military_UnitTableAdapter = null;
            this.tableAdapterManager.PersonnelTableAdapter = null;
            this.tableAdapterManager.Physical_PersonTableAdapter = null;
            this.tableAdapterManager.ProfessionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Tech_ModelTableAdapter = null;
            this.tableAdapterManager.Technic_NameTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.WMF300DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 295);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(863, 353);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wMF300DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.identeficationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private WMF300DataSet wMF300DataSet;
        private System.Windows.Forms.BindingSource identeficationBindingSource;
        private WMF300DataSetTableAdapters.IdenteficationTableAdapter identeficationTableAdapter;
        private WMF300DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


namespace AZSCommand
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aZSCommandDataSet = new AZSCommand.AZSCommandDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваПСDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поточнийОбємПаливаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видПаливаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваПСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видПаливаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поточнийОбємПаливаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelStationTableAdapter = new AZSCommand.AZSCommandDataSetTableAdapters.FuelStationTableAdapter();
            this.назваПСDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видПаливаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поточнийОбємПаливаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.максОбємПаливаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new AZSCommand.AZSCommandDataSetTableAdapters.CarsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаАвтомобіляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номернийЗнакDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZSCommandDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(18, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати новий автомобіль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(172, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Додати нову заправну станцію";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(351, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Поповнення палива";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(475, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Оформити клієнта";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.назваПСDataGridViewTextBoxColumn2,
            this.видПаливаDataGridViewTextBoxColumn2,
            this.поточнийОбємПаливаDataGridViewTextBoxColumn2,
            this.максОбємПаливаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fuelStationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(446, 349);
            this.dataGridView1.TabIndex = 4;
            // 
            // aZSCommandDataSet
            // 
            this.aZSCommandDataSet.DataSetName = "AZSCommandDataSet";
            this.aZSCommandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.маркаАвтомобіляDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.номернийЗнакDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.carsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(480, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(444, 349);
            this.dataGridView2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вивести інформацію по паливній станції :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(602, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Інформація по автомобілям";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(341, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(591, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Переглянути журнал змін";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // назваПСDataGridViewTextBoxColumn1
            // 
            this.назваПСDataGridViewTextBoxColumn1.DataPropertyName = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn1.HeaderText = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn1.Name = "назваПСDataGridViewTextBoxColumn1";
            // 
            // поточнийОбємПаливаDataGridViewTextBoxColumn1
            // 
            this.поточнийОбємПаливаDataGridViewTextBoxColumn1.DataPropertyName = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn1.HeaderText = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn1.Name = "поточнийОбємПаливаDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Макс_ об\'єм палива";
            this.dataGridViewTextBoxColumn1.HeaderText = "Макс_ об\'єм палива";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // видПаливаDataGridViewTextBoxColumn1
            // 
            this.видПаливаDataGridViewTextBoxColumn1.DataPropertyName = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn1.HeaderText = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn1.Name = "видПаливаDataGridViewTextBoxColumn1";
            // 
            // назваПСDataGridViewTextBoxColumn
            // 
            this.назваПСDataGridViewTextBoxColumn.DataPropertyName = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn.HeaderText = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn.Name = "назваПСDataGridViewTextBoxColumn";
            // 
            // видПаливаDataGridViewTextBoxColumn
            // 
            this.видПаливаDataGridViewTextBoxColumn.DataPropertyName = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn.HeaderText = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn.Name = "видПаливаDataGridViewTextBoxColumn";
            // 
            // поточнийОбємПаливаDataGridViewTextBoxColumn
            // 
            this.поточнийОбємПаливаDataGridViewTextBoxColumn.DataPropertyName = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn.HeaderText = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn.Name = "поточнийОбємПаливаDataGridViewTextBoxColumn";
            // 
            // fuelStationBindingSource
            // 
            this.fuelStationBindingSource.DataMember = "FuelStation";
            this.fuelStationBindingSource.DataSource = this.aZSCommandDataSet;
            // 
            // fuelStationTableAdapter
            // 
            this.fuelStationTableAdapter.ClearBeforeFill = true;
            // 
            // назваПСDataGridViewTextBoxColumn2
            // 
            this.назваПСDataGridViewTextBoxColumn2.DataPropertyName = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn2.HeaderText = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn2.Name = "назваПСDataGridViewTextBoxColumn2";
            this.назваПСDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // видПаливаDataGridViewTextBoxColumn2
            // 
            this.видПаливаDataGridViewTextBoxColumn2.DataPropertyName = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn2.HeaderText = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn2.Name = "видПаливаDataGridViewTextBoxColumn2";
            this.видПаливаDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // поточнийОбємПаливаDataGridViewTextBoxColumn2
            // 
            this.поточнийОбємПаливаDataGridViewTextBoxColumn2.DataPropertyName = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn2.HeaderText = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn2.Name = "поточнийОбємПаливаDataGridViewTextBoxColumn2";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // максОбємПаливаDataGridViewTextBoxColumn
            // 
            this.максОбємПаливаDataGridViewTextBoxColumn.DataPropertyName = "Макс. об\'єм палива";
            this.максОбємПаливаDataGridViewTextBoxColumn.HeaderText = "Макс. об\'єм палива";
            this.максОбємПаливаDataGridViewTextBoxColumn.Name = "максОбємПаливаDataGridViewTextBoxColumn";
            this.максОбємПаливаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.aZSCommandDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // маркаАвтомобіляDataGridViewTextBoxColumn
            // 
            this.маркаАвтомобіляDataGridViewTextBoxColumn.DataPropertyName = "Марка автомобіля";
            this.маркаАвтомобіляDataGridViewTextBoxColumn.HeaderText = "Марка автомобіля";
            this.маркаАвтомобіляDataGridViewTextBoxColumn.Name = "маркаАвтомобіляDataGridViewTextBoxColumn";
            this.маркаАвтомобіляDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            this.модельDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номернийЗнакDataGridViewTextBoxColumn
            // 
            this.номернийЗнакDataGridViewTextBoxColumn.DataPropertyName = "Номерний знак";
            this.номернийЗнакDataGridViewTextBoxColumn.HeaderText = "Номерний знак";
            this.номернийЗнакDataGridViewTextBoxColumn.Name = "номернийЗнакDataGridViewTextBoxColumn";
            this.номернийЗнакDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 426);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Головне вікно";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZSCommandDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        internal AZSCommandDataSet aZSCommandDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваПСDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn поточнийОбємПаливаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn видПаливаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваПСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видПаливаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поточнийОбємПаливаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fuelStationBindingSource;
        internal AZSCommandDataSetTableAdapters.FuelStationTableAdapter fuelStationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваПСDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn видПаливаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn поточнийОбємПаливаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn максОбємПаливаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carsBindingSource;
        internal AZSCommandDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаАвтомобіляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номернийЗнакDataGridViewTextBoxColumn;
    }
}


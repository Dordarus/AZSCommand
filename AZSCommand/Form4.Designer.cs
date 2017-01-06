namespace AZSCommand
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aZSCommandDataSet = new AZSCommand.AZSCommandDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.назваПСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видПаливаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поточнийОбємПаливаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelTableAdapter = new AZSCommand.AZSCommandDataSetTableAdapters.FuelTableAdapter();
            this.видПаливаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типПаливаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKFuelStationFuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelStationTableAdapter = new AZSCommand.AZSCommandDataSetTableAdapters.FuelStationTableAdapter();
            this.назваПСDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видПаливаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поточнийОбємПаливаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aZSCommandDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFuelStationFuelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(457, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Зберегти зміни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // aZSCommandDataSet
            // 
            this.aZSCommandDataSet.DataSetName = "AZSCommandDataSet";
            this.aZSCommandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.видПаливаDataGridViewTextBoxColumn,
            this.типПаливаDataGridViewTextBoxColumn,
            this.цінаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fuelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(457, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 270);
            this.dataGridView1.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.назваПСDataGridViewTextBoxColumn1,
            this.видПаливаDataGridViewTextBoxColumn2,
            this.поточнийОбємПаливаDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.fKFuelStationFuelBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 317);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError_1);
            this.dataGridView2.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_UserAddedRow);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(805, 25);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // назваПСDataGridViewTextBoxColumn
            // 
            this.назваПСDataGridViewTextBoxColumn.DataPropertyName = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn.HeaderText = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn.Name = "назваПСDataGridViewTextBoxColumn";
            // 
            // видПаливаDataGridViewTextBoxColumn1
            // 
            this.видПаливаDataGridViewTextBoxColumn1.DataPropertyName = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn1.HeaderText = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn1.Name = "видПаливаDataGridViewTextBoxColumn1";
            // 
            // поточнийОбємПаливаDataGridViewTextBoxColumn
            // 
            this.поточнийОбємПаливаDataGridViewTextBoxColumn.DataPropertyName = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn.HeaderText = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn.Name = "поточнийОбємПаливаDataGridViewTextBoxColumn";
            // 
            // fuelBindingSource
            // 
            this.fuelBindingSource.DataMember = "Fuel";
            this.fuelBindingSource.DataSource = this.aZSCommandDataSet;
            // 
            // fuelTableAdapter
            // 
            this.fuelTableAdapter.ClearBeforeFill = true;
            // 
            // видПаливаDataGridViewTextBoxColumn
            // 
            this.видПаливаDataGridViewTextBoxColumn.DataPropertyName = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn.HeaderText = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn.Name = "видПаливаDataGridViewTextBoxColumn";
            this.видПаливаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типПаливаDataGridViewTextBoxColumn
            // 
            this.типПаливаDataGridViewTextBoxColumn.DataPropertyName = "Тип палива";
            this.типПаливаDataGridViewTextBoxColumn.HeaderText = "Тип палива";
            this.типПаливаDataGridViewTextBoxColumn.Name = "типПаливаDataGridViewTextBoxColumn";
            this.типПаливаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цінаDataGridViewTextBoxColumn
            // 
            this.цінаDataGridViewTextBoxColumn.DataPropertyName = "Ціна";
            this.цінаDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.цінаDataGridViewTextBoxColumn.Name = "цінаDataGridViewTextBoxColumn";
            this.цінаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKFuelStationFuelBindingSource
            // 
            this.fKFuelStationFuelBindingSource.DataMember = "FK_FuelStation_Fuel";
            this.fKFuelStationFuelBindingSource.DataSource = this.fuelBindingSource;
            // 
            // fuelStationTableAdapter
            // 
            this.fuelStationTableAdapter.ClearBeforeFill = true;
            // 
            // назваПСDataGridViewTextBoxColumn1
            // 
            this.назваПСDataGridViewTextBoxColumn1.DataPropertyName = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn1.HeaderText = "Назва ПС";
            this.назваПСDataGridViewTextBoxColumn1.Name = "назваПСDataGridViewTextBoxColumn1";
            // 
            // видПаливаDataGridViewTextBoxColumn2
            // 
            this.видПаливаDataGridViewTextBoxColumn2.DataPropertyName = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn2.HeaderText = "Вид палива";
            this.видПаливаDataGridViewTextBoxColumn2.Name = "видПаливаDataGridViewTextBoxColumn2";
            // 
            // поточнийОбємПаливаDataGridViewTextBoxColumn1
            // 
            this.поточнийОбємПаливаDataGridViewTextBoxColumn1.DataPropertyName = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn1.HeaderText = "Поточний об\'єм палива";
            this.поточнийОбємПаливаDataGridViewTextBoxColumn1.Name = "поточнийОбємПаливаDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Макс. об\'єм палива";
            this.dataGridViewTextBoxColumn1.HeaderText = "Макс. об\'єм палива";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 350);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Нова паливна станція";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZSCommandDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFuelStationFuelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AZSCommandDataSet aZSCommandDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn максОбємПаливаDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваПСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видПаливаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn поточнийОбємПаливаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fuelBindingSource;
        private AZSCommandDataSetTableAdapters.FuelTableAdapter fuelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn видПаливаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типПаливаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKFuelStationFuelBindingSource;
        private AZSCommandDataSetTableAdapters.FuelStationTableAdapter fuelStationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваПСDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn видПаливаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn поточнийОбємПаливаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
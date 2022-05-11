
namespace ChurchParish
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.readOnlyCB = new System.Windows.Forms.CheckBox();
            this.indexTB = new System.Windows.Forms.TextBox();
            this.parishionerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.parishionerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.churchParishV2DataSet1 = new CrurchParish.ChurchParishV2DataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.parishionerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sortTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.parishionerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.queryCB = new System.Windows.Forms.ComboBox();
            this.parishionerTableAdapter = new CrurchParish.ChurchParishV2DataSet1TableAdapters.ParishionerTableAdapter();
            this.tableAdapterManager = new CrurchParish.ChurchParishV2DataSet1TableAdapters.TableAdapterManager();
            birthDateLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parishionerBindingNavigator)).BeginInit();
            this.parishionerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parishionerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchParishV2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parishionerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(9, 266);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 8;
            birthDateLabel.Text = "Birth Date:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(9, 293);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            // 
            // readOnlyCB
            // 
            this.readOnlyCB.AutoSize = true;
            this.readOnlyCB.Location = new System.Drawing.Point(12, 318);
            this.readOnlyCB.Name = "readOnlyCB";
            this.readOnlyCB.Size = new System.Drawing.Size(73, 17);
            this.readOnlyCB.TabIndex = 6;
            this.readOnlyCB.Text = "ReadOnly";
            this.readOnlyCB.UseVisualStyleBackColor = true;
            this.readOnlyCB.CheckedChanged += new System.EventHandler(this.readOnlyCB_CheckedChanged);
            // 
            // indexTB
            // 
            this.indexTB.Location = new System.Drawing.Point(12, 342);
            this.indexTB.Name = "indexTB";
            this.indexTB.Size = new System.Drawing.Size(100, 20);
            this.indexTB.TabIndex = 7;
            this.indexTB.Leave += new System.EventHandler(this.indexTB_Leave);
            // 
            // parishionerBindingNavigator
            // 
            this.parishionerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.parishionerBindingNavigator.BindingSource = this.parishionerBindingSource;
            this.parishionerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.parishionerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.parishionerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.parishionerBindingNavigatorSaveItem,
            this.sortTextBox});
            this.parishionerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.parishionerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.parishionerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.parishionerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.parishionerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.parishionerBindingNavigator.Name = "parishionerBindingNavigator";
            this.parishionerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.parishionerBindingNavigator.Size = new System.Drawing.Size(889, 25);
            this.parishionerBindingNavigator.TabIndex = 8;
            this.parishionerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // parishionerBindingSource
            // 
            this.parishionerBindingSource.DataMember = "Parishioner";
            this.parishionerBindingSource.DataSource = this.churchParishV2DataSet1;
            // 
            // churchParishV2DataSet1
            // 
            this.churchParishV2DataSet1.DataSetName = "ChurchParishV2DataSet1";
            this.churchParishV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // parishionerBindingNavigatorSaveItem
            // 
            this.parishionerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.parishionerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("parishionerBindingNavigatorSaveItem.Image")));
            this.parishionerBindingNavigatorSaveItem.Name = "parishionerBindingNavigatorSaveItem";
            this.parishionerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.parishionerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.parishionerBindingNavigatorSaveItem.Click += new System.EventHandler(this.parishionerBindingNavigatorSaveItem_Click_1);
            // 
            // sortTextBox
            // 
            this.sortTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sortTextBox.Name = "sortTextBox";
            this.sortTextBox.Size = new System.Drawing.Size(100, 25);
            this.sortTextBox.Leave += new System.EventHandler(this.sortTextBox_Leave);
            // 
            // parishionerDataGridView
            // 
            this.parishionerDataGridView.AutoGenerateColumns = false;
            this.parishionerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parishionerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn14});
            this.parishionerDataGridView.DataSource = this.parishionerBindingSource;
            this.parishionerDataGridView.Location = new System.Drawing.Point(0, 34);
            this.parishionerDataGridView.Name = "parishionerDataGridView";
            this.parishionerDataGridView.Size = new System.Drawing.Size(864, 220);
            this.parishionerDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn9.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn10.HeaderText = "MiddleName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn11.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn12.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Sex";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Sex";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TestColumn";
            this.dataGridViewTextBoxColumn14.HeaderText = "TestColumn";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.parishionerBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(72, 262);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateDateTimePicker.TabIndex = 9;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parishionerBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(75, 290);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // queryCB
            // 
            this.queryCB.FormattingEnabled = true;
            this.queryCB.Items.AddRange(new object[] {
            "Запрос возраста",
            "Запрос мужчин",
            "Вложенный запрос"});
            this.queryCB.Location = new System.Drawing.Point(315, 262);
            this.queryCB.Name = "queryCB";
            this.queryCB.Size = new System.Drawing.Size(121, 21);
            this.queryCB.TabIndex = 12;
            this.queryCB.Text = "Запросы";
            this.queryCB.SelectedValueChanged += new System.EventHandler(this.queryCB_SelectedValueChanged);
            // 
            // parishionerTableAdapter
            // 
            this.parishionerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ParishionerTableAdapter = this.parishionerTableAdapter;
            this.tableAdapterManager.UpdateOrder = CrurchParish.ChurchParishV2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.queryCB);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(this.parishionerDataGridView);
            this.Controls.Add(this.parishionerBindingNavigator);
            this.Controls.Add(this.indexTB);
            this.Controls.Add(this.readOnlyCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parishionerBindingNavigator)).EndInit();
            this.parishionerBindingNavigator.ResumeLayout(false);
            this.parishionerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parishionerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchParishV2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parishionerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox readOnlyCB;
        private System.Windows.Forms.TextBox indexTB;
        private CrurchParish.ChurchParishV2DataSet1 churchParishV2DataSet1;
        private System.Windows.Forms.BindingSource parishionerBindingSource;
        private CrurchParish.ChurchParishV2DataSet1TableAdapters.ParishionerTableAdapter parishionerTableAdapter;
        private CrurchParish.ChurchParishV2DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator parishionerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton parishionerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView parishionerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.ToolStripTextBox sortTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ComboBox queryCB;
    }
}


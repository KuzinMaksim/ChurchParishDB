using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchParish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            churchParishV2DataSet1.Tables[0].PrimaryKey = null;
            DataColumn[] Pkey = new DataColumn[3];
            Pkey[0] = churchParishV2DataSet1.Tables[0].Columns[1];
            Pkey[1] = churchParishV2DataSet1.Tables[0].Columns[2];
            Pkey[2]= churchParishV2DataSet1.Tables[0].Columns[3];
            churchParishV2DataSet1.Tables[0].PrimaryKey = Pkey;
            UniqueConstraint uConstraint = new UniqueConstraint("MyConstraint",
            new DataColumn[] {churchParishV2DataSet1.Tables[0].Columns["Adress"], 
            churchParishV2DataSet1.Tables[0].Columns["BirthDate"],
            churchParishV2DataSet1.Tables[0].Columns["Sex"]}, false);
            churchParishV2DataSet1.Tables[0].Constraints.Add(uConstraint);
            churchParishV2DataSet1.Tables[0].Constraints.Remove(uConstraint);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "churchParishV2DataSet1.Parishioner". При необходимости она может быть перемещена или удалена.
            this.parishionerTableAdapter.Fill(this.churchParishV2DataSet1.Parishioner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "churchParishV2DataSet1.Parishioner". При необходимости она может быть перемещена или удалена.
            this.parishionerTableAdapter.Fill(this.churchParishV2DataSet1.Parishioner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "churchParishV2DataSet1.Parishioner". При необходимости она может быть перемещена или удалена.
            this.parishionerTableAdapter.Fill(this.churchParishV2DataSet1.Parishioner);
        }

        private void readOnlyCB_CheckedChanged(object sender, EventArgs e)
        {
            if(readOnlyCB.Checked==true)
            parishionerDataGridView.Columns[6].ReadOnly = true;
            else
            parishionerDataGridView.Columns[6].ReadOnly = false;
        }

        private void indexTB_Leave(object sender, EventArgs e)
        {
            parishionerDataGridView.Columns[0].DisplayIndex = Convert.ToInt32(indexTB.Text);
        }

        private void sortTextBox_Leave(object sender, EventArgs e)
        {
            parishionerBindingSource.Sort = sortTextBox.Text + " asc";
        }

        private void parishionerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.parishionerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.churchParishV2DataSet1);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrurchParish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            parishionerDataGridView.Columns[0].Visible = true;
            parishionerDataGridView.Columns[6].MinimumWidth = 100;
            DataColumn[] Pkey = new DataColumn[3];
            Pkey[0] = churchParishV2DataSet1.Tables[0].Columns[1];
            Pkey[1] = churchParishV2DataSet1.Tables[0].Columns[2];
            Pkey[2]= churchParishV2DataSet1.Tables[0].Columns[3];
            churchParishV2DataSet1.Tables[0].PrimaryKey = Pkey;
            UniqueConstraint uConstraint = new UniqueConstraint("MyConstraint",
            new DataColumn[] {churchParishV2DataSet1.Tables[0].Columns[5]}, false);
            churchParishV2DataSet1.Tables[0].Constraints.Add(uConstraint);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "churchParishV2DataSet1.Parishioner". При необходимости она может быть перемещена или удалена.
            this.parishionerTableAdapter.Fill(this.churchParishV2DataSet1.Parishioner);
        }

        private void parishionerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.parishionerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.churchParishV2DataSet1);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            parishionerBindingSource.Sort = "FirstName DESC, BirthDate ASC";
        }
    }
}

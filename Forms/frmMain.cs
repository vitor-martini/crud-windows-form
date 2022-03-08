using BASICS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASICS
{
    public partial class frmMain : Form
    {

        clsBasics oclsBasics = new clsBasics();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            oclsBasics.Insert(txtInsert.Text);
            MessageBox.Show(oclsBasics.sMensagem);
            txtInsert.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            oclsBasics.LoadGrid(grdData, txtInsert.Text);
        }

        private void grdData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null){

                string parametro = grdData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string coluna = grdData.Columns[e.ColumnIndex].Name;
                oclsBasics.LoadField(coluna, parametro, txtData);  
            }


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            oclsBasics.LoadCombo(cboData);
        }

    }
}

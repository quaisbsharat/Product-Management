using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management.PL
{
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN Log = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = Log.LOGIN(txtID.Text, txtPWD.Text);

            if (Dt.Rows.Count > 0)
            {
                FRM_MAIN.getMainPage.المنتجاتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainPage.العملاءToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainPage.المستخدمينToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainPage.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainPage.استعادةنسخهمحفوظةToolStripMenuItem.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("يرجى التأكد من البيانات","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

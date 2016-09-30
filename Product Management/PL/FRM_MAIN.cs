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
    public partial class FRM_MAIN : Form
    {

        private static FRM_MAIN frm;

        static void frm_FormClosed(object sender , FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_MAIN getMainPage
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

     
        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخهمحفوظةToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void إضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }
    }
}

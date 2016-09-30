using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {

        BL.CLS_PRODUCT product = new BL.CLS_PRODUCT();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            CbxCategories.DataSource = product.GET_ALL_CATEGORIES();
            CbxCategories.DisplayMember = "DESCRIPTION_CAT";
            CbxCategories.ValueMember = "ID_CAT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files | *.jpg; *.png; *.gif; *.bmp ";


            if (op.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            byte[] Byteimage = ms.ToArray();

            product.ADD_PRODUCT(txtRef.Text, txtDis.Text, int.Parse(txtQte.Text), txtPrice.Text, Byteimage, Convert.ToInt32(CbxCategories.SelectedValue));

            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtRef_Validating(object sender, CancelEventArgs e)
        {
            BL.CLS_PRODUCT Product = new BL.CLS_PRODUCT();
            ErrorProvider Error = new ErrorProvider();
            DataTable Data = new DataTable();
            Data = product.VerfiyProductID(txtRef.Text);
            if (Data.Rows.Count > 0)
            {
                Error.SetError(txtRef, "هذا المنتج موجود مسبقاً يرجى التحقق من جديد");
                txtRef.Focus();
                txtRef.SelectionStart = 0;
                txtRef.SelectionLength = txtRef.Text.Length;           
                    return;
            }
            Error.Dispose();
            btnOk.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

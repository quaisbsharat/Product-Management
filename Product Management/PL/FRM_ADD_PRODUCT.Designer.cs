namespace Product_Management.PL
{
    partial class FRM_ADD_PRODUCT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRef);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CbxCategories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 546);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "إختيار صورة ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(58, 352);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(242, 127);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 4;
            this.pbox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "صورة المنتج :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(58, 293);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(242, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ثمن المنتج :";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(58, 233);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(242, 20);
            this.txtQte.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "الكمية المخزنة :";
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(58, 113);
            this.txtDis.Multiline = true;
            this.txtDis.Name = "txtDis";
            this.txtDis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDis.Size = new System.Drawing.Size(242, 81);
            this.txtDis.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "وصف المنتج :";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(58, 74);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(242, 20);
            this.txtRef.TabIndex = 0;
            this.txtRef.Validating += new System.ComponentModel.CancelEventHandler(this.txtRef_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "معرف المنتج :";
            // 
            // CbxCategories
            // 
            this.CbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategories.FormattingEnabled = true;
            this.CbxCategories.Location = new System.Drawing.Point(58, 28);
            this.CbxCategories.Name = "CbxCategories";
            this.CbxCategories.Size = new System.Drawing.Size(242, 21);
            this.CbxCategories.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج";
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(342, 571);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(249, 571);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 606);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FRM_ADD_PRODUCT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة منتج جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
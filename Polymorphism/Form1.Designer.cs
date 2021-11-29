namespace Polymorphism
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpAllOrders = new System.Windows.Forms.GroupBox();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.grpAddProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpAllOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.grpAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kardeşler Market";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpAllOrders);
            this.panel2.Controls.Add(this.grpAddProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 430);
            this.panel2.TabIndex = 1;
            // 
            // grpAllOrders
            // 
            this.grpAllOrders.Controls.Add(this.grdOrders);
            this.grpAllOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllOrders.Location = new System.Drawing.Point(0, 223);
            this.grpAllOrders.Name = "grpAllOrders";
            this.grpAllOrders.Size = new System.Drawing.Size(418, 207);
            this.grpAllOrders.TabIndex = 4;
            this.grpAllOrders.TabStop = false;
            this.grpAllOrders.Text = "Tüm Siparişler";
            // 
            // grdOrders
            // 
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdOrders.Location = new System.Drawing.Point(3, 21);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(412, 183);
            this.grdOrders.TabIndex = 3;
            // 
            // grpAddProduct
            // 
            this.grpAddProduct.Controls.Add(this.btnUpdate);
            this.grpAddProduct.Controls.Add(this.btnProductDelete);
            this.grpAddProduct.Controls.Add(this.nudQty);
            this.grpAddProduct.Controls.Add(this.cmbProduct);
            this.grpAddProduct.Controls.Add(this.btnAdd);
            this.grpAddProduct.Controls.Add(this.label3);
            this.grpAddProduct.Controls.Add(this.label2);
            this.grpAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAddProduct.Location = new System.Drawing.Point(0, 0);
            this.grpAddProduct.Name = "grpAddProduct";
            this.grpAddProduct.Size = new System.Drawing.Size(418, 223);
            this.grpAddProduct.TabIndex = 2;
            this.grpAddProduct.TabStop = false;
            this.grpAddProduct.Text = "Sepete Ürün Ekle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(22, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 27);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Enabled = false;
            this.btnProductDelete.Location = new System.Drawing.Point(154, 190);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(126, 27);
            this.btnProductDelete.TabIndex = 5;
            this.btnProductDelete.Text = "Sil";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(15, 122);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(385, 25);
            this.nudQty.TabIndex = 4;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(15, 59);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(385, 26);
            this.cmbProduct.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(286, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Miktar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürünler";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(418, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 430);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lstOrders);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 74);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(426, 307);
            this.panel6.TabIndex = 2;
            // 
            // lstOrders
            // 
            this.lstOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(0, 0);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(426, 307);
            this.lstOrders.TabIndex = 0;
            this.lstOrders.DoubleClick += new System.EventHandler(this.lstOrders_DoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCheckout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel5.Location = new System.Drawing.Point(0, 381);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 49);
            this.panel5.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckout.Location = new System.Drawing.Point(235, 6);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(179, 35);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Siparişi Tamamla";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grpOrders);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 74);
            this.panel4.TabIndex = 0;
            // 
            // grpOrders
            // 
            this.grpOrders.Controls.Add(this.lblUrun);
            this.grpOrders.Controls.Add(this.lblSum);
            this.grpOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOrders.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOrders.Location = new System.Drawing.Point(0, 0);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(426, 74);
            this.grpOrders.TabIndex = 0;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Toplam";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrun.Location = new System.Drawing.Point(24, 37);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(83, 18);
            this.lblUrun.TabIndex = 1;
            this.lblUrun.Text = "Ürün Sayısı:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSum.Location = new System.Drawing.Point(224, 37);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(83, 18);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "Toplam: - TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 492);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardeşler Market";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.grpAllOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.grpAddProduct.ResumeLayout(false);
            this.grpAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grpOrders.ResumeLayout(false);
            this.grpOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpAddProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpAllOrders;
    }
}


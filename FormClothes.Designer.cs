using System.Windows.Forms;

namespace _20t1020610
{
    partial class FormClothes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridclothes = new System.Windows.Forms.DataGridView();
            this.listClothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMSP = new System.Windows.Forms.TextBox();
            this.txtTSP = new System.Windows.Forms.TextBox();
            this.txtGB = new System.Windows.Forms.TextBox();
            this.txtGN = new System.Windows.Forms.TextBox();
            this.txtSLN = new System.Windows.Forms.TextBox();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.dtpNHH = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pichinhDaidien = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhDaidienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridclothes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClothesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhDaidien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sản Xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Hết Hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá Bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(779, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá Nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số Lượng Nhập";
            // 
            // gridclothes
            // 
            this.gridclothes.AutoGenerateColumns = false;
            this.gridclothes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.gridclothes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridclothes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSPDataGridViewTextBoxColumn,
            this.tSPDataGridViewTextBoxColumn,
            this.nSXDataGridViewTextBoxColumn,
            this.nHHDataGridViewTextBoxColumn,
            this.gBDataGridViewTextBoxColumn,
            this.gNDataGridViewTextBoxColumn,
            this.sLNDataGridViewTextBoxColumn,
            this.hinhDaidienDataGridViewTextBoxColumn});
            this.gridclothes.DataSource = this.listClothesBindingSource;
            this.gridclothes.Location = new System.Drawing.Point(46, 285);
            this.gridclothes.Name = "gridclothes";
            this.gridclothes.RowHeadersWidth = 51;
            this.gridclothes.RowTemplate.Height = 24;
            this.gridclothes.Size = new System.Drawing.Size(1044, 277);
            this.gridclothes.TabIndex = 1;
            this.gridclothes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridclothes_CellContentClick);
            // 
            // listClothesBindingSource
            // 
            this.listClothesBindingSource.DataMember = "ListClothes";
            this.listClothesBindingSource.DataSource = this.clothesBindingSource;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.btnLoad.Location = new System.Drawing.Point(46, 594);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(188, 64);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.btnAdd.Location = new System.Drawing.Point(346, 594);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 64);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.btnUpdate.Location = new System.Drawing.Point(634, 594);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 64);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.btnDelete.Location = new System.Drawing.Point(902, 594);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(188, 64);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMSP
            // 
            this.txtMSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.txtMSP.ForeColor = System.Drawing.Color.White;
            this.txtMSP.Location = new System.Drawing.Point(186, 116);
            this.txtMSP.Multiline = true;
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(169, 33);
            this.txtMSP.TabIndex = 3;
            // 
            // txtTSP
            // 
            this.txtTSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.txtTSP.ForeColor = System.Drawing.Color.White;
            this.txtTSP.Location = new System.Drawing.Point(186, 58);
            this.txtTSP.Multiline = true;
            this.txtTSP.Name = "txtTSP";
            this.txtTSP.Size = new System.Drawing.Size(169, 33);
            this.txtTSP.TabIndex = 3;
            // 
            // txtGB
            // 
            this.txtGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.txtGB.ForeColor = System.Drawing.Color.White;
            this.txtGB.Location = new System.Drawing.Point(552, 60);
            this.txtGB.Multiline = true;
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(169, 31);
            this.txtGB.TabIndex = 3;
            // 
            // txtGN
            // 
            this.txtGN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.txtGN.ForeColor = System.Drawing.Color.White;
            this.txtGN.Location = new System.Drawing.Point(921, 60);
            this.txtGN.Multiline = true;
            this.txtGN.Name = "txtGN";
            this.txtGN.Size = new System.Drawing.Size(169, 31);
            this.txtGN.TabIndex = 3;
            // 
            // txtSLN
            // 
            this.txtSLN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.txtSLN.ForeColor = System.Drawing.Color.White;
            this.txtSLN.Location = new System.Drawing.Point(186, 175);
            this.txtSLN.Multiline = true;
            this.txtSLN.Name = "txtSLN";
            this.txtSLN.Size = new System.Drawing.Size(169, 31);
            this.txtSLN.TabIndex = 3;
            // 
            // dtpNSX
            // 
            this.dtpNSX.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.dtpNSX.Location = new System.Drawing.Point(552, 173);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(169, 22);
            this.dtpNSX.TabIndex = 4;
            // 
            // dtpNHH
            // 
            this.dtpNHH.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNHH.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.dtpNHH.Location = new System.Drawing.Point(552, 127);
            this.dtpNHH.Name = "dtpNHH";
            this.dtpNHH.Size = new System.Drawing.Size(169, 22);
            this.dtpNHH.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(779, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hình Sản Phẩm";
            // 
            // pichinhDaidien
            // 
            this.pichinhDaidien.BackColor = System.Drawing.Color.Transparent;
            this.pichinhDaidien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pichinhDaidien.Location = new System.Drawing.Point(921, 118);
            this.pichinhDaidien.Name = "pichinhDaidien";
            this.pichinhDaidien.Size = new System.Drawing.Size(169, 147);
            this.pichinhDaidien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichinhDaidien.TabIndex = 5;
            this.pichinhDaidien.TabStop = false;
            this.pichinhDaidien.Click += new System.EventHandler(this.pichinhDaidien_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(409, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "Danh sách sản phẩm";
            // 
            // mSPDataGridViewTextBoxColumn
            // 
            this.mSPDataGridViewTextBoxColumn.DataPropertyName = "MSP";
            this.mSPDataGridViewTextBoxColumn.HeaderText = "MSP";
            this.mSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSPDataGridViewTextBoxColumn.Name = "mSPDataGridViewTextBoxColumn";
            this.mSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tSPDataGridViewTextBoxColumn
            // 
            this.tSPDataGridViewTextBoxColumn.DataPropertyName = "TSP";
            this.tSPDataGridViewTextBoxColumn.HeaderText = "TSP";
            this.tSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tSPDataGridViewTextBoxColumn.Name = "tSPDataGridViewTextBoxColumn";
            this.tSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // nSXDataGridViewTextBoxColumn
            // 
            this.nSXDataGridViewTextBoxColumn.DataPropertyName = "NSX";
            this.nSXDataGridViewTextBoxColumn.HeaderText = "NSX";
            this.nSXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nSXDataGridViewTextBoxColumn.Name = "nSXDataGridViewTextBoxColumn";
            this.nSXDataGridViewTextBoxColumn.Width = 125;
            // 
            // nHHDataGridViewTextBoxColumn
            // 
            this.nHHDataGridViewTextBoxColumn.DataPropertyName = "NHH";
            this.nHHDataGridViewTextBoxColumn.HeaderText = "NHH";
            this.nHHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nHHDataGridViewTextBoxColumn.Name = "nHHDataGridViewTextBoxColumn";
            this.nHHDataGridViewTextBoxColumn.Width = 125;
            // 
            // gBDataGridViewTextBoxColumn
            // 
            this.gBDataGridViewTextBoxColumn.DataPropertyName = "GB";
            this.gBDataGridViewTextBoxColumn.HeaderText = "GB";
            this.gBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gBDataGridViewTextBoxColumn.Name = "gBDataGridViewTextBoxColumn";
            this.gBDataGridViewTextBoxColumn.Width = 125;
            // 
            // gNDataGridViewTextBoxColumn
            // 
            this.gNDataGridViewTextBoxColumn.DataPropertyName = "GN";
            this.gNDataGridViewTextBoxColumn.HeaderText = "GN";
            this.gNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gNDataGridViewTextBoxColumn.Name = "gNDataGridViewTextBoxColumn";
            this.gNDataGridViewTextBoxColumn.Width = 125;
            // 
            // sLNDataGridViewTextBoxColumn
            // 
            this.sLNDataGridViewTextBoxColumn.DataPropertyName = "SLN";
            this.sLNDataGridViewTextBoxColumn.HeaderText = "SLN";
            this.sLNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLNDataGridViewTextBoxColumn.Name = "sLNDataGridViewTextBoxColumn";
            this.sLNDataGridViewTextBoxColumn.Width = 125;
            // 
            // hinhDaidienDataGridViewTextBoxColumn
            // 
            this.hinhDaidienDataGridViewTextBoxColumn.DataPropertyName = "hinhDaidien";
            this.hinhDaidienDataGridViewTextBoxColumn.HeaderText = "hinhDaidien";
            this.hinhDaidienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hinhDaidienDataGridViewTextBoxColumn.Name = "hinhDaidienDataGridViewTextBoxColumn";
            this.hinhDaidienDataGridViewTextBoxColumn.Width = 125;
            // 
            // clothesBindingSource
            // 
            this.clothesBindingSource.DataSource = typeof(_20t1020610.Model.Clothes);
            // 
            // FormClothes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1131, 708);
            this.Controls.Add(this.pichinhDaidien);
            this.Controls.Add(this.dtpNHH);
            this.Controls.Add(this.dtpNSX);
            this.Controls.Add(this.txtSLN);
            this.Controls.Add(this.txtGN);
            this.Controls.Add(this.txtTSP);
            this.Controls.Add(this.txtGB);
            this.Controls.Add(this.txtMSP);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gridclothes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClothes";
            this.Text = "FormClothes";
            this.Load += new System.EventHandler(this.FormClothes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridclothes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClothesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhDaidien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private  Label label2;
        private  Label label3;
        private  Label label4;
        private  Label label5;
        private  Label label6;
        private  Label label7;
        private  DataGridView gridclothes;
        private  Button btnLoad;
        private  Button btnAdd;
        private  Button btnUpdate;
        private  Button btnDelete;
        private  TextBox txtMSP;
        private  TextBox txtTSP;
        private  TextBox txtGB;
        private  TextBox txtGN;
        private  TextBox txtSLN;
        private  DateTimePicker dtpNSX;
        private  DateTimePicker dtpNHH;
        private  Label label8;
        private  PictureBox pichinhDaidien;
        private DataGridViewTextBoxColumn mSPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tSPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nSXDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nHHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sLNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hinhDaidienDataGridViewTextBoxColumn;
        private BindingSource listClothesBindingSource;
        private BindingSource clothesBindingSource;
        private Label label9;
    }
}
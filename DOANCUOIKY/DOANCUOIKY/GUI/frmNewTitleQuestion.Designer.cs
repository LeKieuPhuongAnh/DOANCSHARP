﻿namespace DOANCUOIKY.GUI
{
    partial class frmNewTitleQuestion
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
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.edtNameSearch = new System.Windows.Forms.TextBox();
            this.edtNoSearch = new System.Windows.Forms.TextBox();
            this.cbCategorySearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.gvTitle = new System.Windows.Forms.DataGridView();
            this.gbTitle.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTitle
            // 
            this.gbTitle.Controls.Add(this.edtName);
            this.gbTitle.Controls.Add(this.edtNo);
            this.gbTitle.Controls.Add(this.label5);
            this.gbTitle.Controls.Add(this.cbCategory);
            this.gbTitle.Controls.Add(this.btSave);
            this.gbTitle.Controls.Add(this.btRemove);
            this.gbTitle.Controls.Add(this.btEdit);
            this.gbTitle.Controls.Add(this.btAdd);
            this.gbTitle.Controls.Add(this.label2);
            this.gbTitle.Controls.Add(this.label1);
            this.gbTitle.Location = new System.Drawing.Point(23, 16);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(829, 162);
            this.gbTitle.TabIndex = 0;
            this.gbTitle.TabStop = false;
            this.gbTitle.Text = "Thông tin mã đề";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(97, 67);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(212, 20);
            this.edtName.TabIndex = 13;
            // 
            // edtNo
            // 
            this.edtNo.Location = new System.Drawing.Point(97, 32);
            this.edtNo.Name = "edtNo";
            this.edtNo.Size = new System.Drawing.Size(212, 20);
            this.edtNo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Loại";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(97, 102);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(212, 21);
            this.cbCategory.TabIndex = 10;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(505, 123);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(748, 123);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Xóa";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(667, 123);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(586, 123);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.edtNameSearch);
            this.groupBox.Controls.Add(this.edtNoSearch);
            this.groupBox.Controls.Add(this.cbCategorySearch);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.btFind);
            this.groupBox.Controls.Add(this.gvTitle);
            this.groupBox.Location = new System.Drawing.Point(23, 184);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(829, 341);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // edtNameSearch
            // 
            this.edtNameSearch.Location = new System.Drawing.Point(230, 34);
            this.edtNameSearch.Name = "edtNameSearch";
            this.edtNameSearch.Size = new System.Drawing.Size(246, 20);
            this.edtNameSearch.TabIndex = 15;
            // 
            // edtNoSearch
            // 
            this.edtNoSearch.Location = new System.Drawing.Point(50, 34);
            this.edtNoSearch.Name = "edtNoSearch";
            this.edtNoSearch.Size = new System.Drawing.Size(133, 20);
            this.edtNoSearch.TabIndex = 14;
            // 
            // cbCategorySearch
            // 
            this.cbCategorySearch.FormattingEnabled = true;
            this.cbCategorySearch.Location = new System.Drawing.Point(515, 34);
            this.cbCategorySearch.Name = "cbCategorySearch";
            this.cbCategorySearch.Size = new System.Drawing.Size(197, 21);
            this.cbCategorySearch.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "No";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(748, 32);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 3;
            this.btFind.Text = "Tìm kiếm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // gvTitle
            // 
            this.gvTitle.AllowUserToAddRows = false;
            this.gvTitle.AllowUserToDeleteRows = false;
            this.gvTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTitle.Location = new System.Drawing.Point(6, 61);
            this.gvTitle.Name = "gvTitle";
            this.gvTitle.ReadOnly = true;
            this.gvTitle.Size = new System.Drawing.Size(817, 274);
            this.gvTitle.TabIndex = 0;
            this.gvTitle.Click += new System.EventHandler(this.gvTitle_Click);
            // 
            // frmNewTitleQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 537);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.gbTitle);
            this.Name = "frmNewTitleQuestion";
            this.Text = "frmNewTitleQuestion";
            this.gbTitle.ResumeLayout(false);
            this.gbTitle.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView gvTitle;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategorySearch;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtNo;
        private System.Windows.Forms.TextBox edtNoSearch;
        private System.Windows.Forms.TextBox edtNameSearch;
    }
}
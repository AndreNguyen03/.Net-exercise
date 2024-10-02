namespace LinQToObject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSearchData = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.btnFromTo = new System.Windows.Forms.Button();
            this.btnExpired = new System.Windows.Forms.Button();
            this.btnFromJP = new System.Windows.Forms.Button();
            this.btnMostValue = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeleteAllExpired = new System.Windows.Forms.Button();
            this.btnCheckExpired = new System.Windows.Forms.Button();
            this.tbDeleteOrigin = new System.Windows.Forms.TextBox();
            this.btnDeleteOrigin = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbOrigin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbProductId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin sản phẩm";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(182, 222);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(82, 32);
            this.btnDeleteProduct.TabIndex = 13;
            this.btnDeleteProduct.Text = "Xóa SP";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu SP";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTime
            // 
            this.dateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(90, 186);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(179, 23);
            this.dateTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 181);
            this.label6.MaximumSize = new System.Drawing.Size(70, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày hết hạn:";
            // 
            // tbOrigin
            // 
            this.tbOrigin.Location = new System.Drawing.Point(91, 153);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(178, 23);
            this.tbOrigin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xuất xứ:";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(91, 122);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(178, 23);
            this.tbValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(91, 91);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(178, 23);
            this.tbQuantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(91, 59);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(178, 23);
            this.tbProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SP:";
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(91, 27);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(178, 23);
            this.tbProductId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSearchData);
            this.groupBox2.Controls.Add(this.tbTo);
            this.groupBox2.Controls.Add(this.tbFrom);
            this.groupBox2.Controls.Add(this.btnFromTo);
            this.groupBox2.Controls.Add(this.btnExpired);
            this.groupBox2.Controls.Add(this.btnFromJP);
            this.groupBox2.Controls.Add(this.btnMostValue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(313, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng tìm kiếm";
            // 
            // dgvSearchData
            // 
            this.dgvSearchData.ColumnHeadersHeight = 20;
            this.dgvSearchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSearchData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Quantity,
            this.Value,
            this.Origin,
            this.ExpiredDate});
            this.dgvSearchData.Location = new System.Drawing.Point(12, 73);
            this.dgvSearchData.Name = "dgvSearchData";
            this.dgvSearchData.RowTemplate.Height = 30;
            this.dgvSearchData.Size = new System.Drawing.Size(552, 189);
            this.dgvSearchData.TabIndex = 22;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Mã SP";
            this.ProductId.Name = "ProductId";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên SP";
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // Value
            // 
            this.Value.HeaderText = "Đơn giá";
            this.Value.Name = "Value";
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Xuất xứ";
            this.Origin.Name = "Origin";
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.HeaderText = "Ngày hết hạn";
            this.ExpiredDate.Name = "ExpiredDate";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(517, 22);
            this.tbTo.Multiline = true;
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(47, 45);
            this.tbTo.TabIndex = 21;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(464, 22);
            this.tbFrom.Multiline = true;
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(47, 45);
            this.tbFrom.TabIndex = 20;
            // 
            // btnFromTo
            // 
            this.btnFromTo.Location = new System.Drawing.Point(358, 23);
            this.btnFromTo.Name = "btnFromTo";
            this.btnFromTo.Size = new System.Drawing.Size(100, 44);
            this.btnFromTo.TabIndex = 17;
            this.btnFromTo.Text = "Xuất các SP có ĐG [a...b]";
            this.btnFromTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFromTo.UseVisualStyleBackColor = true;
            this.btnFromTo.Click += new System.EventHandler(this.btnFromTo_Click);
            // 
            // btnExpired
            // 
            this.btnExpired.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExpired.Location = new System.Drawing.Point(204, 23);
            this.btnExpired.Name = "btnExpired";
            this.btnExpired.Size = new System.Drawing.Size(110, 44);
            this.btnExpired.TabIndex = 16;
            this.btnExpired.Text = "Xuất toàn bộ SP quá hạn";
            this.btnExpired.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExpired.UseVisualStyleBackColor = true;
            this.btnExpired.Click += new System.EventHandler(this.btnExpired_Click);
            // 
            // btnFromJP
            // 
            this.btnFromJP.Location = new System.Drawing.Point(108, 23);
            this.btnFromJP.Name = "btnFromJP";
            this.btnFromJP.Size = new System.Drawing.Size(93, 44);
            this.btnFromJP.TabIndex = 15;
            this.btnFromJP.Text = "1 SP từ Nhật Bản";
            this.btnFromJP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFromJP.UseVisualStyleBackColor = true;
            this.btnFromJP.Click += new System.EventHandler(this.btnFromJP_Click);
            // 
            // btnMostValue
            // 
            this.btnMostValue.Location = new System.Drawing.Point(12, 23);
            this.btnMostValue.Name = "btnMostValue";
            this.btnMostValue.Size = new System.Drawing.Size(93, 44);
            this.btnMostValue.TabIndex = 14;
            this.btnMostValue.Text = "1 SP có ĐG cao nhất";
            this.btnMostValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMostValue.UseVisualStyleBackColor = true;
            this.btnMostValue.Click += new System.EventHandler(this.btnMostValue_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dgvData);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(13, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(875, 221);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm sau khi nhập:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteAll);
            this.groupBox4.Controls.Add(this.btnDeleteAllExpired);
            this.groupBox4.Controls.Add(this.btnCheckExpired);
            this.groupBox4.Controls.Add(this.tbDeleteOrigin);
            this.groupBox4.Controls.Add(this.btnDeleteOrigin);
            this.groupBox4.Location = new System.Drawing.Point(593, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 202);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn thao tác:";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(17, 140);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(107, 44);
            this.btnDeleteAll.TabIndex = 26;
            this.btnDeleteAll.Text = "Xóa toàn bộ SP trong kho";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteAllExpired
            // 
            this.btnDeleteAllExpired.Location = new System.Drawing.Point(141, 140);
            this.btnDeleteAllExpired.Name = "btnDeleteAllExpired";
            this.btnDeleteAllExpired.Size = new System.Drawing.Size(124, 44);
            this.btnDeleteAllExpired.TabIndex = 26;
            this.btnDeleteAllExpired.Text = "Xóa toàn bộ SP quá hạn";
            this.btnDeleteAllExpired.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteAllExpired.UseVisualStyleBackColor = true;
            this.btnDeleteAllExpired.Click += new System.EventHandler(this.btnDeleteAllExpired_Click);
            // 
            // btnCheckExpired
            // 
            this.btnCheckExpired.Location = new System.Drawing.Point(17, 77);
            this.btnCheckExpired.Name = "btnCheckExpired";
            this.btnCheckExpired.Size = new System.Drawing.Size(248, 53);
            this.btnCheckExpired.TabIndex = 25;
            this.btnCheckExpired.Text = "Kiểm tra xem kho có SP quá hạn hay không?";
            this.btnCheckExpired.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCheckExpired.UseVisualStyleBackColor = true;
            this.btnCheckExpired.Click += new System.EventHandler(this.btnCheckExpired_Click);
            // 
            // tbDeleteOrigin
            // 
            this.tbDeleteOrigin.Location = new System.Drawing.Point(141, 21);
            this.tbDeleteOrigin.Multiline = true;
            this.tbDeleteOrigin.Name = "tbDeleteOrigin";
            this.tbDeleteOrigin.Size = new System.Drawing.Size(124, 45);
            this.tbDeleteOrigin.TabIndex = 24;
            // 
            // btnDeleteOrigin
            // 
            this.btnDeleteOrigin.Location = new System.Drawing.Point(17, 22);
            this.btnDeleteOrigin.Name = "btnDeleteOrigin";
            this.btnDeleteOrigin.Size = new System.Drawing.Size(107, 44);
            this.btnDeleteOrigin.TabIndex = 23;
            this.btnDeleteOrigin.Text = "Xóa SP theo xuất xứ bất kì:";
            this.btnDeleteOrigin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteOrigin.UseVisualStyleBackColor = true;
            this.btnDeleteOrigin.Click += new System.EventHandler(this.btnDeleteOrigin_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeight = 20;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvData.Location = new System.Drawing.Point(6, 22);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 30;
            this.dgvData.Size = new System.Drawing.Size(581, 193);
            this.dgvData.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã SP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductQuantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductValue";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductOrigin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Xuất xứ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProductExpired";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày hết hạn";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 519);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostValue;
        private System.Windows.Forms.Button btnFromTo;
        private System.Windows.Forms.Button btnExpired;
        private System.Windows.Forms.Button btnFromJP;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.DataGridView dgvSearchData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbDeleteOrigin;
        private System.Windows.Forms.Button btnDeleteOrigin;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDeleteAllExpired;
        private System.Windows.Forms.Button btnCheckExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}


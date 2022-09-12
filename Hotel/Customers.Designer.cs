namespace Hotel
{
    partial class Customers
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnVariables = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskTextNo = new System.Windows.Forms.MaskedTextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.dtpEntry = new System.Windows.Forms.DateTimePicker();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 273);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(783, 175);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Male";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TelephoneNumber";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 42;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "İdentityNumber";
            this.columnHeader7.Width = 92;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "RoomNo";
            this.columnHeader8.Width = 67;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Amount";
            this.columnHeader9.Width = 72;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "DateOfEntry";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "DateOfRelease";
            this.columnHeader11.Width = 88;
            // 
            // BtnVariables
            // 
            this.BtnVariables.Location = new System.Drawing.Point(637, 6);
            this.BtnVariables.Name = "BtnVariables";
            this.BtnVariables.Size = new System.Drawing.Size(135, 34);
            this.BtnVariables.TabIndex = 1;
            this.BtnVariables.Text = "Show Variable";
            this.BtnVariables.UseVisualStyleBackColor = true;
            this.BtnVariables.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(637, 61);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(135, 34);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update Variable";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(637, 126);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(135, 34);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.comboBox2.Location = new System.Drawing.Point(118, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Male:";
            // 
            // mskTextNo
            // 
            this.mskTextNo.Location = new System.Drawing.Point(118, 100);
            this.mskTextNo.Mask = "(999) 000-0000";
            this.mskTextNo.Name = "mskTextNo";
            this.mskTextNo.Size = new System.Drawing.Size(200, 20);
            this.mskTextNo.TabIndex = 58;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(118, 211);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(200, 20);
            this.txtRoomNo.TabIndex = 57;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(118, 247);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 56;
            // 
            // dtpRelease
            // 
            this.dtpRelease.Location = new System.Drawing.Point(421, 46);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(200, 20);
            this.dtpRelease.TabIndex = 55;
            // 
            // dtpEntry
            // 
            this.dtpEntry.Location = new System.Drawing.Point(421, 6);
            this.dtpEntry.Name = "dtpEntry";
            this.dtpEntry.Size = new System.Drawing.Size(200, 20);
            this.dtpEntry.TabIndex = 54;
            // 
            // txtIdentity
            // 
            this.txtIdentity.Location = new System.Drawing.Point(118, 173);
            this.txtIdentity.MaxLength = 11;
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(200, 20);
            this.txtIdentity.TabIndex = 53;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(118, 134);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 20);
            this.txtMail.TabIndex = 52;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(118, 35);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(200, 20);
            this.TxtSurname.TabIndex = 51;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(118, 6);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(200, 20);
            this.TxtName.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "DateOfRelease:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "DateOfEntry:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "RoomNo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "IdentityNumber:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "DateOfRelease:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(324, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "DateOfEntry:";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(637, 190);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(135, 34);
            this.BtnClear.TabIndex = 63;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskTextNo);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.dtpEntry);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnVariables);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button BtnVariables;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskTextNo;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.DateTimePicker dtpEntry;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnClear;
    }
}
namespace Hotel
{
    partial class NewCustomer
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRoom303 = new System.Windows.Forms.Button();
            this.btnRoom302 = new System.Windows.Forms.Button();
            this.btnRoom301 = new System.Windows.Forms.Button();
            this.btnRoom203 = new System.Windows.Forms.Button();
            this.btnRoom202 = new System.Windows.Forms.Button();
            this.btnRoom201 = new System.Windows.Forms.Button();
            this.btnRoom103 = new System.Windows.Forms.Button();
            this.btnRoom102 = new System.Windows.Forms.Button();
            this.btnRoom101 = new System.Windows.Forms.Button();
            this.btnFree = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.mskTextNo);
            this.groupBox1.Controls.Add(this.txtRoomNo);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.dtpRelease);
            this.groupBox1.Controls.Add(this.dtpEntry);
            this.groupBox1.Controls.Add(this.txtIdentity);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 426);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.comboBox2.Location = new System.Drawing.Point(147, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Male:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(147, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 38);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mskTextNo
            // 
            this.mskTextNo.Location = new System.Drawing.Point(147, 124);
            this.mskTextNo.Mask = "(999) 000-0000";
            this.mskTextNo.Name = "mskTextNo";
            this.mskTextNo.Size = new System.Drawing.Size(200, 20);
            this.mskTextNo.TabIndex = 36;
            this.mskTextNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextNo_MaskInputRejected);
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(147, 235);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(200, 20);
            this.txtRoomNo.TabIndex = 35;
            this.txtRoomNo.TextChanged += new System.EventHandler(this.txtRoomNo_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(147, 271);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 34;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // dtpRelease
            // 
            this.dtpRelease.Location = new System.Drawing.Point(147, 350);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(200, 20);
            this.dtpRelease.TabIndex = 33;
            this.dtpRelease.ValueChanged += new System.EventHandler(this.dtpRelease_ValueChanged);
            // 
            // dtpEntry
            // 
            this.dtpEntry.Location = new System.Drawing.Point(147, 313);
            this.dtpEntry.Name = "dtpEntry";
            this.dtpEntry.Size = new System.Drawing.Size(200, 20);
            this.dtpEntry.TabIndex = 32;
            this.dtpEntry.ValueChanged += new System.EventHandler(this.dtpEntry_ValueChanged);
            // 
            // txtIdentity
            // 
            this.txtIdentity.Location = new System.Drawing.Point(147, 197);
            this.txtIdentity.MaxLength = 11;
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(200, 20);
            this.txtIdentity.TabIndex = 31;
            this.txtIdentity.TextChanged += new System.EventHandler(this.txtIdentity_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(147, 158);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 20);
            this.txtMail.TabIndex = 30;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(147, 59);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(200, 20);
            this.TxtSurname.TabIndex = 29;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(147, 30);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(200, 20);
            this.TxtName.TabIndex = 28;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "DateOfRelease:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "DateOfEntry:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "RoomNo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "IdentityNumber:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRoom303);
            this.groupBox2.Controls.Add(this.btnRoom302);
            this.groupBox2.Controls.Add(this.btnRoom301);
            this.groupBox2.Controls.Add(this.btnRoom203);
            this.groupBox2.Controls.Add(this.btnRoom202);
            this.groupBox2.Controls.Add(this.btnRoom201);
            this.groupBox2.Controls.Add(this.btnRoom103);
            this.groupBox2.Controls.Add(this.btnRoom102);
            this.groupBox2.Controls.Add(this.btnRoom101);
            this.groupBox2.Location = new System.Drawing.Point(415, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 349);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnRoom303
            // 
            this.btnRoom303.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoom303.ForeColor = System.Drawing.Color.Black;
            this.btnRoom303.Location = new System.Drawing.Point(269, 186);
            this.btnRoom303.Name = "btnRoom303";
            this.btnRoom303.Size = new System.Drawing.Size(75, 38);
            this.btnRoom303.TabIndex = 8;
            this.btnRoom303.Text = "303";
            this.btnRoom303.UseVisualStyleBackColor = false;
            this.btnRoom303.Click += new System.EventHandler(this.btnRoom303_Click);
            // 
            // btnRoom302
            // 
            this.btnRoom302.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoom302.ForeColor = System.Drawing.Color.Black;
            this.btnRoom302.Location = new System.Drawing.Point(144, 189);
            this.btnRoom302.Name = "btnRoom302";
            this.btnRoom302.Size = new System.Drawing.Size(75, 35);
            this.btnRoom302.TabIndex = 7;
            this.btnRoom302.Text = "302";
            this.btnRoom302.UseVisualStyleBackColor = false;
            this.btnRoom302.Click += new System.EventHandler(this.btnRoom302_Click);
            // 
            // btnRoom301
            // 
            this.btnRoom301.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoom301.ForeColor = System.Drawing.Color.Black;
            this.btnRoom301.Location = new System.Drawing.Point(18, 189);
            this.btnRoom301.Name = "btnRoom301";
            this.btnRoom301.Size = new System.Drawing.Size(75, 35);
            this.btnRoom301.TabIndex = 6;
            this.btnRoom301.Text = "301";
            this.btnRoom301.UseVisualStyleBackColor = false;
            this.btnRoom301.Click += new System.EventHandler(this.btnRoom301_Click);
            // 
            // btnRoom203
            // 
            this.btnRoom203.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoom203.ForeColor = System.Drawing.Color.Black;
            this.btnRoom203.Location = new System.Drawing.Point(269, 108);
            this.btnRoom203.Name = "btnRoom203";
            this.btnRoom203.Size = new System.Drawing.Size(75, 36);
            this.btnRoom203.TabIndex = 5;
            this.btnRoom203.Text = "203";
            this.btnRoom203.UseVisualStyleBackColor = false;
            this.btnRoom203.Click += new System.EventHandler(this.btnRoom203_Click);
            // 
            // btnRoom202
            // 
            this.btnRoom202.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoom202.ForeColor = System.Drawing.Color.Black;
            this.btnRoom202.Location = new System.Drawing.Point(144, 108);
            this.btnRoom202.Name = "btnRoom202";
            this.btnRoom202.Size = new System.Drawing.Size(75, 37);
            this.btnRoom202.TabIndex = 4;
            this.btnRoom202.Text = "202";
            this.btnRoom202.UseVisualStyleBackColor = false;
            this.btnRoom202.Click += new System.EventHandler(this.btnRoom202_Click);
            // 
            // btnRoom201
            // 
            this.btnRoom201.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoom201.ForeColor = System.Drawing.Color.Black;
            this.btnRoom201.Location = new System.Drawing.Point(18, 108);
            this.btnRoom201.Name = "btnRoom201";
            this.btnRoom201.Size = new System.Drawing.Size(75, 37);
            this.btnRoom201.TabIndex = 3;
            this.btnRoom201.Text = "201";
            this.btnRoom201.UseVisualStyleBackColor = false;
            this.btnRoom201.Click += new System.EventHandler(this.btnRoom201_Click);
            // 
            // btnRoom103
            // 
            this.btnRoom103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoom103.ForeColor = System.Drawing.Color.Black;
            this.btnRoom103.Location = new System.Drawing.Point(269, 33);
            this.btnRoom103.Name = "btnRoom103";
            this.btnRoom103.Size = new System.Drawing.Size(75, 37);
            this.btnRoom103.TabIndex = 2;
            this.btnRoom103.Text = "103";
            this.btnRoom103.UseVisualStyleBackColor = false;
            this.btnRoom103.Click += new System.EventHandler(this.btnRoom103_Click);
            // 
            // btnRoom102
            // 
            this.btnRoom102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoom102.ForeColor = System.Drawing.Color.Black;
            this.btnRoom102.Location = new System.Drawing.Point(144, 33);
            this.btnRoom102.Name = "btnRoom102";
            this.btnRoom102.Size = new System.Drawing.Size(75, 37);
            this.btnRoom102.TabIndex = 1;
            this.btnRoom102.Text = "102";
            this.btnRoom102.UseVisualStyleBackColor = false;
            this.btnRoom102.Click += new System.EventHandler(this.btnRoom102_Click);
            // 
            // btnRoom101
            // 
            this.btnRoom101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRoom101.ForeColor = System.Drawing.Color.Black;
            this.btnRoom101.Location = new System.Drawing.Point(18, 33);
            this.btnRoom101.Name = "btnRoom101";
            this.btnRoom101.Size = new System.Drawing.Size(75, 37);
            this.btnRoom101.TabIndex = 0;
            this.btnRoom101.Text = "101";
            this.btnRoom101.UseVisualStyleBackColor = false;
            this.btnRoom101.Click += new System.EventHandler(this.btnRoom101_Click);
            // 
            // btnFree
            // 
            this.btnFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFree.Location = new System.Drawing.Point(586, 399);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(75, 39);
            this.btnFree.TabIndex = 21;
            this.btnFree.Text = "FREE";
            this.btnFree.UseVisualStyleBackColor = false;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // btnFull
            // 
            this.btnFull.BackColor = System.Drawing.Color.Red;
            this.btnFull.Location = new System.Drawing.Point(699, 400);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(75, 38);
            this.btnFull.TabIndex = 22;
            this.btnFull.Text = "FULL";
            this.btnFull.UseVisualStyleBackColor = false;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.btnFree);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRoom303;
        private System.Windows.Forms.Button btnRoom302;
        private System.Windows.Forms.Button btnRoom301;
        private System.Windows.Forms.Button btnRoom203;
        private System.Windows.Forms.Button btnRoom202;
        private System.Windows.Forms.Button btnRoom201;
        private System.Windows.Forms.Button btnRoom103;
        private System.Windows.Forms.Button btnRoom102;
        private System.Windows.Forms.Button btnRoom101;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}


namespace DBFirstExample
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
            this.components = new System.ComponentModel.Container();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lblshoppingpreference = new System.Windows.Forms.Label();
            this.lblpreferCOD = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.lbid = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.trainingDBDataSet = new DBFirstExample.TrainingDBDataSet();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerShoppingTableAdapter = new DBFirstExample.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.btupdate = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(59, 76);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(121, 24);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter Name";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(59, 129);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(144, 24);
            this.lblgender.TabIndex = 0;
            this.lblgender.Text = "Select Gender";
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(59, 193);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(190, 24);
            this.lblmembership.TabIndex = 0;
            this.lblmembership.Text = "Select Membership";
            // 
            // lblshoppingpreference
            // 
            this.lblshoppingpreference.AutoSize = true;
            this.lblshoppingpreference.Location = new System.Drawing.Point(59, 294);
            this.lblshoppingpreference.Name = "lblshoppingpreference";
            this.lblshoppingpreference.Size = new System.Drawing.Size(261, 24);
            this.lblshoppingpreference.TabIndex = 0;
            this.lblshoppingpreference.Text = "Select Shoping Preference";
            // 
            // lblpreferCOD
            // 
            this.lblpreferCOD.AutoSize = true;
            this.lblpreferCOD.Location = new System.Drawing.Point(59, 410);
            this.lblpreferCOD.Name = "lblpreferCOD";
            this.lblpreferCOD.Size = new System.Drawing.Size(127, 24);
            this.lblpreferCOD.TabIndex = 0;
            this.lblpreferCOD.Text = "Prefer COD?";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(59, 477);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(156, 24);
            this.lblpassword.TabIndex = 0;
            this.lblpassword.Text = "Enter Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(442, 73);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(307, 29);
            this.txtname.TabIndex = 1;
            // 
            // cbgender
            // 
            this.cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(442, 126);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(307, 32);
            this.cbgender.TabIndex = 2;
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(483, 191);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(72, 28);
            this.rbfree.TabIndex = 3;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "Free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(606, 191);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(69, 28);
            this.rbpaid.TabIndex = 3;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "Paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            // 
            // clbshop
            // 
            this.clbshop.FormattingEnabled = true;
            this.clbshop.Items.AddRange(new object[] {
            "Mobile",
            "Laptop",
            "Groceries",
            "Stationaries",
            "Cosmetics",
            "Apparels",
            "Kitchen Items",
            "Electronic Gadgets"});
            this.clbshop.Location = new System.Drawing.Point(442, 253);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(322, 124);
            this.clbshop.TabIndex = 4;
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(442, 409);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(84, 28);
            this.cbcod.TabIndex = 5;
            this.cbcod.Text = "COD?";
            this.cbcod.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(442, 474);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(307, 29);
            this.txtpassword.TabIndex = 6;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(337, 520);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(136, 44);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(79, 520);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(136, 44);
            this.btnselect.TabIndex = 7;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 24;
            this.lbselect.Location = new System.Drawing.Point(818, 27);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(350, 460);
            this.lbselect.TabIndex = 8;
            // 
            // cbid
            // 
            this.cbid.DataSource = this.registerShoppingBindingSource;
            this.cbid.DisplayMember = "Name";
            this.cbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(442, 21);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(307, 32);
            this.cbid.TabIndex = 9;
            this.cbid.ValueMember = "Id";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(59, 24);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(29, 24);
            this.lbid.TabIndex = 0;
            this.lbid.Text = "ID";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(590, 520);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(138, 44);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerShoppingBindingSource
            // 
            this.registerShoppingBindingSource.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // registerShoppingTableAdapter
            // 
            this.registerShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(855, 520);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(148, 44);
            this.btupdate.TabIndex = 11;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btnSP
            // 
            this.btnSP.Location = new System.Drawing.Point(1091, 520);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(121, 44);
            this.btnSP.TabIndex = 12;
            this.btnSP.Text = "Call SP";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1244, 576);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbcod);
            this.Controls.Add(this.clbshop);
            this.Controls.Add(this.rbpaid);
            this.Controls.Add(this.rbfree);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblpreferCOD);
            this.Controls.Add(this.lblmembership);
            this.Controls.Add(this.lblshoppingpreference);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.lblname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lblshoppingpreference;
        private System.Windows.Forms.Label lblpreferCOD;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Button btndelete;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btnSP;
    }

       // #endregion
    }

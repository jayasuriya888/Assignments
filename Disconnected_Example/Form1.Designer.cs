namespace Disconnected_Example
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
            this.btnselect = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.dgselect = new System.Windows.Forms.DataGridView();
            this.lbXML = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btncallsp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainingDBDataSet = new Disconnected_Example.TrainingDBDataSet();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerShoppingTableAdapter = new Disconnected_Example.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingPreferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(64, 22);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(137, 43);
            this.btnselect.TabIndex = 0;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(353, 22);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(137, 43);
            this.btupdate.TabIndex = 0;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(625, 22);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(137, 43);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "ShowXML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // dgselect
            // 
            this.dgselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgselect.Location = new System.Drawing.Point(64, 103);
            this.dgselect.Name = "dgselect";
            this.dgselect.Size = new System.Drawing.Size(698, 292);
            this.dgselect.TabIndex = 1;
            // 
            // lbXML
            // 
            this.lbXML.FormattingEnabled = true;
            this.lbXML.ItemHeight = 24;
            this.lbXML.Location = new System.Drawing.Point(803, 103);
            this.lbXML.Name = "lbXML";
            this.lbXML.Size = new System.Drawing.Size(301, 292);
            this.lbXML.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(900, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(109, 29);
            this.txtID.TabIndex = 4;
            // 
            // btncallsp
            // 
            this.btncallsp.Location = new System.Drawing.Point(1015, 28);
            this.btncallsp.Name = "btncallsp";
            this.btncallsp.Size = new System.Drawing.Size(99, 31);
            this.btncallsp.TabIndex = 5;
            this.btncallsp.Text = "Call SP";
            this.btncallsp.UseVisualStyleBackColor = true;
            this.btncallsp.Click += new System.EventHandler(this.btncallsp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.membershipDataGridViewTextBoxColumn,
            this.shoppingPreferenceDataGridViewTextBoxColumn,
            this.codDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registerShoppingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 433);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 150);
            this.dataGridView1.TabIndex = 6;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // membershipDataGridViewTextBoxColumn
            // 
            this.membershipDataGridViewTextBoxColumn.DataPropertyName = "Membership";
            this.membershipDataGridViewTextBoxColumn.HeaderText = "Membership";
            this.membershipDataGridViewTextBoxColumn.Name = "membershipDataGridViewTextBoxColumn";
            // 
            // shoppingPreferenceDataGridViewTextBoxColumn
            // 
            this.shoppingPreferenceDataGridViewTextBoxColumn.DataPropertyName = "Shopping_Preference";
            this.shoppingPreferenceDataGridViewTextBoxColumn.HeaderText = "Shopping_Preference";
            this.shoppingPreferenceDataGridViewTextBoxColumn.Name = "shoppingPreferenceDataGridViewTextBoxColumn";
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "Cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1133, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncallsp);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbXML);
            this.Controls.Add(this.dgselect);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btnselect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.DataGridView dgselect;
        private System.Windows.Forms.ListBox lbXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btncallsp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingPreferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}


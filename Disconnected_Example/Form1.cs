﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Disconnected_Example
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        string constr = "Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                string query = "SELECT * FROM RegisterShopping";
                adp = new SqlDataAdapter(query,con);
                ds = new DataSet();
                adp.Fill(ds,"Shop");
                SqlCommandBuilder builder = new SqlCommandBuilder(adp);
                adp.InsertCommand = builder.GetInsertCommand();
                adp.UpdateCommand = builder.GetUpdateCommand();
                adp.DeleteCommand = builder.GetDeleteCommand();
                //MessageBox.Show(adp.InsertCommand.CommandText);
                //MessageBox.Show(adp.UpdateCommand.CommandText);
                //MessageBox.Show(adp.DeleteCommand.CommandText);
                dgselect.DataSource = ds.Tables["Shop"];
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnXML_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show(ds.GetXml());
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            int res = adp.Update(ds.Tables["Shop"]);
            if (res > 0)
                MessageBox.Show("Data updated from DS to DB");
        }

        private void btncallsp_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_SelectRegisterShopping", con);
                cmd.CommandType = CommandType.StoredProcedure;
                int id = int.Parse(txtID.Text);
                cmd.Parameters.AddWithValue("@id",id);
                var r = cmd.ExecuteReader();
                if(r.Read())
                {
                    for(int i=0;i<r.FieldCount;i++)
                    {
                        lbXML.Items.Add(r[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }
    }
}

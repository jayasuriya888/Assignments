using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstExample
{
    public partial class Form1 : Form
    {
        TrainingDBEntities db = new TrainingDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //form data
            string name = txtname.Text;

            string gender = cbgender.SelectedItem.ToString();
            string membership = "";
            if (rbfree.Checked)
                membership = rbfree.Text;
            if (rbpaid.Checked)
                membership = rbpaid.Text;
            string preference = "";
            foreach (var d in clbshop.CheckedItems)
            {
                preference += d + ",";
            }
            string cod = "";
            if (cbcod.Checked)
                cod = "Yes";
            else
                cod = "No";
            string password = txtpassword.Text;

            MessageBox.Show(name + "\n" + gender + "\n" + membership + "\n" + preference + "\n" + cod + "\n" + password);

            //insert data to DB to entity frame work
            RegisterShopping rs = new RegisterShopping();
            rs.Name = name;
            rs.Gender = gender;
            rs.Membership = membership;
            rs.Shopping_Preference = preference;
            rs.Cod = cod;
            rs.Password = password;

            db.RegisterShoppings.Add(rs);
            var result = db.SaveChanges();
            if (result > 0)
                MessageBox.Show("Data Inserted...");
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            foreach(var t in db.RegisterShoppings)
            {
                lbselect.Items.Add(t.Id);
                lbselect.Items.Add(t.Name);
                lbselect.Items.Add(t.Gender);
                lbselect.Items.Add(t.Membership);
                lbselect.Items.Add(t.Shopping_Preference);
                lbselect.Items.Add(t.Cod);
                lbselect.Items.Add(t.Password);
                lbselect.Items.Add("**************************************");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = (int)cbid.SelectedValue;
            var del = (from t in db.RegisterShoppings where t.Id == id select t).SingleOrDefault();
            db.RegisterShoppings.Remove(del);
            var result = db.SaveChanges();
            if (result > 0)
                MessageBox.Show("Data Deleted..");
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string preference = "";
            foreach (var d in clbshop.CheckedItems)
            {
                preference += d + ",";
            }
            string cod = "";
            if (cbcod.Checked)
                cod = "Yes";
            else
                cod = "No";
            string membership = "";
            if (rbfree.Checked)
                membership = rbfree.Text;
            if (rbpaid.Checked)
                membership = rbpaid.Text;
            string password = txtpassword.Text;

            int id = (int)cbid.SelectedValue;

            var olddata = db.RegisterShoppings.Where(x => id == x.Id).SingleOrDefault();
            olddata.Membership = membership;
            olddata.Shopping_Preference = preference;
            olddata.Cod = cod;
            olddata.Password = password;
            olddata.Id = id;

            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Updated...");
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            int id = (int)cbid.SelectedValue;
            lbselect.Items.Clear();
            var res = db.sp_SelectRegisterShopping(id);
            foreach(var r in res)
            {
                lbselect.Items.Add(r.Id);
                lbselect.Items.Add(r.Name);
                lbselect.Items.Add(r.Gender);
                lbselect.Items.Add(r.Shopping_Preference);
                lbselect.Items.Add(r.Membership);
                lbselect.Items.Add(r.Cod);
                lbselect.Items.Add(r.Password);
            }
            //RegisterShopping result = (RegisterShopping) db.sp_SelectRegisterShopping(id);
            //lbselect.Items.Add(result.Id);
            //lbselect.Items.Add(result.Name);
            //lbselect.Items.Add(result.Gender);
            //lbselect.Items.Add(result.Shopping_Preference);
            //lbselect.Items.Add(result.Membership);
            //lbselect.Items.Add(result.Cod);
            //lbselect.Items.Add(result.Password);

        }
    }
}

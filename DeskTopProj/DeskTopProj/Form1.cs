using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DeskTopProj
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6LV3E2F\\SQLEXPRESS; Initial Catalog=ShopDB;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Display();


            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = @"SELECT [CategoryID]
      ,[CategoryName]
        FROM[ShopDB].[dbo].[Category]";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";


            con.Close();
        }
        private void Display()
        {
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from Products";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void Button1_Click_1(object sender, EventArgs e) // Insert Image
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
            }
        }

        private void Button2_Click_1(object sender, EventArgs e) // Insert
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload image");
                return;
            }
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = @"insert into Products ([CategoryID]
           ,[ProductName]
           ,[ImageUrl]
           ,[UnitPrice]) values ('" + comboBox1.SelectedValue + "', '" + textBox1.Text + "','"+pictureBox1.Location+"' , " + textBox2.Text +")";   
             cm.ExecuteNonQuery();
            con.Close();
            Display();
        }

        private void Button3_Click_1(object sender, EventArgs e) //Update
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload image");
                return;
            }
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "update Products set  CategoryID ='" + comboBox1.SelectedValue + "', ProductName ='" + textBox1.Text + "',ImageUrl='" + pictureBox1.Location + "', UnitPrice ='" + textBox2.Text + "' where ProductID = " + textBox3.Text + "";
            cm.ExecuteNonQuery();
            con.Close();
            Display();
        }

        private void Button4_Click_1(object sender, EventArgs e) //Delete
        {
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "delete from Products where ProductID = " + textBox3.Text + "";
            cm.ExecuteNonQuery();
            con.Close();
            Display();
        }

       
    }
}


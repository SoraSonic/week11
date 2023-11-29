using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace week11
{
    public partial class Form1 : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            connsql = KetNoi.connect();   
        }

        
        //CREATE BUTTON
        private void Create_button_Click(object sender, EventArgs e)
        {
            //check connection before opening
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();
                int Prime_num = int.Parse(Prime_number_Box.Text);
                string insertString;
                insertString = "insert into WEEK11 values ("+ Prime_num + ")";

                //execute new command
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thanh cong");
            }

            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        //UPDATE BUTTON
        private void Update_button_Click(object sender, EventArgs e)
        {
            //check connection before opening
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();
                int Prime_num = int.Parse(Prime_number_Box.Text);
                int New_Prime_num = int.Parse(New_Prime_number_Box.Text);
                string insertString;
                insertString = "update WEEK11 set Prime_num = " + New_Prime_num + " where Prime_num = " + Prime_num;

                //execute new command
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thanh cong");
            }

            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }

        }

        //READ BUTTON
        private void Read_button_Click(object sender, EventArgs e)
        {
            //check connection before opening
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();
                int Prime_num = int.Parse(Prime_number_Box.Text);
                string insertString;
                insertString = " select * from WEEK11";

                //execute new command
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                SqlDataReader reader= cmd.ExecuteReader();
                while(reader.Read())
                {
                    Read_comboBox.Items.Add(reader["MaKhoa"].ToString());
                }
                reader.Close();
                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thanh cong");
            }

            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }

        }

        //DELETE BUTTON
        private void Delete_button_Click(object sender, EventArgs e)
        {
            //check connection before opening
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();
                int Prime_num = int.Parse(Prime_number_Box.Text);
                string insertString;
                insertString = "delete from WEEK11 where Prime_num = '" + Prime_num + " ' ";

                //execute new command
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thanh cong");
            }

            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }

        }

        
    }
}

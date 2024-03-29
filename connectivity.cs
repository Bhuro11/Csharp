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

namespace Connectivity_DIVB
{
    public partial class Form1 : Form
    {
        int rowcount, recordposition = -1,id=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            recordposition = -1;
            if (btnSave.Text == "&Save")
            {
                if (txtRoll.Text != "" && txtName.Text != "")
                {
                    string sql = "insert into stud values('" + txtRoll.Text + "','" + txtName.Text + "')";
                    SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Record Isnerted!", "DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Please Enter Record!", "DB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
            }
            else
            {
                clear();
                btnSave.Text = "&Save";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            recordposition = -1;
            clear();
        }
        private void clear()
        {
            textBox1.Text =  txtRoll.Text = txtName.Text = string.Empty;
            txtRoll.Focus();
        }
        private void loaddata()
        {
            string sql = "select * from stud";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dataGridView1.DataSource = dt;
        }
        private void navigate()
        {
            string sql = "select * from stud";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtRoll.Text = dt.Rows[recordposition][1].ToString();
            txtName.Text = dt.Rows[recordposition][2].ToString();
            id = Convert.ToInt32(dt.Rows[recordposition][0]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnSave.Text = "&Insert";
            recordposition = 0;
            navigate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            btnSave.Text = "&Insert";
            if (recordposition < rowcount -1)
            {
                recordposition += 1;
                navigate();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            btnSave.Text = "&Insert";
            if (recordposition > 0)
            {
                recordposition -= 1;
                navigate();
            }
            else
            {

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (recordposition >= 0)
            {
                string sql = "update stud set roll_no='"+txtRoll.Text+"',name='"+txtName.Text+"' where id='" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clear();
                loaddata();
                recordposition = -1;
                id = 0;
            }
            else
            {
                MessageBox.Show("Please select record!");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string sql = "select * from stud where id='" + textBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                txtRoll.Text = dt.Rows[0][1].ToString();
                txtName.Text = dt.Rows[0][2].ToString();
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("No Such Record!");
                clear();
            }    
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if(recordposition >= 0)
            {
                string sql = "delete from stud where id='" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clear();
                loaddata();
                recordposition = -1;
                id = 0;
            }
            else
            {
                MessageBox.Show("Please select record!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btnSave.Text = "&Insert";
            recordposition = rowcount - 1;
            navigate();
        }
    }
}
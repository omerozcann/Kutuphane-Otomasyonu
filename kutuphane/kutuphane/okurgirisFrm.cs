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

namespace kutuphane
{
    public partial class okurgirisFrm : Form
    {
        public okurgirisFrm()
        {
            InitializeComponent();
        }

        private void okurgirisFrm_Load(object sender, EventArgs e)
        {

        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Server = DESKTOP-LCCPL96\\SQLEXPRESS; Database = kutuphane; Trusted_Connection = True;";
            sc.Open();
            String cumle = "insert into okur(adi,tel,eposta) values('" + aditxt.Text + "','" + teltxt.Text + "','" + epostatxt.Text + "')";
            SqlCommand scon = new SqlCommand();
            scon.Connection = sc;
            scon.CommandText = cumle;
            scon.ExecuteNonQuery();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Server = DESKTOP-LCCPL96\\SQLEXPRESS; Database = kutuphane; Trusted_Connection = True;";
            sc.Open();
            String cumle = "select * from okur";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cumle, sc);
            sda.Fill(ds);
            okurlardgv.DataSource = ds.Tables[0];
        }
    }
}

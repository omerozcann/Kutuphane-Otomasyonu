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
    public partial class kutuphaneFrm : Form
    {
        public kutuphaneFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kitapgirbtn_Click(object sender, EventArgs e)
        {
            kitapgirisFrm kf = new kitapgirisFrm();
            kf.Show();
        }

        private void okurgirbtn_Click(object sender, EventArgs e)
        {
            okurgirisFrm of = new okurgirisFrm();
            of.Show();
        }

        private void kitaparabtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Server = DESKTOP-LCCPL96\\SQLEXPRESS; Database = kutuphane; Trusted_Connection = True;";
            sc.Open();
            String cumle = "select * from kitap where adi like '%"+kitaparatxt.Text+"%'";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cumle, sc);
            sda.Fill(ds);
            kitaplardgv.DataSource = ds.Tables[0];
        }

        private void okurarabtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Server = DESKTOP-LCCPL96\\SQLEXPRESS; Database = kutuphane; Trusted_Connection = True;";
            sc.Open();
            String cumle = "select * from okur where adi like '%" + okuraratxt.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cumle, sc);
            sda.Fill(ds);
            okurlardgv.DataSource = ds.Tables[0];
        }

        private void oduncverbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Server = DESKTOP-LCCPL96\\SQLEXPRESS; Database = kutuphane; Trusted_Connection = True;";
            sc.Open();
            String kitapid, okurid;

            okurid = okurlardgv.Rows[okurlardgv.SelectedRows[0].Index].Cells[0].Value.ToString();
            kitapid= kitaplardgv.Rows[kitaplardgv.SelectedRows[0].Index].Cells[0].Value.ToString();
            String cumle = "insert into odunc(okurid,kitapid,almatarihi,teslimtarihi) values(" + okurid + "," + kitapid + ",'" + String.Format("{0:MM/dd/yy}", basladtp.Value) + "','" + String.Format("{0:MM/dd/yy}", bitisdtp.Value) + "')";
            //MessageBox.Show(cumle);
            SqlCommand scon = new SqlCommand();
            scon.Connection = sc;
            scon.CommandText = cumle;
            scon.ExecuteNonQuery();
        }

        private void odunclistelebtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Server = DESKTOP-LCCPL96\\SQLEXPRESS; Database = kutuphane; Trusted_Connection = True;";
            sc.Open();
            String cumle = "select * from odunc";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cumle, sc);
            sda.Fill(ds);
            oduncverdgv.DataSource = ds.Tables[0];
        }

        private void teslimbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Server = DESKTOP-LCCPL96\\SQLEXPRESS; Database = kutuphane; Trusted_Connection = True;";
            sc.Open();
            String cumle = "update odunc set teslimdurumu='Teslim Edildi' where id="+ oduncverdgv.Rows[oduncverdgv.SelectedRows[0].Index].Cells[0].Value.ToString(); ;
            SqlCommand scon = new SqlCommand();
            scon.Connection = sc;
            scon.CommandText = cumle;
            scon.ExecuteNonQuery();
        }
    }
}

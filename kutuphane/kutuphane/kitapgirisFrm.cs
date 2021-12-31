using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql server bağlantısı için

namespace kutuphane
{
    public partial class kitapgirisFrm : Form
    {
        public kitapgirisFrm()
        {
            InitializeComponent();
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
            String cumle = "insert into kitap(adi,yayinevi,turu) values('" + kitapaditxt.Text + "','" + yayinevitxt.Text + "','" + turucmb.Text + "')";
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
            String cumle = "select * from kitap";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cumle, sc);
            sda.Fill(ds);
            kitaplardgv.DataSource = ds.Tables[0];
        }
    }
}

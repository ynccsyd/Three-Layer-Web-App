using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLayer;

namespace BlockchainWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();


        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=SAMSUNG-SAMSUNG;Initial Catalog=SmartUserData;Integrated Security=True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }

        protected void BtnSave_Click1(object sender, EventArgs e)
        {

            dt = new DataTable();
            cmd.CommandText = "Insert into UserMsk(Username,Usertype,Address,ProducedEnergy,ConsumedEnergy) values ('" + txtUsername.Text.ToString() + "','" + txtUsertype.Text.ToString() + "','" + textAddress.Text.ToString() + "','" + txtProducedEnergy.Text.ToString() + "', '" + txtConsumedEnergy.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * From UserMsk ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update UserMsk set Usertype= '" + txtUsertype.Text.ToString() + "', Address= '" + txtUsertype.Text.ToString() + "',ProducedEnergy='" + txtProducedEnergy.Text.ToString() + "',ConsumedEnergy='" + txtConsumedEnergy.Text.ToString() + "' Where Username='" + txtUsername.Text.ToString() + "'";
            cmd.Connection = con;
            DataShow();
        }
        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from UserMsk where Username='" + txtUsername.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }
    }
}
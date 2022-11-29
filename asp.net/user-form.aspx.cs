using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace test_project
{
    public partial class user_form : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadRecord();
            }
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F3TPC61;Initial Catalog=programmingDB;User ID=sa;Password=dustpeo12#");

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into Student_Info values('" + int.Parse(StudentID.Text) + "','" + StudentName.Text + "','" + Address.Text + "','" + double.Parse(Age.Text) + "','" + Contact.Text + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            LoadRecord();
           
        }
        
        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("select * from Student_Info", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);

            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }
}
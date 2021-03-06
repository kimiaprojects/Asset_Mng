using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asset_Mng
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        public static string uid;
        private void Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asset_MngDataSet.کارمند' table. You can move, or remove it, as needed.
            this.کارمندTableAdapter.Fill(this.asset_MngDataSet.کارمند);
            
            SqlConnection connection = Main.connection;
            string search = "SELECT * from [کالا] WHERE [شناسه]= '" + Main.searchid + "';";
            connection.Close();

            connection.Open();
            SqlCommand command = new SqlCommand(search, connection);
            SqlDataReader reader = command.ExecuteReader();
          
            while (reader.Read())
            {



           
                //fillin asset info
                AssetID.Text =reader["شناسه"].ToString();
                
                purdate.Text = reader["تاریخ_خرید"].ToString();
                guaranty.Text = reader["اتمام_گارانتی"].ToString();
                ownership.Text = reader["مالکیت"].ToString();
                model.Text = reader["مدل"].ToString();

                st.Text = reader["زیرنوع"].ToString();
               company.Text = reader["فروشنده"].ToString();
                status.Text = reader["وضعیت"].ToString();
              
                //  hid=reader["تاریخچه"].ToString();


            }

            reader.Close();
            connection.Close();

            string settype = "SELECT نوع from زیر_نوع where نام='"+st.Text+"'";
            connection.Open();
            command.CommandText = settype;
            SqlDataReader r = command.ExecuteReader();
            r.Read();
            tt.Text=r["نوع"].ToString();
            r.Close();
            connection.Close();
            //filling vendor info
            connection.Open();
            search = "SELECT * From [فروشنده] WHERE [نام_شرکت]='" +company.Text + "';";
            command.CommandText = search;
            SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
              
                 reader1["نام_شرکت"].ToString();
                contact1.Text = reader1["رابط"].ToString();

                Vtel.Text = reader1["تلفن"].ToString();
                Vweb.Text = reader1["وب_سایت"].ToString();
             
                Vadd.Text = reader1["آدرس"].ToString();
                

            }
            reader1.Close();
            connection.Close();
           
            //filling user info
            search = "SELECT * From تاریخچه inner join کالا on [تاریخچه].[شناسه کالا]=[کالا].[شناسه] left outer join کارمند on [کارمند].[شناسه]=[تاریخچه].[شناسه کارمند] WHERE [کالا].[شناسه]='" + AssetID.Text + "';";
            connection.Open();
            command.CommandText = search;
            SqlDataReader reader2 = command.ExecuteReader();
            while (reader2.Read())
            {
                uid=reader2["شناسه"].ToString();
                Uname.Text = reader2["نام ، نام خانوادگی"].ToString();
                Utel.Text = reader2["تلفن داخلی"].ToString();
                Uemail.Text = reader2["ایمیل"].ToString();
                Uunit.Text = reader2["واحد"].ToString();
                uroom.Text = reader2["اتاق"].ToString();
                title.Text = reader2["سمت"].ToString();

            }
            reader2.Close();
            connection.Close();
            connection.Open();
            //filing history
            search = "SELECT * from تاریخچه Where [شناسه کالا]='" + Main.searchid+ "';";
            command.CommandText = search;
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText.ToString(), connection);
            DataTable dt = new DataTable();
            
            adapter.Fill(dt);
            BindingSource bs = new BindingSource(dt, null);
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;

            connection.Close();
            Main.searchid = "0";
            

          //  connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string finduser;
            string r;
            string u;
            string s;
            SqlConnection con1 = Main.connection;
            con1.Close();
            con1.Open();
            string insert = "Insert Into[تاریخچه] ([شناسه کالا],[شناسه کارمند],[تاریخ],[توضیحات],[وضعیت]) Values (@id,@uid,@date,@ds,@status); ";
            SqlCommand command = new SqlCommand(insert, con1);
           // MessageBox.Show(hid);
            command.Parameters.Add("@id", AssetID.Text);
            command.Parameters.Add("@uid",fid);
            command.Parameters.Add("@date", DateTime.Now);
            command.Parameters.Add("@ds", Hist_Disc.Text);
            command.Parameters.Add("@status",Status_Hitory.Text);
            command.ExecuteNonQuery();
            con1.Close();

            string update = "Update کالا set وضعیت='"+Status_Hitory.Text+"'  where شناسه='"+AssetID.Text+"';";
            command.CommandText = update;
            con1.Open();
            command.ExecuteNonQuery();
            con1.Close();

            //
            
            MessageBox.Show("با موفقیت ثبت شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static string fid; 
        private void Uhistory_SelectedIndexChanged(object sender, EventArgs e)
        {
           SqlConnection connection= Main.connection;
           connection.Open();
            string find= "SELECT شناسه From کارمند Where [نام ، نام خانوادگی]='"+Uhistory.Text+"'";
           SqlCommand command = new SqlCommand(find,connection);
           SqlDataReader reader = command.ExecuteReader();
           reader.Read();
            fid=reader["شناسه"].ToString();
            reader.Close();
            connection.Close();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
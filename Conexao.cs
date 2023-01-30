using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop2023
{
    internal class Conexao
    {
        protected SqlConnection conexão()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source = DESKTOP-RVQP0D6\\SQLEXPRESS; database = petshop; integrated security = true ";
            return cn;
        }

        public DataSet GetData(String consulta)
        {
            SqlConnection cn = conexão();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = consulta;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void SetData(String consulta, String sms)
        {
            SqlConnection cn = conexão();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = consulta;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(sms, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
    


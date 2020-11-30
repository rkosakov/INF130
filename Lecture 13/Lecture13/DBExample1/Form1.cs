using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBExample1
{
    public partial class MainForm : Form
    {
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private OleDbDataReader dbRearder;

        private Member aMember;

        private string sConnection;
        private string sql;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                sConnection = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                    "Data source=member.mdb";

                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();


                sql = "SELECT * FROM memberTable ORDER BY LatName ASC" +
                    ", FirstName ASC";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbRearder = dbCmd.ExecuteReader();

                while (dbRearder.Read())
                {
                    aMember = new Member(dbRearder["FirstName"].ToString(), dbRearder["LastName"].ToString());
                    this.lstBXMembers.Items.Add(aMember);
                }
                dbRearder.Close();
                dbConn.Close();

            }
            catch (System.Exception exc)
            {

                this.lblMessage.Text = exc.Message;
            }

            finally
            {
            }
        }
    }
}

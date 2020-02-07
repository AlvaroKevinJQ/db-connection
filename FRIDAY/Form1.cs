using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace FRIDAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexionbd claseC = new conexionbd();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Reset();
            Npgsql.NpgsqlDataAdapter da = claseC.comando("select * from ganancia_diaria");
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridV1.DataSource = dt;
        }
    }
}

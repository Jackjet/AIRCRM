using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable("dt1");
            dt1.Columns.Add("col1");
            dt1.Columns.Add("col2");
            ds.Tables.Add(dt1);
            dt1 = new DataTable("dt2");
            dt1.Columns.Add("col3");
            dt1.Columns.Add("col4");
            ds.Tables.Add(dt1);
            
            MessageBox.Show("");
        }
    }
}

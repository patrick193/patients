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

namespace patients3
{
    public partial class ПОИСК : Form
    {
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        int kod;
        string Name_sort;
        public ПОИСК(string name)
        {
            Name_sort = name;
            InitializeComponent();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection dc = new AutoCompleteStringCollection();
            getdata(dc);
            textBox1.AutoCompleteCustomSource = dc;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int a = 0; (ds.Tables["patients"].Columns.Count) >= a; a++)
            {
                if (Name_sort == "name")
                {
                    if (textBox1.Text == ds.Tables["patients"].Rows[a]["fio"].ToString())
                    {
                        kod = Convert.ToInt32(ds.Tables["patients"].Rows[a]["patient_id"]);
                        break;
                    }
                }
                else
                {
                    if (textBox1.Text == ds.Tables["patients"].Rows[a]["mask"].ToString())
                    {
                        kod = Convert.ToInt32(ds.Tables["patients"].Rows[a]["patient_id"]);
                        break;
                    }
                }
            }
            Form1 fr = new Form1(kod);
            fr.Show();
            this.Close();
        }

        private void ПОИСК_Load(object sender, EventArgs e)
        {
           
            

        }

        public void getdata(AutoCompleteStringCollection dc)
        {
            string cmd = "select patient_id,fio,mask from patients";
            da = new OleDbDataAdapter(cmd, connect.connstring);
            da.Fill(ds, "patients");
            DataTable dt = ds.Tables["patients"];
            for (int a = 0; (ds.Tables["patients"].Rows.Count) > a; a++)
            {
                if (Name_sort == "name")
                {
                    dc.Add(ds.Tables["patients"].Rows[a]["fio"].ToString());
                }
                else
                {
                    dc.Add(ds.Tables["patients"].Rows[a]["mask"].ToString());
                }
            }
        }

        
    }
}

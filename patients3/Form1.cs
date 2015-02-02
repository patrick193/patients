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
    public partial class Form1 : Form
    {
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        int kod_patient;
        public Form1(int kod)
        {
            CallBackMy.callBaackEventHandler = new CallBackMy.callBaackEvent(this.refresh);

            InitializeComponent();

            kod_patient = kod;
            patients();
            //ГЛАВНАЯcs find = new ГЛАВНАЯcs();
            //find.Show();
            //this.Hide();
        }

       public void refresh(string text)
        {
           //не работает update
           richTextBox1.AppendText(", " + text);
            string cmd = "update analyz set perech = '" + richTextBox1.Text + "' where analys_id=" + ds.Tables["patients"].Rows[0]["analyz_id"];
            da = new OleDbDataAdapter(cmd, connect.connstring);
        }

        public void patients()
        {
            ds.Tables.Clear();
            string cmd = "select * from patients where patient_id = " + kod_patient;
            da = new OleDbDataAdapter(cmd, connect.connstring);
            da.Fill(ds, "patients");
            DataTable dt = ds.Tables["patients"];
            textBox1.Text = ds.Tables["patients"].Rows[0]["fio"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(ds.Tables["patients"].Rows[0]["birthday"].ToString());
            maskedTextBox1.Text = ds.Tables["patients"].Rows[0]["phone"].ToString();
            textBox2.Text = ds.Tables["patients"].Rows[0]["job"].ToString();
            textBox9.Text = ds.Tables["patients"].Rows[0]["address"].ToString();
            richTextBox2.Text = ds.Tables["patients"].Rows[0]["wored"].ToString();
            if (ds.Tables["patients"].Rows[0]["sex"].ToString() == "Муж" || ds.Tables["patients"].Rows[0]["sex"].ToString() == "муж" || ds.Tables["patients"].Rows[0]["sex"].ToString() == "МУЖ")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox2.Checked = true;
            }
            //dispanser
            if (Convert.ToBoolean(ds.Tables["patients"].Rows[0]["dispanser"]) == false)
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox3.Checked = true;
            }
            //benifits

            if (ds.Tables["patients"].Rows[0]["benifits"].ToString() == "нет")
            {
                checkBox5.Checked = true;
            }
            else
            {
                checkBox6.Checked = true;
            }
            this.blood();

        }
        public void signal(int id)
        {
            string cmd = "select * from signals where signals_id = " + id;
            da = new OleDbDataAdapter(cmd, connect.connstring);
            da.Fill(ds, "signals");
            //DataTable dt = ds.Tables["signals"];
            textBox3.Text = ds.Tables["signals"].Rows[0]["transfusion"].ToString();
            textBox4.Text = ds.Tables["signals"].Rows[0]["diabet"].ToString();
            textBox5.Text = ds.Tables["signals"].Rows[0]["infection"].ToString();
            textBox6.Text = ds.Tables["signals"].Rows[0]["sirgion"].ToString();
            textBox7.Text = ds.Tables["signals"].Rows[0]["alergic"].ToString();
            textBox8.Text = ds.Tables["signals"].Rows[0]["alergic_for_preparation"].ToString();
        }

        /// <summary>
        /// blood
        /// </summary>
        public void blood()
        {
            string cmd = "select * from blood where blood_id = " + ds.Tables["patients"].Rows[0]["blood_id"].ToString();
            da = new OleDbDataAdapter(cmd, connect.connstring);
            da.Fill(ds, "blood");
            DataTable dt = ds.Tables["blood"];
            switch (ds.Tables["blood"].Rows[0]["group"].ToString())
            {
                case "1":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "2":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "3":
                    comboBox1.SelectedIndex = 2;
                    break;
                case "4":
                    comboBox1.SelectedIndex = 3;
                    break;
            }
            if (Convert.ToBoolean(ds.Tables["blood"].Rows[0]["rezus"]) == true)
            {
                radioButton7.Checked = true;
            }
            else
            {
                radioButton8.Checked = true;
            }
            this.signal(Convert.ToInt32(ds.Tables["patients"].Rows[0]["signals_id"]));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            analyz(Convert.ToInt32(ds.Tables["patients"].Rows[0]["analyz_id"]));
        }
        /// <summary>
        /// analyz
        /// </summary>
        /// <param name="analyz_id"></param>
        public void analyz(int analyz_id)
        {
            string cmd = "select * from analyz where analys_id= " + ds.Tables["patients"].Rows[0]["analyz_id"].ToString();
            da = new OleDbDataAdapter(cmd, connect.connstring);
            da.Fill(ds, "analyz");
            richTextBox1.Text = ds.Tables["analyz"].Rows[0]["perech"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            analyz an = new analyz();
            an.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CallBackMy.callBackFormHandler("closed");
        }
    }
}

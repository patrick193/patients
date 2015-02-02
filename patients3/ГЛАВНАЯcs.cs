using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patients3
{
    public partial class ГЛАВНАЯcs : Form
    {
        public ГЛАВНАЯcs()
        {
            CallBackMy.callBackFormHandler = new CallBackMy.callBackForm(this.open);
            InitializeComponent();
        }

        public void open(string state)
        {
            if (state == "closed")
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ПОИСК find = new ПОИСК("name");
            find.Show();
            this.Hide();
        }

        private void пОИМЕНИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ПОИСК find = new ПОИСК("name");
            find.Show();
            this.Hide();
        }

        private void пОШИФРУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ПОИСК find = new ПОИСК("code");
            find.Show();
            this.Hide();
        }
    }
}

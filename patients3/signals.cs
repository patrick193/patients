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
    class signals
    {
        public static DataSet get_signals(int id)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            string cmd = "select * from signals where signals_id = " + id;
            da = new OleDbDataAdapter(cmd, connect.connstring);
            return ds;
        }

    }
}

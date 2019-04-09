using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIBENTO
{
    public partial class UCPegawaiAdd : UserControl
    {
        private static UCPegawaiAdd _instance;
        public static UCPegawaiAdd Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCPegawaiAdd();
                return _instance;
            }
        }
        public void transactionData(String data)
        {
            textBox3.Text = data;
        }
        public UCPegawaiAdd()
        {
            InitializeComponent();
        }
    }
}

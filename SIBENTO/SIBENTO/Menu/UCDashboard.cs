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
    public partial class UCDashboard : UserControl
    {
        private static UCDashboard _instance;
        public static UCDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCDashboard();
                return _instance;
            }
        }
        public UCDashboard()
        {
            InitializeComponent();
        }
    }
}

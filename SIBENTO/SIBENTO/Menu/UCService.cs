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
    public partial class UCService : UserControl
    {
        private static UCService _instance;
        public static UCService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCService();
                return _instance;
            }
        }
        public UCService()
        {
            InitializeComponent();
        }
    }
}

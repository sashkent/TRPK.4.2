using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRPK._4;


namespace TRPK._4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("D:/SASHKENT/Проекты/repos/publish/TRPK.4.exe");
            Process.Start("http://localhost:5000");
            //TRPK._4.Controllers.HomeController.Index
        }
    }
}

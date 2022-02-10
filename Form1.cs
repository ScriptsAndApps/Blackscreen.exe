using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoShooterr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			Cursor.Hide();
        }
       
        private void Form1_MouseDown(object sender, EventArgs e)
        {
            Application.Exit();
		}
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)

        {
            Application.Exit();
        }
      
    }
}

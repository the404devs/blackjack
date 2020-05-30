using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBlackJack
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Close(); //to turn off current app
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();//Close application
            Application.Exit();
        }
    }
}

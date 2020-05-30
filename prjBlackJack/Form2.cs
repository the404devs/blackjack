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
    public partial class Form2 : Form
    {
       public static String playerName = "";
       Form1 frm = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /*This section sets the playerName variable to 
             * whatever the user inputted, then loads the game 
             * (Form1) and hides the name input window (Form2).*/

            playerName = txtName.Text;
            frm.Show();
            this.Hide();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            //Does the same as btnStart_Click
            if (e.KeyCode == Keys.Enter)
            {
                playerName = txtName.Text;
                frm.Show();
                this.Hide();
            }
        }
    }
}

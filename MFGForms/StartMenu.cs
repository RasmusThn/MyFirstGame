using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFGForms
{
    public partial class StartMenu : Form
    {
        private string? check = null;
        public StartMenu()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check = "Load";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check = "Create";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (check == "Create")
            {
                CreateChar createChar = new CreateChar();
                createChar.Show();
                StartMenu startMenu = this;
                startMenu.Hide();
                

            }
            else if (check == "Load")
            {

            }
            
        }

        
    }
}

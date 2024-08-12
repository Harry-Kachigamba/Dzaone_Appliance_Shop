using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzaone_Appliance_Shop
{
    public partial class Introduction_Page : Form
    {
        public Introduction_Page()
        {
            InitializeComponent();
        }

        //initializing the counting variable
        int startposition = 0;
        
        private void intro_timer_Tick(object sender, EventArgs e)
        {
            startposition += 1;
            progressBar.Value = startposition;
            Percentage.Text = startposition + "%";
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                intro_timer.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }

        }

        private void Introduction_Page_Load(object sender, EventArgs e)
        {
            //Starts counting onload
            intro_timer.Start();
        }
    }
}

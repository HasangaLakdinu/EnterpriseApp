using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ViewCheatMealReport : Form
    {
        public ViewCheatMealReport()
        {
            InitializeComponent();
        }

        private void ViewCheatMealReport_Load(object sender, EventArgs e)
        {
            cheatMealReport.DataSource = Program.CheatMealInfoList;
        }
    }
}

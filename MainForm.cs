using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processor
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeRamList();
        }

        private void InitializeRamList()
        {
            ramList.Items.Clear();
            for (int i = 0; i < 256; i++)
                ramList.Items.Add(string.Format("{0}: {1}", Convert.ToString(i, 2).PadLeft(8, '0'), "00000000"));
        }
    }
}

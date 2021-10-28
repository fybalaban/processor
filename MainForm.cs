using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static processor.Extensions;

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
                ramList.Items.Add(string.Format("{0}: {1}", Convert.ToString(i, 16).PadLeft(2, '0'), "00"));
        }

        #region RAM
        private void ReadRam(int address, string value)
        {

        }

        private void WriteRam(int address, string hexValue)
        {
            ramList.Items[address] = string.Format("{0}: {1}", CnvRespectfully(address.ToString()), hexValue);
        }
        #endregion

        private string CnvRespectfully(string value)
        {
            if (radHex.Checked is true) return value.Hex2Int().ToHex2();
            else throw new NotImplementedException();
        }

        /// <summary>
        /// Parses and loads instructions to ramList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<string> instructionList = new List<string>();

            if (!string.IsNullOrWhiteSpace(txtCode.Text))
            {
                List<string> inputLines = txtCode.Text.Trim().Split((char)10, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
                inputLines = (from x in inputLines select RemoveComment(x)).ToList(); // removes comments from lines
                instructionList = (from x in inputLines where string.IsNullOrEmpty(x) is false select x).ToList(); // drops empty elements
            }

            if (radHex.Checked is true)
            {
                instructionList = (from x in instructionList select RemoveLeading(x)).ToList();
                List<string> inst = new();
                for (int i = 0; i < instructionList.Count; i++)
                {
                    IEnumerable<string> enm = instructionList[i].Split2();
                    inst.Add(enm.ElementAt(0));
                    inst.Add(enm.ElementAt(1)); // i am quite sure that there is a much better approach but it's 1 am and i'm tired af
                }
                for (int i = 0; i < inst.Count; i++)
                {
                    WriteRam(i, inst[i]);
                }
            }
            else
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e) => InitializeRamList();
    }
}

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
            InitializeCpu();
        }

        private void InitializeRamList()
        {
            ramList.Items.Clear();
            if (radHex.Checked is true)
                for (int i = 0; i < 256; i++)
                    ramList.Items.Add(string.Format("{0}: {1}", Convert.ToString(i, 16).PadLeft(2, '0').ToUpper(), "00"));
            else
                for (int i = 0; i < 256; i++)
                    ramList.Items.Add(string.Format("{0}: {1}", Convert.ToString(i, 2).PadLeft(8, '0'), "00000000"));
        }

        private void InitializeCpu()
        {
            if (radHex.Checked is true)
            {
                txtrInstReg.Text = "00";
                txtProgCounter.Text = "00";
                for (int i = 0; i < 16; i++)
                    Controls.Find($"txtr{i:x}", true)[0].Text = "00";
            }
            else
            {
                txtrInstReg.Text = "00000000";
                txtProgCounter.Text = "00000000";
                for (int i = 0; i < 16; i++)
                    Controls.Find($"txtr{i:x}", true)[0].Text = "00000000";
            }
        }

        #region RAM
        /// <summary>
        /// Returns data as integers hold in addressed memory cell
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private int ReadRam(int address) => CnvRespectfully(ramList.Items[address].ToString().Split(':', StringSplitOptions.TrimEntries)[1]);

        /// <summary>
        /// Used by loader for writing hexadecimal/binary instructions
        /// </summary>
        /// <param name="address"></param>
        /// <param name="hexValue"></param>
        private void LoadProgram(int address, string value) => ramList.Items[address] = $"{CnvRespectfully(address)}: {value}";

        /// <summary>
        /// Write data to addressed memory cell
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        private void WriteRam(int address, int value) => ramList.Items[address] = $"{CnvRespectfully(address)}: {CnvRespectfully(value)}";
        #endregion

        /// <summary>
        /// Converts integer to hexadecimal or binary representation in text according to selected view mode
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string CnvRespectfully(int value) => radHex.Checked ? Convert.ToString(value, 16).PadLeft(2, '0').ToUpper() : Convert.ToString(value, 2).PadLeft(8, '0');

        /// <summary>
        /// Converts hexadecimal or binary representation to integer according to selected view mode
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int CnvRespectfully(string value) => radHex.Checked ? Convert.ToInt32(value, 16) : Convert.ToInt32(value, 2);

        /// <summary>
        /// Parses and loads instructions to ramList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<string> instructionList = new();

            if (!string.IsNullOrWhiteSpace(txtCode.Text))
            {
                List<string> inputLines = txtCode.Text.Trim().Split((char)10, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
                inputLines = (from x in inputLines select RemoveComment(x)).ToList(); // removes comments from lines
                instructionList = (from x in inputLines where string.IsNullOrEmpty(x) is false select x).ToList(); // drops empty elements
            }

            if (radHex.Checked is true)
            {
                instructionList = (from x in instructionList select RemoveLeading(x)).ToList();
                int j = 0;
                for (int i = 0; i < instructionList.Count; i++)
                {
                    string[] enm = instructionList[i].Split2().ToArray();
                    LoadProgram(j, enm[0]);
                    LoadProgram(j+1, enm[1]);
                    j += 2;
                }
            }
            else
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e) => InitializeRamList();

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}

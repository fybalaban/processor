using System;
using System.Collections.Generic;
using System.Linq;
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
                    ramList.Items.Add($"{Convert.ToString(i, 16).PadLeft(2, '0').ToUpper()}: 00");
            else
                for (int i = 0; i < 256; i++)
                    ramList.Items.Add($"{Convert.ToString(i, 2).PadLeft(8, '0')}: 00000000");
        }

        private void InitializeCpu()
        {
            if (radHex.Checked is true)
            {
                txtrInstReg.Text = @"0000";
                txtProgCounter.Text = @"00";
                for (int i = 0; i < 16; i++)
                    Controls.Find($"txtr{i:x}", true)[0].Text = @"00";
            }
            else
            {
                txtrInstReg.Text = @"00000000";
                txtProgCounter.Text = @"00000000";
                for (int i = 0; i < 16; i++)
                    Controls.Find($"txtr{i:x}", true)[0].Text = @"00000000";
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
        /// Reads the amount of memory cells supplied in "count", starts reading from "address". 0 for count only reads addressed memory, 1 reads addressed and next cell
        /// </summary>
        /// <param name="address"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private int ReadRam(int address, int count = 0)
        {
            string append = string.Empty;
            for (int i = 0; i <= count; i++)
                append += ramList.Items[address + i].ToString().Split(':', StringSplitOptions.TrimEntries)[1];
            return CnvRespectfully(append);
        }

        /// <summary>
        /// Used by loader for writing hexadecimal/binary instructions
        /// </summary>
        /// <param name="address"></param>
        /// <param name="hexValue"></param>
        private void LoadCode(int address, string value) => ramList.Items[address] = $"{CnvRespectfully(address, 2, 8)}: {value}";

        /// <summary>
        /// Write data to addressed memory cell
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        private void WriteRam(int address, int value) => ramList.Items[address] = $"{CnvRespectfully(address, 2, 8)}: {CnvRespectfully(value, 2, 8)}";
        #endregion

        #region Registers

        private int ReadRegister(int address) => CnvRespectfully(Controls.Find($"txtr{address:x}".ToLower(), true)[0].Text);

        private void WriteRegister(int address, int value) => Controls.Find($"txtr{address:x}".ToLower(), true)[0].Text = CnvRespectfully(value);

        private int ReadCounter() => CnvRespectfully(txtProgCounter.Text);

        private void SetCounter(int value)
        {
            txtProgCounter.Text = CnvRespectfully(value);
            SetInstRegister(ReadRam(ReadCounter(), 1));
        }

        private int[] ReadInstRegister()
        {
            int[] r = { 0, 0, 0, 0 };
            string[] a = radHex.Checked ? txtrInstReg.Text.Split1() : txtrInstReg.Text.Split4().ToArray();
            for (int i = 0; i < 4; i++)
                r[i] = CnvRespectfully(a[i]);
            return r;
        }

        private void SetInstRegister(int value) => txtrInstReg.Text = CnvRespectfully(value, 4, 16);

        #endregion
        
        /// <summary>
        /// Converts integer to hexadecimal or binary representation in text according to selected view mode
        /// </summary>
        /// <param name="value">Integer value in decimal</param>
        /// <param name="hexPad">Left "0" padding to be applied for hexadecimal representation</param>
        /// <param name="binPad">Left "0" padding to be applied for binary representation</param>
        /// <returns></returns>
        private string CnvRespectfully(int value, int hexPad = 2, int binPad = 8) => radHex.Checked ? Convert.ToString(value, 16).PadLeft(hexPad, '0').ToUpper() : Convert.ToString(value, 2).PadLeft(binPad, '0');

        /// <summary>
        /// Converts hexadecimal or binary representation to integer according to selected view mode
        /// </summary>
        /// <param name="value">Hexadecimal or binary representation string</param>
        /// <returns></returns>
        private int CnvRespectfully(string value) => radHex.Checked ? Convert.ToInt32(value, 16) : Convert.ToInt32(value, 2);

        private string AppendOperand(int x, int y) => radHex.Checked ? CnvRespectfully((x * 16) + y, 2, 8) : CnvRespectfully(5, 2, 4) + CnvRespectfully(3, 2, 4);

        /// <summary>
        /// Parses and loads instructions to ramList
        /// </summary>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text)) return;
            
            // Next line reads content from txtCode, splits it into lines using '\n' as delimiter and casts the IEnumerable to List
            List<string> inputLines = txtCode.Text.Split((char)10, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
            // Removes comments from lines, drops empty lines and sets instructionList to this new collection
            List<string> instructionList = (from x in inputLines where !string.IsNullOrEmpty(RemoveComment(x)) select RemoveComment(x)).ToList();

            if (radHex.Checked is true)
            {
                // This loads CPU instructions to RAM, starting from address 0x00 and going up to 0xFF
                LoadHexCode((from x in instructionList where x.StartsWith("0x") select x.Remove(0, 2)).ToList());
                // This executes RAM write instructions, ultimately overwriting RAM with data
                ExecuteRamWrite((from x in instructionList where x.StartsWith("1x") select x.Remove(0, 2)).ToList());
            }
            else
            {
                
            }
        }

        /// <summary>
        /// Loads hexadecimal CPU instructions to RAM
        /// </summary>
        /// <param name="codes"></param>
        private void LoadHexCode(List<string> codes)
        {
            int j = 0;
            for (int i = 0; i < codes.Count; i++)
            {
                string[] enm = codes[i].Split2().ToArray();
                LoadCode(j, enm[0]);
                LoadCode(j+1, enm[1]);
                j += 2;
            }
        }

        /// <summary>
        /// Writes data to RAM without using CPU instructions
        /// </summary>
        /// <param name="codes"></param>
        private void ExecuteRamWrite(List<string> codes)
        {
            foreach (string code in codes) // code is a 2 byte hexadecimal instruction: 1A34
            {
                string[] ia = code.Split2().ToArray();
                WriteRam(CnvRespectfully(ia[0]), CnvRespectfully(ia[1]));
            }
        }

        /// <summary>
        /// Loads binary CPU instructions to RAM
        /// </summary>
        /// <param name="codes"></param>
        private void LoadBinCode(List<string> codes)
        {
            throw new NotImplementedException();
        }

        private void btnClear_Click(object sender, EventArgs e) => InitializeRamList();

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStep.Enabled = false;
            btnClear.Enabled = false;
            btnStart.Enabled = false;
            
            do
            {
                Execute();
            } while (_status is not CpuStatus.Stopped);
        }

        private CpuStatus _status = CpuStatus.Stopped;
        
        private void btnStep_Click(object sender, EventArgs e) => Execute();

        private void Execute()
        {
            if (ReadInstRegister()[0] is 12) // Do not run method if instruction is 0xC - halt opcode
            {
                MessageBox.Show($"Reached end of execution: \ninstruction 0x{txtrInstReg.Text} at 0x{CnvRespectfully(ReadCounter())} prevents execution!",
                    "Vole Runtime");
                SetStatus(CpuStatus.Stopped);
                return;
            }
            int counter = ReadCounter();
            
            if (_status is CpuStatus.Running) // This check is useful to determine if the execution has just started or was already running
                SetCounter(counter + 2);
            else SetCounter(counter);
            SetStatus(CpuStatus.Running);
            
            int[] fields = ReadInstRegister();
            ResolveOpcode(fields[0], fields[1], fields[2], fields[3]);
        }

        private void SetStatus(CpuStatus status)
        {
            _status = status;
            lblStatus.Text = $"Status: {status}";
            if (status is CpuStatus.Stopped) // Retrieve disabled controls
            {
                btnClear.Enabled = true;
                btnStart.Enabled = true;
                btnStep.Enabled = true;
            }
        }
    }
}


namespace processor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radHex = new System.Windows.Forms.RadioButton();
            this.radBin = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnHalt = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblOpcode = new System.Windows.Forms.Label();
            this.lblOpcodeDesc = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._lblrc = new System.Windows.Forms.Label();
            this.txtrf = new System.Windows.Forms.TextBox();
            this._lblrf = new System.Windows.Forms.Label();
            this.txtr8 = new System.Windows.Forms.TextBox();
            this._lblre = new System.Windows.Forms.Label();
            this.txtr9 = new System.Windows.Forms.TextBox();
            this._lblrd = new System.Windows.Forms.Label();
            this.txtra = new System.Windows.Forms.TextBox();
            this._lblrb = new System.Windows.Forms.Label();
            this.txtrb = new System.Windows.Forms.TextBox();
            this._lblra = new System.Windows.Forms.Label();
            this.txtrc = new System.Windows.Forms.TextBox();
            this._lblr9 = new System.Windows.Forms.Label();
            this.txtrd = new System.Windows.Forms.TextBox();
            this._lblr8 = new System.Windows.Forms.Label();
            this.txtre = new System.Windows.Forms.TextBox();
            this.txtrInstReg = new System.Windows.Forms.TextBox();
            this._lblIR = new System.Windows.Forms.Label();
            this.txtProgCounter = new System.Windows.Forms.TextBox();
            this._lblPC = new System.Windows.Forms.Label();
            this._lblr7 = new System.Windows.Forms.Label();
            this.txtr7 = new System.Windows.Forms.TextBox();
            this._lblr6 = new System.Windows.Forms.Label();
            this.txtr0 = new System.Windows.Forms.TextBox();
            this._lblr5 = new System.Windows.Forms.Label();
            this.txtr1 = new System.Windows.Forms.TextBox();
            this._lblr4 = new System.Windows.Forms.Label();
            this.txtr2 = new System.Windows.Forms.TextBox();
            this._lblr3 = new System.Windows.Forms.Label();
            this.txtr3 = new System.Windows.Forms.TextBox();
            this._lblr2 = new System.Windows.Forms.Label();
            this.txtr4 = new System.Windows.Forms.TextBox();
            this._lblr1 = new System.Windows.Forms.Label();
            this.txtr5 = new System.Windows.Forms.TextBox();
            this._lblr0 = new System.Windows.Forms.Label();
            this.txtr6 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ramList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(967, 450);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radHex);
            this.groupBox2.Controls.Add(this.radBin);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 450);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // radHex
            // 
            this.radHex.AutoSize = true;
            this.radHex.Checked = true;
            this.radHex.Location = new System.Drawing.Point(70, 318);
            this.radHex.Name = "radHex";
            this.radHex.Size = new System.Drawing.Size(94, 19);
            this.radHex.TabIndex = 10;
            this.radHex.TabStop = true;
            this.radHex.Text = "Hexadecimal";
            this.radHex.UseVisualStyleBackColor = true;
            // 
            // radBin
            // 
            this.radBin.AutoSize = true;
            this.radBin.Location = new System.Drawing.Point(6, 318);
            this.radBin.Name = "radBin";
            this.radBin.Size = new System.Drawing.Size(58, 19);
            this.radBin.TabIndex = 9;
            this.radBin.TabStop = true;
            this.radBin.Text = "Binary";
            this.radBin.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(268, 316);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(6, 23);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(337, 291);
            this.txtCode.TabIndex = 6;
            this.txtCode.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblStatus);
            this.groupBox6.Controls.Add(this.btnStart);
            this.groupBox6.Controls.Add(this.btnStep);
            this.groupBox6.Controls.Add(this.btnHalt);
            this.groupBox6.Location = new System.Drawing.Point(9, 338);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(337, 100);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: {status}";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(256, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(94, 71);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(75, 23);
            this.btnStep.TabIndex = 3;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            // 
            // btnHalt
            // 
            this.btnHalt.Enabled = false;
            this.btnHalt.Location = new System.Drawing.Point(175, 71);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(75, 23);
            this.btnHalt.TabIndex = 1;
            this.btnHalt.Text = "Halt";
            this.btnHalt.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(614, 450);
            this.splitContainer2.SplitterDistance = 405;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 19);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer3.Size = new System.Drawing.Size(399, 428);
            this.splitContainer3.SplitterDistance = 155;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblOpcode);
            this.groupBox4.Controls.Add(this.lblOpcodeDesc);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 155);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // lblOpcode
            // 
            this.lblOpcode.AutoSize = true;
            this.lblOpcode.Location = new System.Drawing.Point(16, 30);
            this.lblOpcode.Name = "lblOpcode";
            this.lblOpcode.Size = new System.Drawing.Size(55, 15);
            this.lblOpcode.TabIndex = 2;
            this.lblOpcode.Text = "{opcode}";
            // 
            // lblOpcodeDesc
            // 
            this.lblOpcodeDesc.AutoSize = true;
            this.lblOpcodeDesc.Location = new System.Drawing.Point(16, 55);
            this.lblOpcodeDesc.Name = "lblOpcodeDesc";
            this.lblOpcodeDesc.Size = new System.Drawing.Size(117, 15);
            this.lblOpcodeDesc.TabIndex = 1;
            this.lblOpcodeDesc.Text = "{opcode description}";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._lblrc);
            this.groupBox5.Controls.Add(this.txtrf);
            this.groupBox5.Controls.Add(this._lblrf);
            this.groupBox5.Controls.Add(this.txtr8);
            this.groupBox5.Controls.Add(this._lblre);
            this.groupBox5.Controls.Add(this.txtr9);
            this.groupBox5.Controls.Add(this._lblrd);
            this.groupBox5.Controls.Add(this.txtra);
            this.groupBox5.Controls.Add(this._lblrb);
            this.groupBox5.Controls.Add(this.txtrb);
            this.groupBox5.Controls.Add(this._lblra);
            this.groupBox5.Controls.Add(this.txtrc);
            this.groupBox5.Controls.Add(this._lblr9);
            this.groupBox5.Controls.Add(this.txtrd);
            this.groupBox5.Controls.Add(this._lblr8);
            this.groupBox5.Controls.Add(this.txtre);
            this.groupBox5.Controls.Add(this.txtrInstReg);
            this.groupBox5.Controls.Add(this._lblIR);
            this.groupBox5.Controls.Add(this.txtProgCounter);
            this.groupBox5.Controls.Add(this._lblPC);
            this.groupBox5.Controls.Add(this._lblr7);
            this.groupBox5.Controls.Add(this.txtr7);
            this.groupBox5.Controls.Add(this._lblr6);
            this.groupBox5.Controls.Add(this.txtr0);
            this.groupBox5.Controls.Add(this._lblr5);
            this.groupBox5.Controls.Add(this.txtr1);
            this.groupBox5.Controls.Add(this._lblr4);
            this.groupBox5.Controls.Add(this.txtr2);
            this.groupBox5.Controls.Add(this._lblr3);
            this.groupBox5.Controls.Add(this.txtr3);
            this.groupBox5.Controls.Add(this._lblr2);
            this.groupBox5.Controls.Add(this.txtr4);
            this.groupBox5.Controls.Add(this._lblr1);
            this.groupBox5.Controls.Add(this.txtr5);
            this.groupBox5.Controls.Add(this._lblr0);
            this.groupBox5.Controls.Add(this.txtr6);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(399, 269);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Registers";
            // 
            // _lblrc
            // 
            this._lblrc.AutoSize = true;
            this._lblrc.Location = new System.Drawing.Point(124, 145);
            this._lblrc.Name = "_lblrc";
            this._lblrc.Size = new System.Drawing.Size(41, 15);
            this._lblrc.TabIndex = 35;
            this._lblrc.Text = "Reg C:";
            // 
            // txtrf
            // 
            this.txtrf.Enabled = false;
            this.txtrf.Location = new System.Drawing.Point(168, 229);
            this.txtrf.Name = "txtrf";
            this.txtrf.Size = new System.Drawing.Size(56, 23);
            this.txtrf.TabIndex = 27;
            this.txtrf.Text = "00000000";
            // 
            // _lblrf
            // 
            this._lblrf.AutoSize = true;
            this._lblrf.Location = new System.Drawing.Point(124, 232);
            this._lblrf.Name = "_lblrf";
            this._lblrf.Size = new System.Drawing.Size(39, 15);
            this._lblrf.TabIndex = 34;
            this._lblrf.Text = "Reg F:";
            // 
            // txtr8
            // 
            this.txtr8.Enabled = false;
            this.txtr8.Location = new System.Drawing.Point(168, 27);
            this.txtr8.Name = "txtr8";
            this.txtr8.Size = new System.Drawing.Size(56, 23);
            this.txtr8.TabIndex = 20;
            this.txtr8.Text = "00000000";
            // 
            // _lblre
            // 
            this._lblre.AutoSize = true;
            this._lblre.Location = new System.Drawing.Point(124, 203);
            this._lblre.Name = "_lblre";
            this._lblre.Size = new System.Drawing.Size(39, 15);
            this._lblre.TabIndex = 33;
            this._lblre.Text = "Reg E:";
            // 
            // txtr9
            // 
            this.txtr9.Enabled = false;
            this.txtr9.Location = new System.Drawing.Point(168, 55);
            this.txtr9.Name = "txtr9";
            this.txtr9.Size = new System.Drawing.Size(56, 23);
            this.txtr9.TabIndex = 21;
            this.txtr9.Text = "00000000";
            // 
            // _lblrd
            // 
            this._lblrd.AutoSize = true;
            this._lblrd.Location = new System.Drawing.Point(124, 174);
            this._lblrd.Name = "_lblrd";
            this._lblrd.Size = new System.Drawing.Size(41, 15);
            this._lblrd.TabIndex = 32;
            this._lblrd.Text = "Reg D:";
            // 
            // txtra
            // 
            this.txtra.Enabled = false;
            this.txtra.Location = new System.Drawing.Point(168, 84);
            this.txtra.Name = "txtra";
            this.txtra.Size = new System.Drawing.Size(56, 23);
            this.txtra.TabIndex = 22;
            this.txtra.Text = "00000000";
            // 
            // _lblrb
            // 
            this._lblrb.AutoSize = true;
            this._lblrb.Location = new System.Drawing.Point(123, 116);
            this._lblrb.Name = "_lblrb";
            this._lblrb.Size = new System.Drawing.Size(40, 15);
            this._lblrb.TabIndex = 31;
            this._lblrb.Text = "Reg B:";
            // 
            // txtrb
            // 
            this.txtrb.Enabled = false;
            this.txtrb.Location = new System.Drawing.Point(168, 113);
            this.txtrb.Name = "txtrb";
            this.txtrb.Size = new System.Drawing.Size(56, 23);
            this.txtrb.TabIndex = 23;
            this.txtrb.Text = "00000000";
            // 
            // _lblra
            // 
            this._lblra.AutoSize = true;
            this._lblra.Location = new System.Drawing.Point(123, 87);
            this._lblra.Name = "_lblra";
            this._lblra.Size = new System.Drawing.Size(41, 15);
            this._lblra.TabIndex = 30;
            this._lblra.Text = "Reg A:";
            // 
            // txtrc
            // 
            this.txtrc.Enabled = false;
            this.txtrc.Location = new System.Drawing.Point(168, 142);
            this.txtrc.Name = "txtrc";
            this.txtrc.Size = new System.Drawing.Size(56, 23);
            this.txtrc.TabIndex = 24;
            this.txtrc.Text = "00000000";
            // 
            // _lblr9
            // 
            this._lblr9.AutoSize = true;
            this._lblr9.Location = new System.Drawing.Point(123, 58);
            this._lblr9.Name = "_lblr9";
            this._lblr9.Size = new System.Drawing.Size(39, 15);
            this._lblr9.TabIndex = 29;
            this._lblr9.Text = "Reg 9:";
            // 
            // txtrd
            // 
            this.txtrd.Enabled = false;
            this.txtrd.Location = new System.Drawing.Point(168, 171);
            this.txtrd.Name = "txtrd";
            this.txtrd.Size = new System.Drawing.Size(56, 23);
            this.txtrd.TabIndex = 25;
            this.txtrd.Text = "00000000";
            // 
            // _lblr8
            // 
            this._lblr8.AutoSize = true;
            this._lblr8.Location = new System.Drawing.Point(123, 30);
            this._lblr8.Name = "_lblr8";
            this._lblr8.Size = new System.Drawing.Size(39, 15);
            this._lblr8.TabIndex = 28;
            this._lblr8.Text = "Reg 8:";
            // 
            // txtre
            // 
            this.txtre.Enabled = false;
            this.txtre.Location = new System.Drawing.Point(168, 200);
            this.txtre.Name = "txtre";
            this.txtre.Size = new System.Drawing.Size(56, 23);
            this.txtre.TabIndex = 26;
            this.txtre.Text = "00000000";
            // 
            // txtrInstReg
            // 
            this.txtrInstReg.Enabled = false;
            this.txtrInstReg.Location = new System.Drawing.Point(287, 229);
            this.txtrInstReg.Name = "txtrInstReg";
            this.txtrInstReg.Size = new System.Drawing.Size(106, 23);
            this.txtrInstReg.TabIndex = 19;
            this.txtrInstReg.Text = "0000000000000000";
            // 
            // _lblIR
            // 
            this._lblIR.AutoSize = true;
            this._lblIR.Location = new System.Drawing.Point(284, 211);
            this._lblIR.Name = "_lblIR";
            this._lblIR.Size = new System.Drawing.Size(109, 15);
            this._lblIR.TabIndex = 18;
            this._lblIR.Text = "Instruction register:";
            // 
            // txtProgCounter
            // 
            this.txtProgCounter.Enabled = false;
            this.txtProgCounter.Location = new System.Drawing.Point(287, 48);
            this.txtProgCounter.Name = "txtProgCounter";
            this.txtProgCounter.Size = new System.Drawing.Size(56, 23);
            this.txtProgCounter.TabIndex = 17;
            this.txtProgCounter.Text = "00000000";
            // 
            // _lblPC
            // 
            this._lblPC.AutoSize = true;
            this._lblPC.Location = new System.Drawing.Point(287, 30);
            this._lblPC.Name = "_lblPC";
            this._lblPC.Size = new System.Drawing.Size(100, 15);
            this._lblPC.TabIndex = 16;
            this._lblPC.Text = "Program counter:";
            // 
            // _lblr7
            // 
            this._lblr7.AutoSize = true;
            this._lblr7.Location = new System.Drawing.Point(16, 232);
            this._lblr7.Name = "_lblr7";
            this._lblr7.Size = new System.Drawing.Size(39, 15);
            this._lblr7.TabIndex = 15;
            this._lblr7.Text = "Reg 7:";
            // 
            // txtr7
            // 
            this.txtr7.Enabled = false;
            this.txtr7.Location = new System.Drawing.Point(61, 229);
            this.txtr7.Name = "txtr7";
            this.txtr7.Size = new System.Drawing.Size(56, 23);
            this.txtr7.TabIndex = 7;
            this.txtr7.Text = "00000000";
            // 
            // _lblr6
            // 
            this._lblr6.AutoSize = true;
            this._lblr6.Location = new System.Drawing.Point(16, 203);
            this._lblr6.Name = "_lblr6";
            this._lblr6.Size = new System.Drawing.Size(39, 15);
            this._lblr6.TabIndex = 14;
            this._lblr6.Text = "Reg 6:";
            // 
            // txtr0
            // 
            this.txtr0.Enabled = false;
            this.txtr0.Location = new System.Drawing.Point(61, 27);
            this.txtr0.Name = "txtr0";
            this.txtr0.Size = new System.Drawing.Size(56, 23);
            this.txtr0.TabIndex = 0;
            this.txtr0.Text = "00000000";
            // 
            // _lblr5
            // 
            this._lblr5.AutoSize = true;
            this._lblr5.Location = new System.Drawing.Point(16, 174);
            this._lblr5.Name = "_lblr5";
            this._lblr5.Size = new System.Drawing.Size(39, 15);
            this._lblr5.TabIndex = 13;
            this._lblr5.Text = "Reg 5:";
            // 
            // txtr1
            // 
            this.txtr1.Enabled = false;
            this.txtr1.Location = new System.Drawing.Point(61, 55);
            this.txtr1.Name = "txtr1";
            this.txtr1.Size = new System.Drawing.Size(56, 23);
            this.txtr1.TabIndex = 1;
            this.txtr1.Text = "00000000";
            // 
            // _lblr4
            // 
            this._lblr4.AutoSize = true;
            this._lblr4.Location = new System.Drawing.Point(16, 145);
            this._lblr4.Name = "_lblr4";
            this._lblr4.Size = new System.Drawing.Size(39, 15);
            this._lblr4.TabIndex = 12;
            this._lblr4.Text = "Reg 4:";
            // 
            // txtr2
            // 
            this.txtr2.Enabled = false;
            this.txtr2.Location = new System.Drawing.Point(61, 84);
            this.txtr2.Name = "txtr2";
            this.txtr2.Size = new System.Drawing.Size(56, 23);
            this.txtr2.TabIndex = 2;
            this.txtr2.Text = "00000000";
            // 
            // _lblr3
            // 
            this._lblr3.AutoSize = true;
            this._lblr3.Location = new System.Drawing.Point(16, 116);
            this._lblr3.Name = "_lblr3";
            this._lblr3.Size = new System.Drawing.Size(39, 15);
            this._lblr3.TabIndex = 11;
            this._lblr3.Text = "Reg 3:";
            // 
            // txtr3
            // 
            this.txtr3.Enabled = false;
            this.txtr3.Location = new System.Drawing.Point(61, 113);
            this.txtr3.Name = "txtr3";
            this.txtr3.Size = new System.Drawing.Size(56, 23);
            this.txtr3.TabIndex = 3;
            this.txtr3.Text = "00000000";
            // 
            // _lblr2
            // 
            this._lblr2.AutoSize = true;
            this._lblr2.Location = new System.Drawing.Point(16, 87);
            this._lblr2.Name = "_lblr2";
            this._lblr2.Size = new System.Drawing.Size(39, 15);
            this._lblr2.TabIndex = 10;
            this._lblr2.Text = "Reg 2:";
            // 
            // txtr4
            // 
            this.txtr4.Enabled = false;
            this.txtr4.Location = new System.Drawing.Point(61, 142);
            this.txtr4.Name = "txtr4";
            this.txtr4.Size = new System.Drawing.Size(56, 23);
            this.txtr4.TabIndex = 4;
            this.txtr4.Text = "00000000";
            // 
            // _lblr1
            // 
            this._lblr1.AutoSize = true;
            this._lblr1.Location = new System.Drawing.Point(16, 58);
            this._lblr1.Name = "_lblr1";
            this._lblr1.Size = new System.Drawing.Size(39, 15);
            this._lblr1.TabIndex = 9;
            this._lblr1.Text = "Reg 1:";
            // 
            // txtr5
            // 
            this.txtr5.Enabled = false;
            this.txtr5.Location = new System.Drawing.Point(61, 171);
            this.txtr5.Name = "txtr5";
            this.txtr5.Size = new System.Drawing.Size(56, 23);
            this.txtr5.TabIndex = 5;
            this.txtr5.Text = "00000000";
            // 
            // _lblr0
            // 
            this._lblr0.AutoSize = true;
            this._lblr0.Location = new System.Drawing.Point(16, 30);
            this._lblr0.Name = "_lblr0";
            this._lblr0.Size = new System.Drawing.Size(39, 15);
            this._lblr0.TabIndex = 8;
            this._lblr0.Text = "Reg 0:";
            // 
            // txtr6
            // 
            this.txtr6.Enabled = false;
            this.txtr6.Location = new System.Drawing.Point(61, 200);
            this.txtr6.Name = "txtr6";
            this.txtr6.Size = new System.Drawing.Size(56, 23);
            this.txtr6.TabIndex = 6;
            this.txtr6.Text = "00000000";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ramList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 450);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RAM";
            // 
            // ramList
            // 
            this.ramList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ramList.FormattingEnabled = true;
            this.ramList.ItemHeight = 15;
            this.ramList.Items.AddRange(new object[] {
            "00000000: 00000000",
            "00000001: 00000000"});
            this.ramList.Location = new System.Drawing.Point(3, 19);
            this.ramList.Name = "ramList";
            this.ramList.Size = new System.Drawing.Size(199, 428);
            this.ramList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Vole by ferityigitbalaban";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ramList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHalt;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtrInstReg;
        private System.Windows.Forms.Label _lblIR;
        private System.Windows.Forms.TextBox txtProgCounter;
        private System.Windows.Forms.Label _lblPC;
        private System.Windows.Forms.Label _lblr7;
        private System.Windows.Forms.TextBox txtr7;
        private System.Windows.Forms.Label _lblr6;
        private System.Windows.Forms.TextBox txtr0;
        private System.Windows.Forms.Label _lblr5;
        private System.Windows.Forms.TextBox txtr1;
        private System.Windows.Forms.Label _lblr4;
        private System.Windows.Forms.TextBox txtr2;
        private System.Windows.Forms.Label _lblr3;
        private System.Windows.Forms.TextBox txtr3;
        private System.Windows.Forms.Label _lblr2;
        private System.Windows.Forms.TextBox txtr4;
        private System.Windows.Forms.Label _lblr1;
        private System.Windows.Forms.TextBox txtr5;
        private System.Windows.Forms.Label _lblr0;
        private System.Windows.Forms.TextBox txtr6;
        private System.Windows.Forms.Label lblOpcodeDesc;
        private System.Windows.Forms.Label _lblrc;
        private System.Windows.Forms.TextBox txtrf;
        private System.Windows.Forms.Label _lblrf;
        private System.Windows.Forms.TextBox txtr8;
        private System.Windows.Forms.Label _lblre;
        private System.Windows.Forms.TextBox txtr9;
        private System.Windows.Forms.Label _lblrd;
        private System.Windows.Forms.TextBox txtra;
        private System.Windows.Forms.Label _lblrb;
        private System.Windows.Forms.TextBox txtrb;
        private System.Windows.Forms.Label _lblra;
        private System.Windows.Forms.TextBox txtrc;
        private System.Windows.Forms.Label _lblr9;
        private System.Windows.Forms.TextBox txtrd;
        private System.Windows.Forms.Label _lblr8;
        private System.Windows.Forms.TextBox txtre;
        private System.Windows.Forms.Label lblOpcode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton radHex;
        private System.Windows.Forms.RadioButton radBin;
    }
}


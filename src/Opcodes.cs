using System;
using processor.Properties;

namespace processor
{
    public partial class MainForm
    {
        private void ResolveOpcode(int opcode, int r, int x, int y)
        {
            switch (opcode)
            {
                case 1:
                    Op1(r, x, y);
                    break;
                case 2:
                    Op2(r, x, y);
                    break;
                case 3:
                    Op3(r, x, y);
                    break;
                case 4:
                    Op4(r, x, y);
                    break;
                case 5:
                    Op5(r, x, y);
                    break;
                case 6:
                    Op6(r, x, y);
                    break;
                case 7:
                    Op7(r, x, y);
                    break;
                case 8:
                    Op8(r, x, y);
                    break;
                case 9:
                    Op9(r, x, y);
                    break;
                case 10:
                    OpA(r, x, y);
                    break;
                case 11:
                    OpB(r, x, y);
                    break;
                case 12:
                    OpC(r, x, y);
                    break;
            }
        }

        #region Opcode Methods
        private void Op1(int r, int x, int y)
        {
            lblOpcode.Text = @"0x1";
            lblOpcodeDesc.Text = Resources._0x1En;

            int val = ReadRam(x * 16 + y);
            WriteRegister(r, val);
        }

        private void Op2(int r, int x, int y)
        {
            lblOpcode.Text = @"0x2";
            lblOpcodeDesc.Text = Resources._0x2En;
            
            int val = x * 16 + y;
            WriteRegister(r, val);
        }

        private void Op3(int r, int x, int y)
        {
            lblOpcode.Text = @"0x3";
            lblOpcodeDesc.Text = Resources._0x3En;

            int val = ReadRegister(r);
            WriteRam(x * 16 + y, val);
        }

        private void Op4(int _, int r, int s)
        {
            lblOpcode.Text = @"0x4";
            lblOpcodeDesc.Text = Resources._0x4En;
            
            WriteRegister(s, ReadRegister(r));
        }

        private void Op5(int r, int s, int t)
        {
            lblOpcode.Text = @"0x5";
            lblOpcodeDesc.Text = Resources._0x5En;

            sbyte result = (sbyte)(Convert.ToSByte(ReadRegister(s)) + Convert.ToSByte(ReadRegister(t)));
            WriteRegister(r, result);
        }

        private void Op6(int r, int s, int t)
        {
            lblOpcode.Text = @"0x6";
            lblOpcodeDesc.Text = Resources._0x6En;

            double storedS = Extensions.CalculateBinFloat(Convert.ToString(ReadRegister(s), 2));
            double storedT = Extensions.CalculateBinFloat(Convert.ToString(ReadRegister(t), 2));
            double sum = storedS + storedT;
            throw new NotImplementedException();
        }

        private void Op7(int r, int s, int t)
        {
            lblOpcode.Text = @"0x7";
            lblOpcodeDesc.Text = Resources._0x7En;

            int registerS = ReadRegister(s);
            int registerT = ReadRegister(t);

            char[] bS = Convert.ToString(registerS, 2).PadLeft(8, '0').ToCharArray();
            char[] bT = Convert.ToString(registerT, 2).PadLeft(8, '0').ToCharArray();
            char[] bR = new char[8];

            for (int i = 0; i < 8; i++)
            {
                bR[i] = Extensions.BooleanOr(int.Parse(bS[i].ToString()), int.Parse(bT[i].ToString())).ToString()[0];
            }

            string bRstr = new(bR);
            WriteRegister(r, Convert.ToInt32(bRstr, 2));
        }

        private void Op8(int r, int s, int t)
        {
            lblOpcode.Text = @"0x8";
            lblOpcodeDesc.Text = Resources._0x8En;
            
            int registerS = ReadRegister(s);
            int registerT = ReadRegister(t);

            char[] bS = Convert.ToString(registerS, 2).PadLeft(8, '0').ToCharArray();
            char[] bT = Convert.ToString(registerT, 2).PadLeft(8, '0').ToCharArray();
            char[] bR = new char[8];

            for (int i = 0; i < 8; i++)
            {
                bR[i] = Extensions.BooleanAnd(int.Parse(bS[i].ToString()), int.Parse(bT[i].ToString())).ToString()[0];
            }

            string bRstr = new(bR);
            WriteRegister(r, Convert.ToInt32(bRstr, 2));
        }

        private void Op9(int r, int s, int t)
        {
            lblOpcode.Text = @"0x9";
            lblOpcodeDesc.Text = Resources._0x9En;
            int registerS = ReadRegister(s);
            int registerT = ReadRegister(t);

            char[] bS = Convert.ToString(registerS, 2).PadLeft(8, '0').ToCharArray();
            char[] bT = Convert.ToString(registerT, 2).PadLeft(8, '0').ToCharArray();
            char[] bR = new char[8];

            for (int i = 0; i < 8; i++)
            {
                bR[i] = Extensions.BooleanXor(int.Parse(bS[i].ToString()), int.Parse(bT[i].ToString())).ToString()[0];
            }
            WriteRegister(r, Convert.ToInt32(new string(bR), 2));
        }

        private void OpA(int r, int x, int y)
        {
            lblOpcode.Text = @"0xA";
            lblOpcodeDesc.Text = Resources._0xAEn;
            throw new NotImplementedException();
        }

        private void OpB(int r, int x, int y)
        {
            lblOpcode.Text = @"0xB";
            lblOpcodeDesc.Text = Resources._0xBEn;
            throw new NotImplementedException();
        }

        private void OpC(int r, int x, int y)
        {
            lblOpcode.Text = @"0xC";
            lblOpcodeDesc.Text = Resources._0xCEn;
        }
        #endregion
    }
}
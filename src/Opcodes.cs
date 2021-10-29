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
                default:
                    break;
            }
        }

        #region Opcode Methods
        private void Op1(int r, int x, int y)
        {
            lblOpcode.Text = $"0x1";
            lblOpcodeDesc.Text = Resources._0x1En;
        }

        private void Op2(int r, int x, int y)
        {
            lblOpcode.Text = $"0x2";
            lblOpcodeDesc.Text = Resources._0x2En;
        }

        private void Op3(int r, int x, int y)
        {
            lblOpcode.Text = $"0x3";
            lblOpcodeDesc.Text = Resources._0x3En;
        }

        private void Op4(int r, int x, int y)
        {
            lblOpcode.Text = $"0x4";
            lblOpcodeDesc.Text = Resources._0x4En;
        }

        private void Op5(int r, int x, int y)
        {
            lblOpcode.Text = $"0x5";
            lblOpcodeDesc.Text = Resources._0x5En;
        }

        private void Op6(int r, int x, int y)
        {
            lblOpcode.Text = $"0x6";
            lblOpcodeDesc.Text = Resources._0x6En;
        }

        private void Op7(int r, int x, int y)
        {
            lblOpcode.Text = $"0x7";
            lblOpcodeDesc.Text = Resources._0x7En;
        }

        private void Op8(int r, int x, int y)
        {
            lblOpcode.Text = $"0x8";
            lblOpcodeDesc.Text = Resources._0x8En;
        }

        private void Op9(int r, int x, int y)
        {
            lblOpcode.Text = $"0x9";
            lblOpcodeDesc.Text = Resources._0x9En;
        }

        private void OpA(int r, int x, int y)
        {
            lblOpcode.Text = $"0xA";
            lblOpcodeDesc.Text = Resources._0xAEn;
        }

        private void OpB(int r, int x, int y)
        {
            lblOpcode.Text = $"0xB";
            lblOpcodeDesc.Text = Resources._0xBEn;
        }

        private void OpC(int r, int x, int y)
        {
            lblOpcode.Text = $"0xC";
            lblOpcodeDesc.Text = Resources._0xCEn;
        }
        #endregion
    }
}
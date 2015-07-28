using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDBB
{
    public partial class formEditNative : Form
    {
        public delegate void DelUpdateFunction(String hash, NativeFunction newFunction);
        DelUpdateFunction updateFunc;
        NativeFunction Function { get; set; }

        public formEditNative(NativeFunction pfunction, formMain pparentform)
        {
            InitializeComponent();
            Function = pfunction;
            updateFunc = new DelUpdateFunction(pparentform.UpdateNative);
        }

        private void formEditNative_Load(object sender, EventArgs e)
        {
            txtHash.Text = Function.Hash;
            txtName.Text = Function.Name;
            txtResult.Text = Function.Result;

            numParam.Maximum = Function.Params.Count - 1;
            if (Function.Params.Count > 0)
            {
                txtPType.Text = Function.Params[0].Type;
                txtPName.Text = Function.Params[0].Name;
            }
            else
                numParam.Enabled = txtPName.Enabled = txtPType.Enabled = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Function.Name = txtName.Text;
            Function.Result = txtResult.Text;

            updateFunc(Function.Hash, Function);
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numParam_ValueChanged(object sender, EventArgs e)
        {
            if (numParam.Enabled)
            {
                txtPType.Text = Function.Params[(int)numParam.Value].Type;
                txtPName.Text = Function.Params[(int)numParam.Value].Name;
            }
        }

        private void txtPType_TextChanged(object sender, EventArgs e)
        {
            Function.Params[(int)numParam.Value].Type = txtPType.Text;
        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {
            Function.Params[(int)numParam.Value].Name = txtPName.Text;
        }
    }
}

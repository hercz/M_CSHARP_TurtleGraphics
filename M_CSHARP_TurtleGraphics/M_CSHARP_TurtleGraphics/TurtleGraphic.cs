using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace M_CSHARP_TurtleGraphics
{
    public partial class TurtleGraphic : Form
    {
        public FileHandler Handler { get; }


        public TurtleGraphic()
        {
            InitializeComponent();
            Handler = new FileHandler(load_OpenFileDialog, commands_listbox);
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            Handler.FillCommandList_TextBox();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

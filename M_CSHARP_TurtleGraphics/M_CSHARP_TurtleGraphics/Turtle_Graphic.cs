using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_CSHARP_TurtleGraphics
{
    public partial class Turtle_Graphic : Form
    {
        private FileHandler fileHandler;


        public Turtle_Graphic()
        {
            InitializeComponent();
            fileHandler = new FileHandler(openFileDialog1, commands_listbox);
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            fileHandler.FillCommandList_TextBox();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

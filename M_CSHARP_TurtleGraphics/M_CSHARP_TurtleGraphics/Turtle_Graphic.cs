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
        public Turtle_Graphic()
        {
            InitializeComponent();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    FileReader.SplitTextFileToCommands(text);
                    foreach (var command in FileReader.SplittedCommands)
                    {
                        commands_listbox.Items.Add(command);
                    }
                   
                }
                catch (IOException)
                {
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

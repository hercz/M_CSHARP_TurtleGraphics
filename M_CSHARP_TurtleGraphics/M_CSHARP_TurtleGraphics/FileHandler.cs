using System.IO;
using System.Windows.Forms;

namespace M_CSHARP_TurtleGraphics
{
    class FileHandler
    {
        public OpenFileDialog Dialog { get; }
        public ListBox ListBox { get; }


        public FileHandler(OpenFileDialog dialog, ListBox listBox)
        {
            Dialog = dialog;
            ListBox = listBox;
        }

        public void FillCommandList_TextBox()
        {            
            DialogResult result = Dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = Dialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    GetSplittedCommand(text);
                }
                catch (IOException)
                {
                }
            }
        }

        private void GetSplittedCommand(string text)
        {
            const char delimiter = ',';
            var splittedCommands = text.Split(delimiter);
            foreach (var command in splittedCommands)
            {
                ListBox.Items.Add(command);
            }
        }
    }
}

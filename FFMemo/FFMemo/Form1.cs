using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FFMemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void transButton_Click(object sender, EventArgs e)
        {
            string from = fromText.Text;
            toText.Text = getChatLine(from);
        }

        private string getChatLine(string allChat)
        {
            var timestampRegex = new Regex(@"\[\d\d:\d\d\] \(");
            var lineRegex = new Regex(@"^(\([].+\) )");

            string chatCopy = timestampRegex.Replace(allChat, "\r\n(");
            string[] chatLines = chatCopy.Split("\r\n");

            string fromChat = "";
            foreach (string line in chatLines)
            {
                fromChat += lineRegex.Replace(line, "/p ");
                fromChat += "\r\n";
            }

            return fromChat;
        }
    }
}

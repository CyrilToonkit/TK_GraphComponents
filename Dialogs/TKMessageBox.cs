using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents.Dialogs
{
    public class TKMessageBox
    {
        public static DialogResult ShowError(string Message, string Caption)
        {
            return MessageBox.Show(Message, Caption,MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Confirm(string Message, string Caption)
        {
            return MessageBox.Show(Message, Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}

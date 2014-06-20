using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents.Dialogs
{
    public class TKMessageBox
    {
        public static DialogResult ShowMessage(string Message, string Caption)
        {
            LongMessageForm form = new LongMessageForm();
            form.Text = Caption;
            form.Message = Message;

            return form.ShowDialog();
        }

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

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents.Dialogs
{
    public enum InputTypes
    {
        String, Float, Double, Int, Bool
    }

    public class RichDialogResult
    {
        DialogResult _result = DialogResult.None;
        object _data = null;

        public RichDialogResult(DialogResult inResult, object inData)
        {
            _result = inResult;
            _data = inData;
        }

        public DialogResult Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public object Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }

    public class TKMessageBox
    {
        public static RichDialogResult ShowInput(InputTypes inType, string Message, string Caption)
        {
            TextInputForm form = new TextInputForm(Message, Caption, "");
            DialogResult result = form.ShowDialog();
            return new RichDialogResult(result, form.InputValue);
        }

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

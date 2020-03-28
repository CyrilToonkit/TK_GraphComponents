using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib;

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
        public static RichDialogResult ShowInput(InputTypes inType, string Message, string Caption, string defaultValue)
        {
            object castedObject = null;

            DialogResult result = DialogResult.Abort;
            TextInputForm form = null;

            while(castedObject == null)
            {
                form = new TextInputForm(Message, Caption, "");
                form.StartPosition = FormStartPosition.Manual;
                form.Location = form.PointToClient(Cursor.Position);
                form.InputValue = defaultValue;
                form.TopMost = true;

                result = form.ShowDialog();

                if(result != DialogResult.OK)
                {
                    break;
                }

                switch (inType)
                {
                    case InputTypes.Double:
                        try
                        {
                            double castedDouble = TypesHelper.DoubleParse(form.InputValue);
                            castedObject = castedDouble;
                        }
                        catch(Exception)
                        {
                            TKMessageBox.ShowError("Cannot cast " + form.InputValue + " as a double !!", "Type error");
                        }
                        break;
                    case InputTypes.Float:
                        try
                        {

                            float castedFloat = TypesHelper.FloatParse(form.InputValue);
                            castedObject = castedFloat;
                        }
                        catch (Exception)
                        {
                            TKMessageBox.ShowError("Cannot cast " + form.InputValue + " as a float !!", "Type error");
                        }
                        break;
                    case InputTypes.Bool:
                        try
                        {
                            bool castedBool = Convert.ToBoolean(form.InputValue);
                            castedObject = castedBool;
                        }
                        catch (Exception)
                        {
                            TKMessageBox.ShowError("Cannot cast " + form.InputValue + " as a bool !!", "Type error");
                        }
                        break;
                    case InputTypes.Int:
                        try
                        {
                            int castedInt = Int32.Parse(form.InputValue);
                            castedObject = castedInt;
                        }
                        catch (Exception)
                        {
                            TKMessageBox.ShowError("Cannot cast " + form.InputValue + " as a int !!", "Type error");
                        }
                        break;
                    default:
                        castedObject = form.InputValue;
                        break;
                }
            }

            return new RichDialogResult(result, castedObject);
        }

        public static RichDialogResult ShowInput(InputTypes inType, string Message, string Caption)
        {
            return ShowInput(inType, Message, Caption, "");
        }

        public static DialogResult ShowMessage(string Message, string Caption)
        {
            return  ShowMessage(Message, Caption, true);
        }

        public static DialogResult ShowMessage(string Message, string Caption, bool modal)
        {
            LongMessageForm form = new LongMessageForm();
            form.Text = Caption;
            form.Message = Message;
            form.TopMost = true;

            form.SetDesiredStartLocation(Cursor.Position.X, Cursor.Position.Y);

            if (modal)
            {
                return form.ShowDialog();
            }

            form.Show();

            return DialogResult.None;
        }

        /// <summary>
        /// Show a Dialog in a form with a multi-line textbox for the message
        /// Returns : DialogResult.OK if "OK" pressed, DialogResult.Cancel if "Cancel" pressed, eventually DialogResult.Yes if "option" is clicked
        /// </summary>
        /// <param name="Message"></param>
        /// <param name="Caption"></param>
        /// <param name="ShowButtons"></param>
        /// <param name="OptionText"></param>
        /// <returns>DialogResult.OK if "OK" pressed, DialogResult.Cancel if "Cancel" pressed, eventually DialogResult.Yes if "option" is clicked</returns>
        public static DialogResult ShowDialog(string Message, string Caption, bool ShowButtons, string OptionText)
        {
            LongMessageForm form = new LongMessageForm();
            form.Text = Caption;
            form.Message = Message;
            form.TopMost = true;

            form.ShowButtons = ShowButtons;
            form.OptionText = OptionText;

            return form.ShowDialog();
        }

        public static DialogResult ShowError(string Message, string Caption)
        {
            return MessageBox.Show(Message, Caption,MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Confirm(string Message, string Caption)
        {
            return MessageBox.Show(Message, Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK;
        }
    }
}

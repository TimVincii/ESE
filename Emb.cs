using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESE
{
    /// <summary>
    /// Emb stand for "Easy Message Boxes".
    /// this class will be used for a quick and efficient way to call
    /// pre-made message boxes.
    /// </summary>
    public class Emb
    {
        private string _message;
        private string _title;
        private MessageBoxButtons _buttons;
        private MessageBoxIcon _icon;

       private Emb(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            _message = message;
            _title = title;
            _buttons = buttons;
            _icon = icon;
        }

        public static Emb MakeErrorBox(string message)
        {
            return new Emb(message + "\nExiting...", "!..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static Emb MakeInfoBox(string message)
        {
            return new Emb(message, "..ⓘ..", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static Emb MakeQuestionBox(string message)
        {
            return new Emb(message, "?..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Show() 
        {
            MessageBox.Show(_message, _title, _buttons, _icon);
        }
        public DialogResult Result()
        {
            DialogResult result = MessageBox.Show(_message, _title, _buttons, _icon);
            return result;
        }
    }
}

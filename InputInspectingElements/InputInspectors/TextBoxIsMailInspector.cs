﻿using System.Net.Mail;

namespace InputInspectingElements.InputInspectors
{
    public class TextBoxIsMailInspector : TextBoxInspector
    {
        private const string ERROR_TEXT_BOX_IS_NOT_MAIL = "Textbox is not an email.";

        public TextBoxIsMailInspector(string textData, int maxTextLengthData) : base(textData, maxTextLengthData)
        {
            /* Body intentionally empty */
        }

        /// <summary>
        /// Return true if the textbox is a valid email.
        /// </summary>
        public override bool IsValid()
        {
            try
            {
                var email = new MailAddress(_text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Return the error of this inspector.
        /// </summary>
        public override string GetError()
        {
            return ERROR_TEXT_BOX_IS_NOT_MAIL;
        }
    }
}

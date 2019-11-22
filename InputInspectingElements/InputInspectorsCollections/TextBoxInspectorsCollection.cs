﻿using InputInspectingElements.InputInspectors;
using System;

namespace InputInspectingElements.InputInspectorsCollections
{
    public class TextBoxInspectorsCollection : InputInspectorsCollection
    {
        private const string ERROR_TEXT_BOX_INSPECTOR_TYPE_FLAG_IS_OUT_OF_RANGE = "The given textbox inspector type flag is out of range.";

        /// <summary>
        /// Add textbox inspectors by textBoxInspectorTypeFlag.
        /// </summary>
        public void AddTextBoxInspectors(int textBoxInspectorTypeFlag, string text, int maxTextLength)
        {
            if ( !InputInspectorTypeHelper.IsInRangeOfTextBoxInspectorTypes(textBoxInspectorTypeFlag) )
            {
                throw new ArgumentOutOfRangeException(ERROR_TEXT_BOX_INSPECTOR_TYPE_FLAG_IS_OUT_OF_RANGE);
            }
            if ( InputInspectorTypeHelper.IsContainingTextBoxIsMailFlag(textBoxInspectorTypeFlag) )
            {
                _inspectors.Add(new TextBoxIsMailInspector(text, maxTextLength));
            }
            if ( InputInspectorTypeHelper.IsContainingTextBoxIsNotEmptyFlag(textBoxInspectorTypeFlag) )
            {
                _inspectors.Add(new TextBoxIsNotEmptyInspector(text, maxTextLength));
            }
            if ( InputInspectorTypeHelper.IsContainingTextBoxIsOfFullLengthFlag(textBoxInspectorTypeFlag) )
            {
                _inspectors.Add(new TextBoxIsOfFullLengthInspector(text, maxTextLength));
            }
        }

        /// <summary>
        /// Update textbox inspectors.
        /// </summary>
        public void Update(string text, int maxLength)
        {
            foreach ( TextBoxInspector inspector in _inspectors )
            {
                inspector.Set(text, maxLength);
            }
        }
    }
}

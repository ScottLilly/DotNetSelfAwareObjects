using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Workbench
{
    internal static class Extensions
    {
        internal static void BindTextPropertyTo(this TextBox textBox, object businessObject, string propertyName)
        {
            textBox.DataBindings.Add("Text", businessObject, propertyName, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        internal static string ListToString(this IEnumerable<string> messages)
        {
            return messages.Aggregate("", (current, message) => current + (message + Environment.NewLine));
        }
    }
}

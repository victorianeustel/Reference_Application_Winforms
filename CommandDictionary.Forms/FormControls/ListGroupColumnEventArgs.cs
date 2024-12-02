using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandDictionary.FormControls
{
    public class ListGroupColumnEventArgs : EventArgs
    {
        public ListGroupColumnEventArgs(int Columnindex)
        {
            this.ColumnIndex = ColumnIndex;
        }

        public int ColumnIndex { get; set; }
    }
}

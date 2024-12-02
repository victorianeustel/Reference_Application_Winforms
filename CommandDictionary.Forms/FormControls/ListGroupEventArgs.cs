using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandDictionary.FormControls
{
    class ListGroupEventArgs : System.EventArgs
    {
        public ListGroupEventArgs(ListGroup ListGroup)
        {

        }


        public ListGroup ListGroup { get; set; }
    }
}

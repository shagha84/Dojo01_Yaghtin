using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo01_Yaghtin
{
    class StapelElement<T>
    {
        public T ValueOfElement { get; set; } //Stores the value of the stack entry
        public StapelElement<T> Successor { get; set; } //points to the successor of this entry => the entry which was added before this one
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_6_Senior_Project
{
    internal class WindowChanger
    {
        /*
         * ChangeWindows
         * orig (Form): Original Form used for the program, it will close the window afterwards.
         * dest (Form): The new Form window that will be used.
         * 
         * changeWindows swaps between Forms by changed the FormClosed condition to equal the original form windows.
         * This makes it when the new window is closed, the program will closed as well.
         * This is only used 
         */
        public void changeWindows(Form orig, Form dest)
        {
            orig.Visible = false;
            dest.FormClosed += (s, args) => orig.Close();
            dest.Show();
        }
    }
}

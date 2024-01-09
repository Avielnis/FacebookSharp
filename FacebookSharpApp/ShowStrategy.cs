﻿using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ShowStrategy : IControlPropertyChangeStrategy
    {
        public void ChangeProperty(Control i_Control)
        {
            i_Control.Visible = true;
        }
    }
}
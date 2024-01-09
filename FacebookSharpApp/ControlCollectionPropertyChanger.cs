using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ControlCollectionPropertyChanger
    {
        public IControlPropertyChangeStrategy ChangeStrategy { get; set; }

        public ControlCollectionPropertyChanger(IControlPropertyChangeStrategy i_ChangeStrategy)
        {
            ChangeStrategy = i_ChangeStrategy;
        }

        public void ChangeAllControls(Control.ControlCollection i_ControlCollection)
        {
            foreach (Control control in i_ControlCollection)
            {
                control.Invoke(new Action(() => ChangeStrategy.ChangeProperty(control)));
            }
        }
    }
}
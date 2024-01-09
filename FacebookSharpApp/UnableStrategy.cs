using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class UnableStrategy : IControlPropertyChangeStrategy
    {
        public void ChangeProperty(Control i_Control)
        {
            i_Control.Enabled = false;
        }
    }
}
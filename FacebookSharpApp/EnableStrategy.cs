using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class EnableStrategy : IControlPropertyChangeStrategy
    {
        public void ChangeProperty(Control i_Control)
        {
            i_Control.Enabled = true;
        }
    }
}
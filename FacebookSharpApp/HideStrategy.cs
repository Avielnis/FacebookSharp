using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class HideStrategy : IControlPropertyChangeStrategy
    {
        public void ChangeProperty(Control i_Control)
        {
            i_Control.Visible = false;
        }
    }
}
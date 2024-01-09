using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public interface IControlPropertyChangeStrategy
    {
        void ChangeProperty(Control i_Control);
    }
}
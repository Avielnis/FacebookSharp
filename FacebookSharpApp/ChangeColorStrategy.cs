using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ChangeColorStrategy : IControlPropertyChangeStrategy
    {
        public Color Color { get; set; }

        public ChangeColorStrategy(Color i_Color)
        {
            Color = i_Color;
        }

        public void ChangeProperty(Control i_Control)
        {
            i_Control.BackColor = Color;
        }
    }
}
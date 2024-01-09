using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class ControlCollectionUtilities
    {
        public static void ShowAll(this Control.ControlCollection i_Controls)
        {
            new ControlCollectionPropertyChanger(new ShowStrategy()).ChangeAllControls(i_Controls);
        }

        public static void HideAll(this Control.ControlCollection i_Controls)
        {
            new ControlCollectionPropertyChanger(new HideStrategy()).ChangeAllControls(i_Controls);
        }

        public static void EnableAll(this Control.ControlCollection i_Controls)
        {
            new ControlCollectionPropertyChanger(new EnableStrategy()).ChangeAllControls(i_Controls);
        }

        public static void UnableAll(this Control.ControlCollection i_Controls)
        {
            new ControlCollectionPropertyChanger(new UnableStrategy()).ChangeAllControls(i_Controls);
        }

        public static void ChangeColorForAll(this Control.ControlCollection i_Controls, Color i_Color)
        {
            new ControlCollectionPropertyChanger(new ChangeColorStrategy(i_Color)).ChangeAllControls(i_Controls);
        }
    }
}
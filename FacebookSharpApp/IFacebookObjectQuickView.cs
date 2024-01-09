using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IFacebookObjectQuickView
    {
        FacebookObject FacebookObject { get; }

        string DisplayMember { get; }

        string PictureURL { get; }
    }
}
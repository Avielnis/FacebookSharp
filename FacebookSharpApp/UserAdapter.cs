using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class UserAdapter : IFacebookObjectQuickView
    {
        private readonly User r_User;

        public FacebookObject FacebookObject
        {
            get { return r_User; }
        }

        public string DisplayMember
        {
            get { return r_User.Name; }
        }

        public string PictureURL
        {
            get { return r_User.PictureNormalURL; }
        }

        public UserAdapter(User i_User)
        {
            r_User = i_User;
        }
    }
}
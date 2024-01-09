using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class GroupAdapter : IFacebookObjectQuickView
    {
        private readonly Group r_Group;

        public FacebookObject FacebookObject
        {
            get { return r_Group; }
        }

        public string DisplayMember
        {
            get { return r_Group.Name; }
        }

        public string PictureURL
        {
            get { return r_Group.PictureNormalURL; }
        }

        public GroupAdapter(Group i_Group)
        {
            r_Group = i_Group;
        }
    }
}
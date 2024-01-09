using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PageAdapter : IFacebookObjectQuickView
    {
        private readonly Page r_Page;

        public FacebookObject FacebookObject
        {
            get { return r_Page; }
        }

        public string DisplayMember
        {
            get { return r_Page.Name; }
        }

        public string PictureURL
        {
            get { return r_Page.PictureNormalURL; }
        }

        public PageAdapter(Page i_Page)
        {
            r_Page = i_Page;
        }
    }
}
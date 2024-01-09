using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public static class FacebookObjectQuickViewFactory
    {
        public static IFacebookObjectQuickView Create(FacebookObject i_FacbookObject)
        {
            IFacebookObjectQuickView facebookObjectAdapter;

            if (i_FacbookObject.GetType() == typeof(Page))
            {
                facebookObjectAdapter = new PageAdapter(i_FacbookObject as Page);
            }
            else if (i_FacbookObject.GetType() == typeof(Group))
            {
                facebookObjectAdapter = new GroupAdapter(i_FacbookObject as Group);
            }
            else if (i_FacbookObject.GetType() == typeof(Post))
            {
                facebookObjectAdapter = new PostAdapter(i_FacbookObject as Post);
            }
            else if (i_FacbookObject.GetType() == typeof(User))
            {
                facebookObjectAdapter = new UserAdapter(i_FacbookObject as User);
            }
            else
            {
                throw new Exception(string.Format("Cannot create an adapter for type: {0}", i_FacbookObject.GetType()));
            }

            return facebookObjectAdapter;
        }
    }
}
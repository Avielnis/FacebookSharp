using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PostAdapter : IFacebookObjectQuickView
    {
        private readonly Post r_Post;

        public FacebookObject FacebookObject
        {
            get { return r_Post; }
        }

        public string DisplayMember
        {
            get { return r_Post.Message; }
        }

        public string PictureURL
        {
            get { return r_Post.PictureURL; }
        }

        public PostAdapter(Post i_Post)
        {
            r_Post = i_Post;
        }
    }
}
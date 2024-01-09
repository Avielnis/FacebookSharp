using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostTipsLogic : IFeatureLogic
    {
        private const int k_HoursPerDay = 24;
        private const int k_HourRange = 3;
        private static readonly object sr_LockGetPosts = new object();
        private static readonly object sr_LockGetFriends = new object();
        private readonly User r_LoggedInUser = AppEngine.Instance.LoggedInUser;
        private FacebookObjectCollection<Post> m_Posts = null;
        private FacebookObjectCollection<User> m_Friends = null;

        public PostTipsLogic()
        {
        }

        public string Name
        {
            get { return "Post Tips"; }
        }

        internal FacebookObjectCollection<Post> Posts
        {
            get
            {
                if (m_Posts == null)
                {
                    lock (sr_LockGetPosts)
                    {
                        if (m_Posts == null)
                        {
                            m_Posts = AppEngine.Instance.LoggedInUser.Posts;
                        }
                    }
                }

                return m_Posts;
            }
        }

        internal FacebookObjectCollection<User> Friends
        {
            get
            {
                if (m_Friends == null)
                {
                    lock (sr_LockGetFriends)
                    {
                        if (m_Friends == null)
                        {
                            m_Friends = AppEngine.Instance.LoggedInUser.Friends;
                        }
                    }
                }

                return m_Friends;
            }
        }

        public Dictionary<string, int> SortPostsByLikesCount()
        {
            var postsMessagesAndLikesCount = from post in Posts
                                             where post.Message != null
                                             select new
                                             {
                                                 post.Message,
                                                 LikesCount = post.LikedBy.Count(),
                                             };

            var sortedMessagesByLikesCount = from post in postsMessagesAndLikesCount
                                             orderby post.LikesCount descending
                                             select post;

            return sortedMessagesByLikesCount.ToDictionary(post => post.Message, post => post.LikesCount);
        }

        public Dictionary<string, string> CreateFriendsWithSameBirthdatMonthDictionary()
        {
            int userBirthDayMounth = parseMonthOutOfBirthday(r_LoggedInUser.Birthday);
            var friendsWithSameBirthdayMonth = from friend in Friends
                                               where parseMonthOutOfBirthday(friend.Birthday) == userBirthDayMounth
                                               select new { friend.Name, friend.Birthday };

            return friendsWithSameBirthdayMonth.ToDictionary(friend => friend.Name, friend => friend.Birthday);
        }

        private int parseMonthOutOfBirthday(string i_Birthday)
        {
            return int.Parse(i_Birthday.Split('/')[0]);
        }

        private int parseHourOfDateTimeString(string i_DateTime)
        {
            int startIndexOfHours = i_DateTime.IndexOf(' ') + 1;
            string hoursTime = i_DateTime.Substring(startIndexOfHours, 2);

            return int.Parse(hoursTime);
        }

        public Dictionary<string, int> SortFriendsByLikes()
        {
            var allFriendsWhoLiked = Posts.SelectMany(post => post.LikedBy);
            var friendsByLikes = from friend in allFriendsWhoLiked
                                 orderby friend
                                 group friend by friend into friendGroup
                                 select new
                                 {
                                     FriendName = friendGroup.Key.Name,
                                     LikesCount = friendGroup.Count(),
                                 };

            var sortedFriendsByMostLikes = from friend in friendsByLikes
                                           orderby friend.LikesCount descending
                                           select friend;

            return sortedFriendsByMostLikes.ToDictionary(friend => friend.FriendName, friend => friend.LikesCount);
        }

        public PostLikesPerHour[] CalculateLikesAveragePerHourRange()
        {
            PostLikesPerHour[] likesPerHourArray = new PostLikesPerHour[k_HoursPerDay];
            PostLikesPerHour[] compressedLikesPerHourArray = new PostLikesPerHour[k_HoursPerDay / k_HourRange];
            int indexForCompressedArray = 0;

            for (int i = 0; i < likesPerHourArray.Length; i++)
            {
                likesPerHourArray[i] = new PostLikesPerHour(string.Format("{0}:00", i));
            }

            foreach (Post post in Posts)
            {
                int numberOfLikes = post.LikedBy.Count();
                int hourOfPosting = parseHourOfDateTimeString(post.CreatedTime.ToString());

                likesPerHourArray[hourOfPosting].Count++;
                likesPerHourArray[hourOfPosting].NumberOfLikes += numberOfLikes;
            }

            for (int i = 0; i < k_HoursPerDay; i += k_HourRange)
            {
                compressedLikesPerHourArray[indexForCompressedArray] = new PostLikesPerHour(string.Format("{0}:00 - {1}:00", i, i + 3));
                for (int j = i; j < i + k_HourRange; j++)
                {
                    compressedLikesPerHourArray[indexForCompressedArray].Count += likesPerHourArray[j].Count;
                    compressedLikesPerHourArray[indexForCompressedArray].NumberOfLikes += likesPerHourArray[j].NumberOfLikes;
                }

                indexForCompressedArray++;
            }

            foreach (PostLikesPerHour postLikesPerHourObject in compressedLikesPerHourArray)
            {
                postLikesPerHourObject.CalculateAverage();
            }

            return compressedLikesPerHourArray;
        }
    }
}
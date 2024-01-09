using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public sealed class AppEngine
    {
        private readonly AccessTokenManeger r_AccessTokenManeger = new AccessTokenManeger();
        private readonly Dictionary<Type, IFeatureLogic> r_Features = new Dictionary<Type, IFeatureLogic>();
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public static AppEngine Instance
        {
            get { return Singleton<AppEngine>.Instance; }
        }

        public LoginResult LoginResult
        {
            get { return m_LoginResult; }
        }

        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
        }

        public AccessTokenManeger AccessTokenManeger
        {
            get { return r_AccessTokenManeger; }
        }

        private AppEngine()
        {
        }

        public void AddFeatureLogic(IFeatureLogic i_FeatureLogicToAdd)
        {
            r_Features[i_FeatureLogicToAdd.GetType()] = i_FeatureLogicToAdd;
        }

        public T GetFeatureLogicByType<T>()
            where T : class, IFeatureLogic
        {
            return r_Features[typeof(T)] as T;
        }

        public bool TryProceedAndInitialize()
        {
            bool isLoginSucceeded = false;

            try
            {
                m_LoginResult = FacebookService.Connect(r_AccessTokenManeger.AccessToken);
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                isLoginSucceeded = true;
            }
            catch (Exception)
            {
                r_AccessTokenManeger.ClearAccessTokenFile();
            }

            return isLoginSucceeded;
        }

        internal bool TryLoginAndInitialize()
        {
            bool isLoginSucceeded = false;

            try
            {
                m_LoginResult = FacebookService.Login(
                    "1262874821234335",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");
            }
            catch (Exception)
            {
            }

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                r_AccessTokenManeger.AccessToken = m_LoginResult.AccessToken;
                if (r_AccessTokenManeger.IsRememberingAccessToken)
                {
                    r_AccessTokenManeger.SaveAccessTokenToFile();
                }

                m_LoggedInUser = m_LoginResult.LoggedInUser;
                isLoginSucceeded = true;
            }

            return isLoginSucceeded;
        }

        internal void Logout()
        {
            r_AccessTokenManeger.ClearAccessTokenFile();
            FacebookService.LogoutWithUI();
        }

        public Exception SafeThreadExecute(Action i_Action)
        {
            Exception handler = null;

            try
            {
                i_Action.Invoke();
            }
            catch (Exception)
            {
                handler = new Exception(string.Format("Failed {0}", i_Action.Method.Name));
            }

            return handler;
        }
    }
}
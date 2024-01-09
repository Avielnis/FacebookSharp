using System;
using System.IO;

namespace BasicFacebookFeatures
{
    public sealed class AccessTokenManeger
    {
        private readonly string r_FilePath = string.Format("{0}\\Resources\\AccessTokenFile.txt", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
        private string m_AccessToken;
        private bool m_IsRememberingAccessToken;

        internal bool IsRememberingAccessToken
        {
            get { return m_IsRememberingAccessToken; }
            set { m_IsRememberingAccessToken = value; }
        }

        internal string AccessToken
        {
            get { return m_AccessToken; }
            set { m_AccessToken = value; }
        }

        internal string LoadAccessTokenFromFile()
        {
            try
            {
                m_AccessToken = File.ReadAllLines(r_FilePath)[0];
            }
            catch (Exception)
            {
                m_AccessToken = null;
            }

            return m_AccessToken;
        }

        internal void SaveAccessTokenToFile()
        {
            try
            {
                File.WriteAllText(r_FilePath, m_AccessToken);
            }
            catch (Exception i_Exception)
            {
                throw new IOException(string.Format("Cannot Save Access Token: {0}", i_Exception.ToString()));
            }
        }

        internal void ClearAccessTokenFile()
        {
            try
            {
                File.WriteAllText(r_FilePath, string.Empty);
            }
            catch (Exception i_Exception)
            {
                throw new IOException(string.Format("Cannot Clear Access Token File: {0}", i_Exception.ToString()));
            }
        }
    }
}
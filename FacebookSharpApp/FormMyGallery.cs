using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMyGallery : Form
    {
        private Album[] m_Albums;
        private Photo[] m_Photos;
        private int m_IteratorAlbums;
        private int m_IteratorPhotos;
        private ePhotoOrAlbum m_PhotoOrAlbum;

        internal enum ePhotoOrAlbum
        {
            Photo,
            Album,
        }

        public FormMyGallery()
        {
            InitializeComponent();
        }

        private void formMyGallery_Load(object sender, EventArgs e)
        {
            new Thread(loadAllAlbums).Start();
        }

        private void loadAllAlbums()
        {
            panelAlbumsNevigation.Controls.UnableAll();
            panelBackToAlbum.Invoke(new Action(() => panelBackToAlbum.Visible = false));
            try
            {
                m_Albums = AppEngine.Instance.LoggedInUser.Albums.ToArray();
                if (m_Albums.Length == 0)
                {
                    MessageBox.Show("There are no albums to show");
                }
                else
                {
                    m_IteratorAlbums = 0;
                    m_PhotoOrAlbum = ePhotoOrAlbum.Album;
                    panelAlbumsNevigation.Controls.EnableAll();
                    loadAlbum();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load albums");
            }
        }

        private void loadAlbum()
        {
            try
            {
                Album currentAlbum = m_Albums[m_IteratorAlbums];

                pictureBoxMain.LoadAsync(currentAlbum.PictureAlbumURL);
                labelAlbumName.Invoke(new Action(() => labelAlbumName.Text = currentAlbum.Name));
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load current album");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (m_PhotoOrAlbum == ePhotoOrAlbum.Album)
            {
                m_IteratorAlbums = (m_IteratorAlbums + 1) % m_Albums.Length;
                loadAlbum();
            }
            else
            {
                m_IteratorPhotos = (m_IteratorPhotos + 1) % m_Photos.Length;
                loadPhoto();
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (m_PhotoOrAlbum == ePhotoOrAlbum.Album)
            {
                if (m_IteratorAlbums == 0)
                {
                    m_IteratorAlbums = m_Albums.Length - 1;
                }
                else
                {
                    m_IteratorAlbums--;
                }

                loadAlbum();
            }
            else
            {
                if (m_IteratorPhotos == 0)
                {
                    m_IteratorPhotos = m_Photos.Length - 1;
                }
                else
                {
                    m_IteratorPhotos--;
                }

                loadPhoto();
            }
        }

        private void buttonShowAlbum_Click(object sender, EventArgs e)
        {
            panelAlbumsNevigation.Controls.UnableAll();
            new Thread(showAlbum).Start();
        }

        private void showAlbum()
        {
            try
            {
                m_Photos = m_Albums[m_IteratorAlbums].Photos.ToArray();
                if (m_Photos.Length > 0)
                {
                    buttonShowAlbum.Invoke(new Action(() => buttonShowAlbum.Visible = false));
                    panelBackToAlbum.Invoke(new Action(() => panelBackToAlbum.Visible = true));
                    labelShowingNowDetails.Invoke(new Action(() => labelShowingNowDetails.Text = "Showing photos of album:"));
                    m_PhotoOrAlbum = ePhotoOrAlbum.Photo;
                    m_IteratorPhotos = 0;
                    loadPhoto();
                }
                else
                {
                    MessageBox.Show("No photos to show in this album");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't retrieve album");
            }

            panelAlbumsNevigation.Controls.EnableAll();
        }

        private void loadPhoto()
        {
            try
            {
                pictureBoxMain.LoadAsync(m_Photos[m_IteratorPhotos].PictureNormalURL);
            }
            catch
            {
                MessageBox.Show("Can't load photo");
            }
        }

        private void buttonBackToAlbums_Click(object sender, EventArgs e)
        {
            panelBackToAlbum.Visible = false;
            buttonShowAlbum.Visible = true;
            labelShowingNowDetails.Text = "Cover photo of album:";
            m_PhotoOrAlbum = ePhotoOrAlbum.Album;
            loadAlbum();
        }
    }
}
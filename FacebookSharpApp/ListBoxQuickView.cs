using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class ListBoxQuickView
    {
        private static List<IFacebookObjectQuickView> makeFacebookObjectQuickViewList<T>(FacebookObjectCollection<T> i_FacebookObjectCollection)
            where T : FacebookObject
        {
            List<IFacebookObjectQuickView> facebookObjectAdapterList = new List<IFacebookObjectQuickView>();

            try
            {
                foreach (T facebookObject in i_FacebookObjectCollection)
                {
                    facebookObjectAdapterList.Add(FacebookObjectQuickViewFactory.Create(facebookObject));
                }
            }
            catch (Exception)
            {
                throw new Exception(string.Format("Unable to retrieve {0}s", typeof(T).Name));
            }

            return facebookObjectAdapterList;
        }

        public static void PopulateListBox<T>(ListBox i_ListBox, FacebookObjectCollection<T> i_FacebookObjectCollection)
            where T : FacebookObject
        {
            List<IFacebookObjectQuickView> facebookObjectQuickViewList = makeFacebookObjectQuickViewList(i_FacebookObjectCollection);

            if (i_FacebookObjectCollection.Count > 0)
            {
                i_ListBox.BeginInvoke(new Action(() =>
                {
                    i_ListBox.DisplayMember = "DisplayMember";
                    i_ListBox.DataSource = facebookObjectQuickViewList;
                }));
            }
            else
            {
                MessageBox.Show(string.Format("Unable to retrieve {0}s", typeof(T).Name));
            }
        }

        public static void LoadImageOfSelectedItem(ListBox i_ListBox, PictureBox i_PictureBox)
        {
            if (i_ListBox.SelectedItems.Count == 1)
            {
                IFacebookObjectQuickView selectedItem = i_ListBox.SelectedItem as IFacebookObjectQuickView;

                try
                {
                    i_PictureBox.LoadAsync(selectedItem.PictureURL);
                    i_PictureBox.Visible = true;
                }
                catch (Exception)
                {
                    i_PictureBox.Visible = false;
                }
            }
        }

        public static void BindDataOfSelectedItem(ListBox i_ListBox, BindingSource i_BindingSource)
        {
            if (i_ListBox.SelectedItem != null)
            {
                i_BindingSource.DataSource = (i_ListBox.SelectedItem as IFacebookObjectQuickView).FacebookObject;
            }
        }
    }
}
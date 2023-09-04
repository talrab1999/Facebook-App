using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace SpecialFeatures
{
    public class FeatureTop5LikePages
    {
        public User TheLoggedInUser { get; set; }

        public List<Page> PageList { get; set; }

        public FeatureTop5LikePages(User i_TheLoggedInUser) 
        {
            PageList = new List<Page>();
            TheLoggedInUser = i_TheLoggedInUser;

            fetchTop5LikedPages();
        }

        private void fetchTop5LikedPages()
        {
            foreach (Page page in TheLoggedInUser.LikedPages)
            {
                if (PageList.Count < 5)
                {
                    PageList.Add(page);
                }
                else
                {
                    foreach (Page topPage in PageList)
                    {
                        if (page.LikesCount > topPage.LikesCount)
                        {
                            PageList.Add(topPage);
                            PageList.Remove(topPage);
                        }
                    }
                }
            }
        }

    }
}

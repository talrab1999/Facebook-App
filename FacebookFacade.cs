using FacebookWrapper.ObjectModel;
using SpecialFeatures;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FacebookFacade
    {
        public User TheLoggedInUser { get; set; }
        public SpecialFeaturesFactory FeaturesFactory { get; set; }
        public FeatureTop5LikePages Top5LikePages { get; set; }
        public ScheduledPost ScheduledPostManger { get; set; }

        public FacebookFacade(User i_TheLoggedInUser) 
        {
            TheLoggedInUser = i_TheLoggedInUser;
            FeaturesFactory = new SpecialFeaturesFactory();
        }

        public void PostStatus(string i_PostContent)
        {
            try
            {
                Status postedStatus = TheLoggedInUser.PostStatus(i_PostContent);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }
        }

        public void ScheduledPost(string i_PostContent, int i_Day, int i_Month, int i_Year, int i_Hour, int i_Minute)
        {
            DateTime scheduledTime = new DateTime(i_Year, i_Month, i_Day, i_Hour, i_Minute, 0, DateTimeKind.Utc);

            ScheduledPostManger = FeaturesFactory.CreateScheduledPost(TheLoggedInUser, scheduledTime, i_PostContent);

            ScheduledPostManger.PostScheduledPost();
        }

        public IEnumerable<Album> GetAlbums()
        {
            FacebookObjectCollection<Album> albumList = new FacebookObjectCollection<Album>();

            try
            {
                albumList = TheLoggedInUser.Albums;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while fetching albums:\n" + ex.ToString());
            }

            return albumList;
        }

        public IEnumerable<Event> GetEvents()
        {
            FacebookObjectCollection<Event> eventsList = new FacebookObjectCollection<Event>();

            try
            {
                eventsList = TheLoggedInUser.Events;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while fetching events:\n" + ex.ToString());
            }

            return eventsList;
        }

        public IEnumerable<Page> GetLikedPages()
        {
            FacebookObjectCollection<Page> PagesList = new FacebookObjectCollection<Page>();

            try
            {
                PagesList = TheLoggedInUser.LikedPages;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while fetching liked pages:\n" + ex.ToString());
            }

            return PagesList;
        }

        public IEnumerable<Post> GetPosts()
        {
            FacebookObjectCollection<Post> postsList = new FacebookObjectCollection<Post>();

            try
            {
                postsList = TheLoggedInUser.Posts;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while fetching posts:\n" + ex.ToString());
            }

            return postsList;
        }

        public IEnumerable<Page> GetFavoriteTeams()
        {
            FacebookObjectCollection<Page> favoriteTeamsList = new FacebookObjectCollection<Page>();

            try
            {
                foreach (Page team in TheLoggedInUser.FavofriteTeams)
                {
                    favoriteTeamsList.Add(team);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }

            return favoriteTeamsList;
        }

        public IEnumerable<Page> GetTop5LikedPages()
        {
            List<Page> top5LikedPagesList = new List<Page>();

            try
            {
                Top5LikePages = FeaturesFactory.CreateTop5LikePages(TheLoggedInUser);
                top5LikedPagesList = Top5LikePages.PageList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }

            return top5LikedPagesList;
        }

    }
}

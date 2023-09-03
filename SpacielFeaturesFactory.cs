using FacebookWrapper.ObjectModel;
using SpacielFeatures;
using System;

namespace BasicFacebookFeatures
{
    public class SpacielFeaturesFactory : IFactory
    {
        public ScheduledPost CreateScheduledPost(User i_TheLoggedInUser, DateTime i_ScheduledTime, string i_PostContent)
        {
            return new ScheduledPost(i_TheLoggedInUser, i_ScheduledTime, i_PostContent);
        }

        public FeatureTop5LikePages CreateTop5LikePages(User i_TheLoggedInUser)
        {
            return new FeatureTop5LikePages(i_TheLoggedInUser);
        }
    }
}

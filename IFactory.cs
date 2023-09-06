using FacebookWrapper.ObjectModel;
using SpecialFeatures;
using System;

namespace BasicFacebookFeatures
{
    public interface IFactory
    {
        ScheduledPost CreateScheduledPost(User i_TheLoggedInUser, DateTime i_ScheduledTime, string i_PostContent);
        FeatureTop5LikePages CreateTop5LikePages(User i_TheLoggedInUser);
    }
}

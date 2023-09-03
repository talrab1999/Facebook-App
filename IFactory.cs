using FacebookWrapper.ObjectModel;
using SpacielFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IFactory
    {
        ScheduledPost CreateScheduledPost(User i_TheLoggedInUser, DateTime i_ScheduledTime, string i_PostContent);
        FeatureTop5LikePages CreateTop5LikePages(User i_TheLoggedInUser);
    }
}

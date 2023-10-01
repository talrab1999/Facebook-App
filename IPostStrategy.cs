
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    
    public interface IPostStrategy
    {
        User TheLoggedInUser { get; set; }
        void Post(string i_PostContent, User TheLoggedInUser);
    }
}

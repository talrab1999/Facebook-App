using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public interface ILoginObserver
    {
        void OnLogin(LoginResult loginResult);
    }
}

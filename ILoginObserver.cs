using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public interface ILoginObserver
    {
        void OnLogin(LoginResult i_LoginResult);
    }
}

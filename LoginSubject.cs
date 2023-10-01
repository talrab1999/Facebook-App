using FacebookWrapper;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    class LoginSubject
    {
        private List<ILoginObserver> loginObservers = new List<ILoginObserver>();

        public void Subscribe(ILoginObserver observer)
        {
            loginObservers.Add(observer);
        }

        public void Unsubscribe(ILoginObserver observer)
        {
            loginObservers.Remove(observer);
        }

        public void NotifyLoginObservers(LoginResult loginResult)
        {
            foreach (ILoginObserver observer in loginObservers)
            {
                observer.OnLogin(loginResult);
            }
        }
    }
}

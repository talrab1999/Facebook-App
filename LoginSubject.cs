using FacebookWrapper;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    class LoginSubject
    {
        private List<ILoginObserver> m_LoginObservers = new List<ILoginObserver>();

        public void Subscribe(ILoginObserver i_Observer)
        {
            m_LoginObservers.Add(i_Observer);
        }

        public void Unsubscribe(ILoginObserver i_Observer)
        {
            m_LoginObservers.Remove(i_Observer);
        }

        public void NotifyLoginObservers(LoginResult i_LoginResult)
        {
            foreach (ILoginObserver observer in m_LoginObservers)
            {
                observer.OnLogin(i_LoginResult);
            }
        }
    }
}

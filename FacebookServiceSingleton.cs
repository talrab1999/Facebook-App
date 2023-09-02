using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FacebookWrapper;

public class FacebookServiceSingleton
{
    private static FacebookServiceSingleton instance;
    private static readonly object lockObject = new object();

    private FacebookServiceSingleton()
    {
        
        FacebookService.s_UseForamttedToStrings = true;
    }

    public static FacebookServiceSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FacebookServiceSingleton();
                    }
                }
            }
            return instance;
        }
    }

    public LoginResult Login(string accessToken)
    {
        // You can add more methods or properties related to FacebookService here.
        return FacebookService.Connect(accessToken);
    }

    public void Logout()
    {
        // Use FacebookService to logout
        FacebookService.LogoutWithUI();
    }
}

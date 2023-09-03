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

    public LoginResult LoginWithAppIdAndPermissions(string i_AppId, params string[] i_Permissions)
    {
        return FacebookService.Login(i_AppId, i_Permissions);
    }

    public LoginResult LoginWithAccessToken(string i_AccessToken)
    {
        // You can add more methods or properties related to FacebookService here.
        return FacebookService.Connect(i_AccessToken);
    }

    public void Logout()
    {
        // Use FacebookService to logout
        FacebookService.LogoutWithUI();
    }
}
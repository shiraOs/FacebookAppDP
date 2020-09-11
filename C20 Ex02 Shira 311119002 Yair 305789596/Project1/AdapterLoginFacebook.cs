using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public class AdapterLoginFacebook
    {
        public readonly AppSettings r_AppSettings;
        public LoginResult m_LoginResult;

        public AdapterLoginFacebook(AppSettings i_AppSettings)
        {
            r_AppSettings = i_AppSettings;
        }

        public LoginResult Connect()
        {
            if (r_AppSettings.RememberUser
               && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
            }
            return m_LoginResult;
        }

        public LoginResult Login()
        {
            m_LoginResult = FacebookService.Login(AppSettings.sr_AppID, AppSettings.sr_Permissions);

            if (string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                throw new Exception(m_LoginResult.ErrorMessage);
            }

            return m_LoginResult;
        }

    }
}

﻿using OnTimeGCApi;
using System;
using System.Collections.Generic;

namespace ExampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("ApiExplorer", "5", 5, "https://demo.ontimesuite.com", "/ontime/ontimegcclient.nsf/");
            OnTimeGCApi.Login.Base result = client.Login("ch", "demo");
            if (result.IsAuthorized)
            {
                //OnTimeGCApi.Version.Base versionResult = client.Version();
                //OnTimeGCApi.UsersAll.Base usersAllResult = client.UsersAll(null, null);
                //OnTimeGCApi.UsersInfo.Base usersInfoResult = client.UsersInfo(null, new List<string>() { "H" }, null, null, null, null, null, null);
                OnTimeGCApi.Calendars.Base calendarsResult = client.Calendars(new List<string>() { "U", "10" }, null, null, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(2));
                OnTimeGCApi.Logout.Base logoutResult = client.Logout();
            }
        }
    }
}

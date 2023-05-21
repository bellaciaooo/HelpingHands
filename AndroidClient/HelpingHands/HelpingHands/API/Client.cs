﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HelpingHands.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpingHands.API
{
    internal static class Client
    {
        private static ClientBase ClientBase = new ClientBase();

        public static async Task<UserSession> Login(string username, string password)
            => await ClientBase.Post<UserSession, LoginInfo>("/login", new LoginInfo(username, password));

        public static async Task<Eveniment[]> GetEvenimente()
            => await ClientBase.Get<Eveniment[]>("/evenimente");
    }
}
﻿namespace Notes.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://github.com/Kopchan/MAUI-learn";
        public string Message => "This app is written in XAML and C# with .NET MAUI.";
    }
}

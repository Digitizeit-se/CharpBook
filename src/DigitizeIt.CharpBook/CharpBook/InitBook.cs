using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CharpBook
{
    public static class InitBook
    {
        private static string path = Directory.GetCurrentDirectory();

        public static void Init()
        {
            Directory.CreateDirectory("src");
            File.Create(Path.Combine(path + "//src//", "TableOfContents.md"));
            File.Create(Path.Combine(path + "//src//", "FirstChapter.md"));
            File.Create(Path.Combine(path + "//book//", "index.html"));
        }

        //TableOfContents;
    }
}
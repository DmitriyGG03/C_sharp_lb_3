﻿using Hostels;

public static class Extensions
{
    public static bool find<T>(this List<T> list, T target)
    {
        return list.Contains(target);
    }
}

namespace C_sharp_lb_2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

            Campus.Initializing();
        }
    }
}

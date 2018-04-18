﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using StoryMachine.UserInterface;
using StoryMachine.Utilities;

namespace StoryMachine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            // Execute the query and obtain the value of the first column of the first row
            Int64 count = databaseHelper.Count("Stories");

            Console.Write("{0}\n", count);

            databaseHelper.CloseConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeScreen());
        }
    }
}

﻿namespace Team_6_Senior_Project;
internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// 
    public static bool runViewAll = false;
    public static string filenameViewAll = "None";
    public static bool closeProgram = false;
    public static Form CurrentForm;
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.SetCompatibleTextRenderingDefault(false);
        CurrentForm = new MainMenu(); //Has to be initalized after SetCompatiableTextRenderingDefault.  It will create an error otherwise.
        while (CurrentForm != null)
        {
            Application.Run(CurrentForm); //CurrentForm will be changed by other form depending on what is pressed to exit the program.
        }
    }
}

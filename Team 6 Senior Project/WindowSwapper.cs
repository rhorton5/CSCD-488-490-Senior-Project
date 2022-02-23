namespace Team_6_Senior_Project;
internal class WindowSwapper
{   
    public void ValidateWindow(string windowName)
    {
        if (windowName.Equals(Program.CurrentForm.Name, StringComparison.Ordinal))
            Program.CurrentForm = null;
    }

    public void GoToMainMenu(Form currentForm)
    {
        ChangeWindow(currentForm, new MainMenu());
    }

    public void GoToSpecimensForm(Form currentForm)
    {
        ChangeWindow(currentForm, new SpecimensForm());
    }

    public  void GoToTemplatesForm(Form currentForm)
    {
        ChangeWindow(currentForm, new TemplatesForm());
    }

    public  void GoToSpecimensSummaryForm(Form currentForm)
    {
        ChangeWindow(currentForm, new SpecimensSummaryForm());
    }

    private  void ChangeWindow(Form currentWindow, Form newWindow)
    {
        Program.CurrentForm = newWindow;
        currentWindow.Close();
    }
}

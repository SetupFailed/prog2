public class Button
{
    public string SelectedChoice;
}


public class ContinueButton : Button
{
    public void Selection()
    {
        SelectedChoice = ""
    }
}

public class ExitButton : Button
{
    public void Selection()
    {
        SelectedChoice = ""
    }
}

public class RestartButton : Button
{
    public void selection()
    {
        SelectedChoice = ""
    }
}
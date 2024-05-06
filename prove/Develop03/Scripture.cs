using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference Reference, string text)
    {

    }
    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}
using System;
using System.Collections.Generic;

public class View
{
    public event Action<List<string>> OnFilesSelected;

    public void SelectFiles()
    {
        Console.WriteLine("Selecionar ficheiros...");
        OnFilesSelected?.Invoke(new List<string> { "file1.pdf", "file2.pdf" });
    }

    public void ShowResult()
    {
        Console.WriteLine("PDF pronto para download.");
    }
}

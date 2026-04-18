using System;
using System.Collections.Generic;

public class Model
{
    public event Action OnMergeCompleted;

    public void ValidateFiles(List<string> files)
    {
        Console.WriteLine("Validar ficheiros...");
        MergeFiles(files);
    }

    public void MergeFiles(List<string> files)
    {
        Console.WriteLine("Juntar ficheiros PDF...");
        OnMergeCompleted?.Invoke();
    }
}

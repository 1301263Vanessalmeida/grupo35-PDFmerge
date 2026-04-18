using System.Collections.Generic;

public class Controller
{
    private View view;
    private Model model;

    public Controller(View view, Model model)
    {
        this.view = view;
        this.model = model;

        view.OnFilesSelected += HandleFilesSelected;
        model.OnMergeCompleted += HandleMergeCompleted;
    }

    private void HandleFilesSelected(List<string> files)
    {
        model.ValidateFiles(files);
    }

    private void HandleMergeCompleted()
    {
        view.ShowResult();
    }
}

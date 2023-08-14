using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.ExtendedTypes;

public class MarkdownTaskElement : IMarkdownTaskElement
{
    public bool Checked { get; set; }
    public string Task { get; }

    public MarkdownTaskElement(string task, bool isChecked = false)
    {
        Checked = isChecked;
        Task = task;
    }

    public void Toggle()
    {
        Checked = !Checked; 
    }

    public override string ToString()
    {
        string checkbox = Checked ? "[x]" : "[ ]";
        return $"{checkbox} {Task}";
    }
}
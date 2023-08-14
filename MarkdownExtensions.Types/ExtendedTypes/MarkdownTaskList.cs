using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.ExtendedTypes;

public class MarkdownTaskList : IMarkdownTaskList
{
    private List<IMarkdownTaskElement> _tasks;

    public IEnumerable<IMarkdownTaskElement> Tasks => _tasks;

    public MarkdownTaskList()
    {
        _tasks = new List<IMarkdownTaskElement>();
    }

    public void AddTask(string task, bool isChecked = false)
    {
        _tasks.Add(new MarkdownTaskElement(task, isChecked));
    }

    public void ChangeTaskStatus(int taskIndex, bool isChecked)
    {
        if (taskIndex >= 0 && taskIndex < _tasks.Count)
        {
            _tasks[taskIndex].Checked = isChecked;
        }
    }

    public override string ToString()
    {
        StringBuilder taskList = new StringBuilder();

        foreach (var task in _tasks)
        {
            taskList.AppendLine(task.ToString());
        }

        return taskList.ToString();
    }
}
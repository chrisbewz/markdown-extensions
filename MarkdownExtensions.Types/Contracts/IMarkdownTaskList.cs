using System.Collections.Generic;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownTaskList : IMarkdownExtendedElement
{
    IEnumerable<IMarkdownTaskElement> Tasks { get; }
    void AddTask(string task, bool isChecked = false);
    void ChangeTaskStatus(int taskIndex, bool isChecked);
}
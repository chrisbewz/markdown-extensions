using System.Collections.Generic;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownTaskList : IMarkdownExtendedElement
{
    IEnumerable<IMarkdownTaskElement> Tasks { get; }
<<<<<<< HEAD

=======
>>>>>>> origin/master
    void AddTask(string task, bool isChecked = false);
    void ChangeTaskStatus(int taskIndex, bool isChecked);
}
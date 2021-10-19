using System;
namespace Italbytz.Ports.Exam
{
    public interface ITaskTextGenerator<T> where T : ITask
    {
        ITaskText Generate(T task);
    }
}

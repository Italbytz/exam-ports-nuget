using System;
namespace ExamPorts
{
    public interface ITaskTextGenerator<T> where T : ITask
    {
        ITaskText Generate(T task);
    }
}

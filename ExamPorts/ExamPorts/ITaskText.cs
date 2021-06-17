using System;
namespace ExamPorts
{
    public interface ITaskText
    {
        string Solution { get; set; }
        string Problem { get; set; }
        string Form { get; set; }
    }
}

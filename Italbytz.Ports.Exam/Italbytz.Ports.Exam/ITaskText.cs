using System;
namespace Italbytz.Ports.Exam
{
    public interface ITaskText
    {
        string Solution { get; set; }
        string Problem { get; set; }
        string Form { get; set; }
    }
}

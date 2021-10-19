using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Exam
{
    public interface IExam
    {
        Boolean Scored { get; set; }
        string Lecture { get; set; }
        string Sheet { get; set; }
        string Student { get; set; }
        List<ITask> Tasks { get; set; }
        string FileName { get; set; }
    }
}

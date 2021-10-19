using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Exam
{
    public interface IExamExporter
    {
        string ExportPath { get; set; }

        void Export(IExam exams);
    }
}

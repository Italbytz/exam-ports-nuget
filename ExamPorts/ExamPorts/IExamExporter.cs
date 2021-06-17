using System;
using System.Collections.Generic;

namespace ExamPorts
{
    public interface IExamExporter
    {
        string ExportPath { get; set; }

        void Export(IExam exams);
    }
}

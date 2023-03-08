using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Exam
{
    public interface IStepwiseSolution<TSolution>
    {
        TSolution Solution { get; set; }
        List<TSolution> Steps { get; set; }
    }
}


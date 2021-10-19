using System;
namespace ExamPorts
{
    public interface ISolver<TParameters, TSolution>
    {
        TSolution Solve(TParameters parameters);
    }
}

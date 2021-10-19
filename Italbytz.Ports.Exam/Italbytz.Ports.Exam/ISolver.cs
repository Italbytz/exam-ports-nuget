using System;
namespace Italbytz.Ports.Exam
{
    public interface ISolver<TParameters, TSolution>
    {
        TSolution Solve(TParameters parameters);
    }
}

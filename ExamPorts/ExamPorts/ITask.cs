﻿namespace ExamPorts
{
    public interface ITask
    {
        int Score { get; set; }
        string Topic { get; set; }
        ITaskText Text { get; set; }        
    }
}
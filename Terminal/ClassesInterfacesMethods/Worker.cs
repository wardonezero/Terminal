namespace Terminal;
//public delegate int WorkPerformedHandler(int hours, WorkType workType);
//public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs  e);
public class Worker
{
    //public event WorkPerformedHandler? WorkPerformed;
    public event EventHandler<WorkPerformedEventArgs>? WorkPerformed;
    public event EventHandler? WorkCompleted;
    public void DoWork(int hours, WorkType workType)
    {
        for (int i = 0; i < hours; i++)
        {
            //Thread.Sleep(4);
            OnWorkPerformed(i + 1, workType);
        }
        OnWorkCompleted();
    }
    protected virtual void OnWorkPerformed(int hours, WorkType workType)
    {
        //if(WorkPerformed != null)
        //{
        //    WorkPerformed(hours, workType);
        //}
        //var del = WorkPerformed as WorkPerformedHandler;
        var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
        if (del != null)
        {
            //del(hours, workType);
            del(this, new WorkPerformedEventArgs(hours, workType));
        }
    }
    protected virtual void OnWorkCompleted()
    {
        //if(WorkPerformed != null)
        //{
        //    WorkPerformed(this, EventArgs.Empty);
        //}
        var del = WorkCompleted as EventHandler;
        if (del != null)
        {
            del(this, EventArgs.Empty);
        }
    }
}
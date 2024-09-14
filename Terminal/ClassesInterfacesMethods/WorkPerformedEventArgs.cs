namespace Terminal;
public class WorkPerformedEventArgs(int hours, WorkType workType) : EventArgs
{
    public int Hours {  get;  set; } = hours;
    public WorkType WorkType { get; set; } = workType;
}
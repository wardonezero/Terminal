using System.ComponentModel;
using Terminal;
using static System.Console;
//1
WorkPerformedHandler del1 = new(WorkPerformed1);
WorkPerformedHandler del2 = new(WorkPerformed2);
WorkPerformedHandler del3 = new(WorkPerformed3);
//del1(4, WorkType.Meeting);
//del2(11, WorkType.Research);
//DoWork(del2);
//del1 += del2;
//del1 += del3;
del1 += del2 + del3;
//del1(24, WorkType.Reports);
int finalhours = del1(23,WorkType.Reports);
WriteLine(finalhours);
static int WorkPerformed1(int hours, WorkType workType)
{
    WriteLine("WorkPerformed1 called " + hours.ToString());
    return hours + 1;
}

static int WorkPerformed2(int hours, WorkType workType)
{
    WriteLine("WorkPerformed2 called " + hours.ToString());
    return hours + 1;
}
static int WorkPerformed3(int hours, WorkType workType)
{
    WriteLine("WorkPerformed3 called " + hours.ToString());
    return hours + 1;
}
//static void DoWork(WorkPerformedHandler del)
//{
//    del(6, WorkType.Meeting);
//}
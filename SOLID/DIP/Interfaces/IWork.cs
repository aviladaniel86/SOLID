namespace SOLID.DIP.Interfaces
{
    public interface IWork
    {
        string WorkName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteWork();
        void PerformedWork(double hours);
    }
}

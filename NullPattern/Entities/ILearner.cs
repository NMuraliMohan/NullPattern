namespace NullPattern.Entities
{
    public interface ILearner
    {
        int Id { get; set; }

        string UserName { get; set; }

        int CoursesCompleted { get; set; }

    }
}
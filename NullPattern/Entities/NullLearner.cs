namespace NullPattern.Entities
{
    public class NullLearner : ILearner
    {
        public NullLearner(int id, string userName, int coursesCompleted)
        {
            Id = id;
            UserName = userName;
            CoursesCompleted = coursesCompleted;
        }


        public int Id = -1;
        public string UserName = "Guest User";
        public int CoursesCompleted = 0;

        int ILearner.Id { get { return -1; } set { value = -1}; }
        string ILearner.UserName { get; set; }
        int ILearner.CoursesCompleted { get; set ; }
    }
}
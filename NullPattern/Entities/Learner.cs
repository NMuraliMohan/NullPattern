using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPattern.Entities
{
    public class Learner : ILearner
    {
        public Learner(int id, string userName, int coursesCompleted)
        {
            Id = id;
            UserName = userName;
            CoursesCompleted = coursesCompleted;
        }

        public int Id { get; set; }
        public string UserName { get;  set; }

        public int CoursesCompleted { get; set; }
    }
}

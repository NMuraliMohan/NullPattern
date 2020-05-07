using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullPattern.Entities;
using NullPattern.View;

namespace NullPattern.Services
{
    class LearnerService
    {
        LearnerRepo _repo = new LearnerRepo();
        public ILearner GetCurrentLearner()
        {
            int learnerId = -1;
            var learner = _repo.GetCurrentLearner(learnerId);
            if (learner == null)
                return new NullLearner();

            return learner;
        }

        class LearnerRepo 
        {
            readonly IList<Learner> _learners = new List<Learner>();

            public LearnerRepo()
            {
                _learners.Add(new Learner(id: 1, userName: "David", coursesCompleted: 83));
                _learners.Add(new Learner(id: 2, userName: "Jones", coursesCompleted: 92));
                _learners.Add(new Learner(id: 3, userName: "DJ", coursesCompleted: 72));
            }

            internal ILearner GetCurrentLearner(int id) 
            {
                bool learnerExists = _learners.Any(l => l.Id == id);

                if (learnerExists)
                    return _learners.FirstOrDefault(l => l.Id == id);

                return null;
            }
        }
    }
}

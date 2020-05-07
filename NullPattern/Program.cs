using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullPattern.Entities;
using NullPattern.Services;
using NullPattern.View;

namespace NullPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a test project for Null Patterns!");

            LearnerService learnerService = new LearnerService();
            ILearner learner = learnerService.GetCurrentLearner();

            LearnerView view = new LearnerView(learner);
            view.RenderView();
        }
    }
}

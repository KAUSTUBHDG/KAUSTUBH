using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public interface ITask
    {
        void Execute();
    }

    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }

    class VideoUploader:ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video");
        }
    }

    class CallWebService:ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling web services");
        }
    }

    class SendMail:ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an Email");
        }
    }

    class ChangeStatus:ITask
    {
        public void Execute()
        {
            Console.WriteLine("Changing Status");
        }
    }



    public class Workflow:IWorkflow 
    {
        private readonly List<ITask> _task;

        public Workflow()
        {
            _task = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _task.Add(task);
        }

        public void Remove(ITask task)
        {
            _task.Remove(task);
        }

            

        public IEnumerable<ITask> GetTasks()
        {
            return _task;
        }

    }



    public class WorkFlowEngine
    {
        public void Run(IWorkflow workflow)
        {

            foreach (ITask I in workflow.GetTasks())
            {
                I.Execute();
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            var ITask = new Workflow();
            ITask.Add(new VideoUploader());
            ITask.Add(new SendMail());
            ITask.Add(new CallWebService());
            ITask.Add(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(ITask);

            Console.ReadLine();

        }
    }
}

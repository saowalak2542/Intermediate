﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow workflow = new WorkFlow();
            workflow.AddWorkFlowObject(new VideoUploader());
            workflow.AddWorkFlowObject(new CallWebService());
            workflow.AddWorkFlowObject(new SendEmail());
            workflow.AddWorkFlowObject(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workflow);

            Console.ReadKey();
        }
    }
    public interface ITask
    {
        void Execute();
    }
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
    public class WorkFlow : IWorkFlow
    {
        private readonly List<ITask> _tasks;
        public WorkFlow()
        {
            _tasks = new List<ITask>();
        }
        public void Add(ITask task)
        {
            _tasks.Add(task);
        }
        public void AddWorkFlowObject(ITask iobject)
        {
            _tasks.Add(iobject);
        }
        public void Remove(ITask task)
        {
            _tasks.Remove(task);

        }
    }
    public void RemoveWorkFlowObject(ITask iobject)
    {
        _tasks.Add(iobject);
    }
    public IEnumerable<ITask> GetTasks()
    {
        return _tasks;
    }
    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video");
        }
    }
    public void Execute()
    {
        Console.WriteLine("call web service...");
    }

    {
        public void Execute()
        {
            Console.WriteLine("Sending Email");
        }
    }
    class ChangeStatus : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Status Changed");
        }
    }
    class WorkFlowEngine
    {
        private List<IWorkFlow> T;

        public WorkFlowEngine()
        {
            T = new List<IWorkFlow>();
        }
        public void AddWorkFlowObject(IWorkFlow iObject)
        {
            T.Add(iObject);
        }
        public void RemoveWorkFlowObject(IWorkFlow iObject)
        {
            T.Remove(iObject);
        }
        public void Run()
        {
            foreach (IWorkFlow I in T)
            {
                I.Execute();
            }
        }
    }
}
    
      
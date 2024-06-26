using CoreMVCDemo.Models;
using System.Collections;

namespace CoreMVCDemo.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private static Models.Task[] tasks = new Models.Task[10];
        private static int index = 0;
        public void AddTask(Models.Task task)
        {
            tasks[index++] = task;
        }
        public Models.Task[] GetAllTasks()
        {
            return tasks;
        }
    }
}

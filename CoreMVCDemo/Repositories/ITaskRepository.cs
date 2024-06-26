





namespace CoreMVCDemo.Repositories
{
    public interface ITaskRepository
    {
        void AddTask(Models.Task task);
        Models.Task[] GetAllTasks();
    }
}
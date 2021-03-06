using System;

namespace Reports.Server.Services
{
    public interface ITaskService
    {
        string GetAllTasks();
        void CreateTask(string instance);
        string GetByCreationTime(string time);
        string GetTasksWithChanges();
        void UpdateTaskEmployee(string taskId, string employeeId);
        string GetTaskById(string taskId);
    }
}
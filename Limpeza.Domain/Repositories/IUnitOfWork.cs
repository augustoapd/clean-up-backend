using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limpeza.Domain.Repositories
{
    public interface IUnitOfWork
    {
        public ICompletedQuestRepository CompletedQuestRepository { get; }
        public IQuestRepository QuestRepository { get; }
        public IRoomRepository RoomRepository { get; }
        public ITaskRepository TaskRepository { get; }
        public IUserRepository UserRepository { get; }

        public Task SaveChanges();
    }
}
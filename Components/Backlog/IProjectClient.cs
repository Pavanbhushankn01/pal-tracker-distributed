using System.Threading.Tasks;
using Backlog;

namespace Backlog
{
    public interface IProjectClient
    {
        Task<ProjectInfo> Get(long projectId);
    }
}
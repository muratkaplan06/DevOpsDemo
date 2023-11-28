using System.Collections.Generic;
using DevOpsDemo.Models;

namespace DevOpsDemo.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}

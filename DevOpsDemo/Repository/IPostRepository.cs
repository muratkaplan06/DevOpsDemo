using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsDemo.Models;

namespace DevOpsDemo.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}

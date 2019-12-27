using Freelance.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freelance.DAL.Abstract
{
    public interface IPostRepository
    {
        Post GetPostById(int id);
        IQueryable<Post> GetPosts();

        void Create(Post entity);
        void Delete(Post entity);
        void Update(Post entity);
    }
}

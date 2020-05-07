using Core.IRepository;
using Core.IRepository.Base;
using Core.Models;
using Core.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repository
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        private readonly CoreContext _context;
        private readonly DbSet<BlogRepository> _dbSet;

        public BlogRepository(CoreContext context)
            :base(context)
        {
            _context = context;
        }
    }
}

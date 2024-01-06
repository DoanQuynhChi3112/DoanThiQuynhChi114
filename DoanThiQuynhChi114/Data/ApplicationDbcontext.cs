using DoanThiQuynhChi114.Models;
using Microsoft.EntityFrameworkCore;
using DoanThiQuynhChi114.Data;

namespace DoanThiQuynhChi114.Data{
    public class ApplicationDbcontext : DbContext{
        public ApplicationDbcontext()
        {
            
        }
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        
        
    }
}
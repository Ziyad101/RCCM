
using Core.Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<CandidateStatus> CandidateStatus { get; set; }
        public DbSet<ExamResult> ExamResult { get; set; }
        public DbSet<ExamTypeConf> ExamTypeConf { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Interview> Interview { get; set; }
        public DbSet<InterviewResult> InterviewResult { get; set; }
        public DbSet<JobOffer> JobOffer { get; set; }
        public DbSet<Major> Major { get; set; }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<CreatorExamTypeConf> CreatorExamTypeConf { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
        }

    }
}

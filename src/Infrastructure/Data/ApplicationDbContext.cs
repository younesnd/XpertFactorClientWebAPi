using System.Reflection;
using XpertFactorClientWebAPi.Application.Common.Interfaces;
using XpertFactorClientWebAPi.Domain.Entities;
using XpertFactorClientWebAPi.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XpertFactorClientWebAPi.Domain.StoredProcedureModel;

namespace XpertFactorClientWebAPi.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<TodoList> TodoLists => Set<TodoList>();

    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
    public DbSet<DisponibleAdhWeb> DisponibleAdhWebResult => Set<DisponibleAdhWeb>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

using Guarantee.Models;
using Microsoft.EntityFrameworkCore;

namespace Guarantee.Models;

public class GuarContext : DbContext
{
    public GuarContext(DbContextOptions<GuarContext> options)
        : base(options)
    {
    }

    public DbSet<TheGuarantor> TheGuarantors { get; set; } = null!;
    public DbSet<GuaranteeAgreement> GuaranteeAgreements { get; set; }
}

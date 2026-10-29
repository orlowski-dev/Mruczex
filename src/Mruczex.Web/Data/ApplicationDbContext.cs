using Microsoft.EntityFrameworkCore;

namespace Mruczex.Web.Data;

public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
    : DbContext(options) { }

using Microsoft.EntityFrameworkCore;
using EMS.API.Model;


namespace EMS.API.Data;



public partial class EmployeeContext : DbContext
{


    public EmployeeContext(){}

    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options){}


    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<AccountHolder> AccountHolders { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<Products> Products { get; set; }



}

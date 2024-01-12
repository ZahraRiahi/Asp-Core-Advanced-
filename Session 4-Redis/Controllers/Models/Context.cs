using Microsoft.EntityFrameworkCore;
using sample.Models;
public class Context:DbContext{
    public DbSet<Student> Students{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
        optionBuilder.UseSqlServer("Data Source=robin.iran.liara.ir,34557;Initial Catalog=test;User Id=sa,Password=mYlil7glhv90lpITGNTmJxj;");
    }

}
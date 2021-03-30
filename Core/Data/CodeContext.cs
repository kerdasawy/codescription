
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class CodeContext : DbContext
    {
        public CodeContext(DbContextOptions<CodeContext> options) : base(options)
        {

        }
      

        public DbSet<CodeDescription> CodeDescriptions { get; set; }
        public DbSet<CodeType> CodeTypes { get; set; }
        public DbSet<Module> Modules { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=CodeDescriptionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CodeType>().ToTable("CodeType");
            modelBuilder.Entity<Module>().ToTable("Module");
            modelBuilder.Entity<CodeDescription>().ToTable("CodeDescription");
            modelBuilder.Entity<CodeDescription>()
            .HasOne<CodeType>(g => g.Type)
            .WithMany(t => t.CodeDescriptions)
            .HasForeignKey(s => s.CodeTypeId);


            modelBuilder.Entity<CodeDescription>()
                .HasOne<core.Module>(c => c.Module)
                .WithMany(m => m.CodeDescriptions)
                .HasForeignKey(c => c.ModuleId);


            modelBuilder.Entity<CodeDescription>().Navigation<CodeType>(c => c.Type).AutoInclude();
            modelBuilder.Entity<CodeDescription>().Navigation<Module>(c => c.Module).AutoInclude();
            var codeTypes = new List<CodeType>()
            {
                 new CodeType(){Id=1, Color="#fb6fed", Name="Error" , Description = "Error in operation or user input invalid."},
                 new CodeType(){Id=2, Color="#f9fba2", Name="Warning" , Description = "Warning in operation or user input has issue."},
                 new CodeType(){Id=3, Color="#c4c4c4", Name="Status" , Description = "Operation Status and info."},

            };
            modelBuilder.Entity<CodeType>().HasData(codeTypes);


            var modules = new List<Module>()
            {
                new Module(){Id=1, Name="System", Description="General code for all system wide" },
                new Module(){ Id=2,Name="UserProfile", Description="UserProfile  service  " },

            };
            modelBuilder.Entity<Module>().HasData(modules);


            var CodeDescriptions = new List<CodeDescription>()
            {
                new CodeDescription(){Id=1000 ,Code="Error-System-1000", Description="the field required to be entered", Message="RequiredField",   ModuleId=1 , CodeTypeId =1 },
                new CodeDescription(){Id=1001 ,Code="Error-System-1001", Description="authentication needed before use ", Message="Unauthorized", ModuleId=1 , CodeTypeId =1  },
                new CodeDescription(){Id=1002 ,Code="Error-System-1002", Description="Already used value like used email   ", Message="AlreadyExist", ModuleId=1 , CodeTypeId =1  },
                new CodeDescription(){Id=1004 ,Code="Error-UserProfile-1004", Description="the user trail ended and some action can't be activated", Message="UserTrialEnded",ModuleId=2, CodeTypeId =1  },
                new CodeDescription(){Id=1005 ,Code="Error-System-1005", Description="the value not found to use like any  forgery key   or validation code", Message="NotExist", ModuleId=1 , CodeTypeId =1  },
                new CodeDescription(){Id=1006 ,Code="Error-System-1006", Description="the link of activation email link or password reset link in expired", Message="ExpiredLink", ModuleId=1 , CodeTypeId =1  },
                new CodeDescription(){Id=1007 ,Code="Error-System-1007", Description="The link used before", Message="UsedLink", ModuleId=1 , CodeTypeId =1  },
                new CodeDescription(){Id=1008 ,Code="Error-System-1008", Description="miss use of values or some logic is incorrect", Message="InvaildField", ModuleId=1 , CodeTypeId =1  },
                new CodeDescription(){Id=1017 ,Code="Error-System-1017", Description="the user email not verified and can't continue the process", Message="UserUnverfiedEmail", ModuleId=1 , CodeTypeId =1  },
                new CodeDescription(){Id=1009 ,Code="Warning-System-1009", Description="", Message="PasswordWeak", ModuleId=1 , CodeTypeId =2 },
                new CodeDescription(){Id=1010 ,Code="Warning-System-1010", Description="", Message="PasswordMeduim", ModuleId=1 , CodeTypeId =2 },
                new CodeDescription(){Id=1011 ,Code="Warning-System-1011", Description="", Message="PasswordStrong", ModuleId=1 , CodeTypeId =2 },
                new CodeDescription(){Id=1012 ,Code="Warning-System-1012", Description="", Message="EmailVerifitionLinkShouldBeResent", ModuleId=1 , CodeTypeId =2 },
                new CodeDescription(){Id=1013 ,Code="Status-System-1013", Description="the operation is completed like reset password or verified email done", Message="Success", ModuleId=1 ,CodeTypeId =3},
                new CodeDescription(){Id=1014 ,Code="Status-System-1014", Description="the operation is uncompleted review errors", Message="Failed", ModuleId=1 ,CodeTypeId =3},
                new CodeDescription(){Id=1015 ,Code="Status-System-1015", Description="the operation is saved on system", Message="Saved", ModuleId=1 ,CodeTypeId =3},
                new CodeDescription(){Id=1016 ,Code="Status-System-1016", Description="the operation is unsaved on system review errors", Message="Unsaved", ModuleId=1 ,CodeTypeId =3},
            };
            modelBuilder.Entity<CodeDescription>().HasData(CodeDescriptions);

        }
    }
}

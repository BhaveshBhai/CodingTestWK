using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WKBackend.Model
{
    public class WKDBContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }
       public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> children { get; set; }

        public WKDBContext(DbContextOptions<WKDBContext> options) : base(options)
        {
            LoadForms();
            LoadParents();
            LoadChild();
        }

        public void LoadForms()
        {
                var form = new Form()
                {
                    FormId = 1,
                    Name = "Student"
                };
                Forms.Add(form);
                form = new Form()
                {
                    FormId = 2,
                    Name = "Parent"
                };
              
                Forms.Add(form);
        }
        public void LoadParents()
        {
            var parents = new Parent()
            {
                FormId = 1,
                ParentId = 1,
                Name = "Bhavesh"
            };
            Parents.Add(parents);
            parents = new Parent()
            {
                FormId = 1,
                ParentId = 2,
                Name = "Kinjal"
            };
            Parents.Add(parents);
            parents = new Parent()
            {
                FormId = 1,
                ParentId = 3,
                Name = "Hridiya"
            };
            Parents.Add(parents);

            parents = new Parent()
            {
                FormId = 2,
                ParentId = 4,
                Name = "Ukabhai"
            };
            Parents.Add(parents);
            parents = new Parent()
            {
                FormId = 2,
                ParentId = 5,
                Name = "Naranbhai"
            };
            Parents.Add(parents);
            parents = new Parent()
            {
                FormId = 2,
                ParentId = 6,
                Name = "Bhaveshbhai"
            };
            Parents.Add(parents);
        }

        public void LoadChild()
        {
            var childer = new Child()
            {
                FirstName = "Bhaveshb",
                LastName = "Narola",
                MiddleName = "U",
                City = "Surat",
                ContactNumber = "610475785218",
                ParentId = 1
            };
            children.Add(childer);
            childer = new Child()
            {
                FirstName = "Kinjaln",
                LastName = "Lahar",
                MiddleName = "N",
                City = "Pune",
                ContactNumber = "61045897558",
                ParentId = 2
            };
            children.Add(childer);
            childer = new Child()
            {
                FirstName = "HridiyaB",
                LastName = "Narola",
                MiddleName = "B",
                City = "mahuva",
                ContactNumber = "6489568925686",
                ParentId = 3
            };
            children.Add(childer);
            childer = new Child()
            {
                FirstName = "UkabhaiH",
                LastName = "Narola",
                MiddleName = "H",
                City = "Surat",
                ContactNumber = "9191919191",
                ParentId = 4
            };
            children.Add(childer);
            childer = new Child()
            {
                FirstName = "NaranbhaiL",
                LastName = "Lahar",
                MiddleName = "L",
                City = "Pune",
                ContactNumber = "9292929292",
                ParentId = 5
            };
            children.Add(childer);
            childer = new Child()
            {
                FirstName = "Bhaveshbhai",
                LastName = "Narola",
                MiddleName = "U",
                City = "mahuva",
                ContactNumber = "9396939393",
                ParentId = 6
            };
            children.Add(childer);
        }
    }
}

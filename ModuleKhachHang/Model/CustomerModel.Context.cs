//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ModuleKhachHang
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using ModuleKhachHang.Model;

    public partial class akabiz_contactEntities : DbContext
    {
        public akabiz_contactEntities()
            : base("name=akabiz_contactEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contact> Contacts { get; set; }
    }
}

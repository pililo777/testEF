﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bd_notasAlumnosEntities : DbContext
    {
        public bd_notasAlumnosEntities()
            : base("name=bd_notasAlumnosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alumno> alumnos { get; set; }
        public virtual DbSet<alums_asigs> alums_asigs { get; set; }
        public virtual DbSet<asignatura> asignaturas { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetFinalEval
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bd_evaluationEntities3 : DbContext
    {
        public bd_evaluationEntities3()
            : base("name=bd_evaluationEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<collaborateurpe> collaborateurpe { get; set; }
        public virtual DbSet<collaborateurtitulaire> collaborateurtitulaire { get; set; }
        public virtual DbSet<critere> critere { get; set; }
        public virtual DbSet<evaluation> evaluation { get; set; }
        public virtual DbSet<famillecritere> famillecritere { get; set; }
        public virtual DbSet<fonction> fonction { get; set; }
        public virtual DbSet<freelance> freelance { get; set; }
        public virtual DbSet<projet> projet { get; set; }
        public virtual DbSet<tache> tache { get; set; }
        public virtual DbSet<variable> variable { get; set; }
    }
}

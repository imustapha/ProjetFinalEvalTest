//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class fonction
    {
        public fonction()
        {
            this.collaborateurpe = new HashSet<collaborateurpe>();
            this.collaborateurtitulaire = new HashSet<collaborateurtitulaire>();
        }
    
        public int IDFONCTION { get; set; }
        public string NOMFONCTION { get; set; }
    
        public virtual ICollection<collaborateurpe> collaborateurpe { get; set; }
        public virtual ICollection<collaborateurtitulaire> collaborateurtitulaire { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GESTION__MIFA
{
    using System;
    using System.Collections.Generic;
    
    public partial class livraison
    {
        public int idlivraison { get; set; }
        public string adresse { get; set; }
        public int idcom { get; set; }
        public System.DateTime datelivraison { get; set; }
        public int idc { get; set; }
    
        public virtual client client { get; set; }
        public virtual commande commande { get; set; }
    }
}

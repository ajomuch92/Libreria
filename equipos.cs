//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libreria
{
    using System;
    using System.Collections.Generic;
    
    public partial class equipos
    {
        public equipos()
        {
            this.campeonatos = new HashSet<campeonatos>();
            this.campeonatos1 = new HashSet<campeonatos>();
            this.partidos = new HashSet<partidos>();
        }
    
        public int id_equipo { get; set; }
        public string equipo { get; set; }
    
        public virtual ICollection<campeonatos> campeonatos { get; set; }
        public virtual ICollection<campeonatos> campeonatos1 { get; set; }
        public virtual ICollection<partidos> partidos { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace creations.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class EvaluationCompleted
    {
        public int Id { get; set; }
        public int IdExpedient { get; set; }
        public int IdQuestion { get; set; }
        public int IdAnswer { get; set; }
        public bool IsCorrect { get; set; }
        public System.DateTime CompletedAt { get; set; }
    
        public virtual Answer Answer { get; set; }
        public virtual Expedient Expedient { get; set; }
        public virtual Question Question { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.db.Iter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using xwcs.core.db;
    using xwcs.core.db.binding.attributes;
    using xwcs.core.db.model.attributes;
    
    public partial class tipolabel : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipolabel()
        {
    
            this.labels = new HashSet<labels>();
    	}
    
    		private string _tipo;
    	public string tipo 
    	{ 
    		get { return _tipo; } 
    		set { SetProperty(ref _tipo, value); } 
    	}
    
    	private int _rowversion;
    	public int rowversion 
    	{ 
    		get { return _rowversion; } 
    		set { SetProperty(ref _rowversion, value); } 
    	}
    
    
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<labels> labels { get; set; }
    }
}

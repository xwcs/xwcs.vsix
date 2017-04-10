//------------------------------------------------------------------------------
// <auto-generated>
// By: Laco
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.db.iter_new
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using xwcs.core.db;
    using xwcs.core.db.binding.attributes;
    using xwcs.core.db.model.attributes;
     
    // This class is just for meta attributes editing
    // Do not write any logic here, it will be not considered
    // Copy this class somewhere else this one will be overridden!!!
    
    public class iter_meta
    {
    	#region properties
    
    	[Display(Name="Id")]
    	public long id { get; set;}
    
    	[Display(Name="Nrecord")]
    	public long nrecord { get; set;}
    
    	[Display(Name="Ncopia")]
    	public long ncopia { get; set;}
    
    	[Display(Name="Versione")]
    	public string versione { get; set;}
    
    	[Display(Name="Build")]
    	public long build { get; set;}
    
    	[Display(Name="Id_tipologie")]
    	public long id_tipologie { get; set;}
    
    	[Display(Name="Tipi_tipo")]
    	public string tipi_tipo { get; set;}
    
    	[Display(Name="Datadoc")]
    	public Nullable<System.DateTime> datadoc { get; set;}
    
    	[Display(Name="Decade")]
    	public Nullable<System.DateTime> decade { get; set;}
    
    	[Display(Name="OTA")]
    	public string OTA { get; set;}
    
    	[Display(Name="Oggetto_uff")]
    	public string oggetto_uff { get; set;}
    
    	[Display(Name="Data")]
    	public Nullable<System.DateTime> data { get; set;}
    
    	[Display(Name="Numero")]
    	public string numero { get; set;}
    
    	[Display(Name="Articolo")]
    	public Nullable<long> articolo { get; set;}
    
    	[Display(Name="Art_estens")]
    	public string art_estens { get; set;}
    
    	[Display(Name="Protocollo")]
    	public string protocollo { get; set;}
    
    	[Display(Name="Id_editori")]
    	public Nullable<long> id_editori { get; set;}
    
    	[Display(Name="Id_fonti")]
    	public Nullable<long> id_fonti { get; set;}
    
    	[Display(Name="Fonte_data")]
    	public Nullable<System.DateTime> fonte_data { get; set;}
    
    	[Display(Name="Fonte_numero")]
    	public string fonte_numero { get; set;}
    
    	[Display(Name="Viol_gruppo_ipotesi")]
    	public string viol_gruppo_ipotesi { get; set;}
    
    	[Display(Name="Viol_ipotesi")]
    	public string viol_ipotesi { get; set;}
    
    	[Display(Name="Viol_norma_violata")]
    	public string viol_norma_violata { get; set;}
    
    	[Display(Name="Parte")]
    	public string parte { get; set;}
    
    	[Display(Name="Parti_collegate")]
    	public string parti_collegate { get; set;}
    
    	[Display(Name="Storico")]
    	public Nullable<bool> storico { get; set;}
    
    	[Display(Name="Stati_stato")]
    	public string stati_stato { get; set;}
    
    	[Display(Name="Hide")]
    	public Nullable<bool> hide { get; set;}
    
    	[Display(Name="Hide_reason")]
    	public string hide_reason { get; set;}
    
    	[Display(Name="Prezzo")]
    	public Nullable<double> prezzo { get; set;}
    
    	[Display(Name="PrezzoForzato")]
    	public Nullable<bool> prezzoForzato { get; set;}
    
    	[Display(Name="VigenteDa")]
    	public Nullable<System.DateTime> vigenteDa { get; set;}
    
    	[Display(Name="VigenteA")]
    	public Nullable<System.DateTime> vigenteA { get; set;}
    
    	[Display(Name="VisibileDa")]
    	public Nullable<System.DateTime> visibileDa { get; set;}
    
    	[Display(Name="VisibileA")]
    	public Nullable<System.DateTime> visibileA { get; set;}
    
    	[Display(Name="DataAggiornamento")]
    	public Nullable<System.DateTime> dataAggiornamento { get; set;}
    
    	#endregion
    
    }
    
    
    // This class couple its entity and it should be use
    // for extending functionalities of Entity class
    // here can be add de-serialized complex fields
    // or other necessary logic
    // copy this class to some other place
    // changes in this place will be overridden !!!
    
    [MetadataType(typeof(iter_meta))]
    public partial class iter
    {
    	// custom implementations
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.db.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using xwcs.core.db;
    using xwcs.core.db.binding.attributes;
    using xwcs.core.db.model.attributes;
    
    public partial class bab : SerializedEntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bab()
        {
    
    	}
    
    	public override void GetMutablePropertiesType(Dictionary<string, Type> dest) {
    		dest.Add("content_dump_xml_obj", _content_dump_xml_obj != null ? _content_dump_xml_obj.GetType() : typeof(object));
    
    	}	
    	
    
        private int _id;
    	public int id 
    	{ 
    		get { return _id; } 
    		set { SetProperty(ref _id, value); } 
    	}
    
        private int _random;
    	public int random 
    	{ 
    		get { return _random; } 
    		set { SetProperty(ref _random, value); } 
    	}
    
        private string _dictionary;
    	public string dictionary 
    	{ 
    		get { return _dictionary; } 
    		set { SetProperty(ref _dictionary, value); } 
    	}
    
        private string _text;
    	public string text 
    	{ 
    		get { return _text; } 
    		set { SetProperty(ref _text, value); } 
    	}
    
        private string _rpa;
    	public string rpa 
    	{ 
    		get { return _rpa; } 
    		set { SetProperty(ref _rpa, value); } 
    	}
    
        private string _cc;
    	public string cc 
    	{ 
    		get { return _cc; } 
    		set { SetProperty(ref _cc, value); } 
    	}
    
        private string _dxp;
    	public string dxp 
    	{ 
    		get { return _dxp; } 
    		set { SetProperty(ref _dxp, value); } 
    	}
    
        private int _ndoc;
    	public int ndoc 
    	{ 
    		get { return _ndoc; } 
    		set { SetProperty(ref _ndoc, value); } 
    	}
    
        private string _xml;
    	public string xml 
    	{ 
    		get { return _xml; } 
    		set { SetProperty(ref _xml, value); } 
    	}
    
        private string _extra;
    	public string extra 
    	{ 
    		get { return _extra; } 
    		set { SetProperty(ref _extra, value); } 
    	}
    
        private string _content_dump_xml;
    	public string content_dump_xml 
    	{ 
    		get { return SerializeAndGet(_content_dump_xml_obj, ref _content_dump_xml); } 
    		set { SetProperty(ref _content_dump_xml, value); } 
    	}
    
    	private object _content_dump_xml_obj = null;
    	[NotMapped]
    	[Mutable]
    	public object content_dump_xml_obj 
    	{ 
    		get { return GetOrDeserialize(_content_dump_xml, "content_dump_xml", ref _content_dump_xml_obj); } 
    		set { SetProperty(ref _content_dump_xml_obj, value); } 
    	}
    
    	public override void DeserializeFields(){
    		object o;
    		o = content_dump_xml_obj;
    
    	} 
     	public override void SerializeFields(){
    		string s;
    		s = content_dump_xml;
     
    	}
    
        public virtual bab_local bab_local { get; set; }
    }
}

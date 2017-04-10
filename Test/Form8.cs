using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.db.iter_new;

namespace Test
{
    public partial class Form8: Form
    {
		niter_newEntities3 ctx;
		xwcs.core.db.binding.GridBindingSource bs;

		class iter_short {
			public long nrecord;
			public long id;
		}

		public Form8()
        {
            InitializeComponent();
			ctx = new niter_newEntities3();
			ctx.Database.Log = Console.WriteLine;
			bs = new xwcs.core.db.binding.GridBindingSource();
			bs.Grid = gridControl1;
			//IQueryable<iter_short> it = from i in ctx.iter where i.stati_stato != "modificato" select new iter_short { nrecord = i.nrecord, id = i.id };
			
			bs.DataSource = (
				from i in ctx.iter.Where(i => i.stati_stato != "removed")
					join io in ctx.iter_in_opere.Where(io =>
								!(io.modificato ?? false) &&
								(io.forzato ?? true)
						).Select(io => new { io.id_opere, nrecord = io.nrecord }) on i.nrecord equals io.nrecord into tmp

					from t in tmp
					join o in ctx.opere
						.Where(o => o.usabile_in_iter == 1 &&
								(new string[] { "AOL", "KOL", "EOL" }).Contains(o.descrizione)
						) on t.id_opere equals o.id
					select new { i.tipologie.tipo }
				).Distinct().ToList();
        }
    }
}

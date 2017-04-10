using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using Test.db.model1;
using xwcs.core.db.binding;
using xwcs.core.ui.db;

namespace Test
{
	public partial class Form2 : Form , IEditorsHost
    {

		test1Entities ctx;
		test1Entities1 ctx1;

		xwcs.core.db.binding.DataLayoutBindingSource bs;
        private FormSupport _formSupport;
        public IFormSupport FormSupport
        {
            get
            {
                if (_formSupport == null)
                {
                    // form support must exist first
                    _formSupport = new xwcs.core.ui.db.FormSupport();
                }
                return _formSupport;
            }
        }

        public Form2()
		{

			InitializeComponent();

			ctx = new test1Entities();
			ctx1 = new test1Entities1();

			

			ctx.Database.Log = xwcs.core.manager.SLogManager.getInstance().Debug; // Console.Write;

			
			bs = new xwcs.core.db.binding.DataLayoutBindingSource(this);
			bs.DataSource = ctx.bab.Where(s => s.id == 100).ToList();
			
            /*
			bs.GetFieldQueryable += (sender, d) =>
			{
				switch (d.FieldName)
				{
					case "cc":
						d.DataSource = ctx1.names.ToList();
						break;
				}
			};
            */

			bs.DataLayout = dataLayoutControl1;			
			


		}

        public void onGetOptionsList(object sender, GetFieldOptionsListEventData qd)
        {
            switch (qd.FieldName)
            {
                case "cc":
                    qd.Data = ctx1.names.ToList();
                    break;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			object snapShot = bs.Current;

			ctx.SaveChanges();

			bs.DataSource = ctx.bab.Where(s => s.id == 200).ToList();
		}
	}
}

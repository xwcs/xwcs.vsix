using DevExpress.Utils.Win;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		DateRangeCollection range { get; set; }

		private void dateEdit1_Popup(object sender, EventArgs e)
		{
			PopupDateEditForm popupForm = ((sender as IPopupControl).PopupWindow as PopupDateEditForm);
			if (popupForm != null)
				range = (popupForm.Calendar as CalendarControl).SelectedRanges;
		}

		private void dateEdit1_QueryPopUp(object sender, CancelEventArgs e)
		{
			PopupDateEditForm popupForm = ((sender as IPopupControl).PopupWindow as PopupDateEditForm);
			if (popupForm != null)
				range = (popupForm.Calendar as CalendarControl).SelectedRanges;
		}

		private void dateEdit1_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
		{
			if (range != null)
			{
				e.DisplayText = String.Format("{0} - {1}", range[0].StartDate, range[0].EndDate);
			}
		}
	}
}

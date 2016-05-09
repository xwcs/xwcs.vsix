using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class CreateBozzaGuard {
        public override bool Execute()
        {
            // Will throw a GuardException when condition goes wrong
			// Check CreateBozza
			var confirmResult =  MessageBox.Show("Please confirm that condition 'CreateBozza' is valid",
                                    "Confirm Status Change",
                                    MessageBoxButtons.YesNo);

			return (confirmResult == DialogResult.Yes) ;
        }
	}

}
// End of Tempate

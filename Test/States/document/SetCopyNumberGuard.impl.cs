using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class SetCopyNumberGuard {
        public override bool Execute()
        {
            // Will throw a GuardException when condition goes wrong
			// Check SetCopyNumber
			var confirmResult =  MessageBox.Show("Please confirm that condition 'SetCopyNumber' is valid",
                                    "Confirm Status Change",
                                    MessageBoxButtons.YesNo);

			return (confirmResult == DialogResult.Yes) ;
        }
	}

}
// End of Tempate

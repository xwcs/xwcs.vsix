using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public class DocumentStateTestForm : xwcs.core.statemachine.test.TestFormBase {
		protected override StateMachine CreateMachine()
		{
			return new DocumentState(this);
		}
	}	

}
// End of Tempate

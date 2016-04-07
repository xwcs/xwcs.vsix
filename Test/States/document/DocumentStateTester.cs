using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public class DocumentStateTestForm : xwcs.core.statemachine.test.TestFormBase {
		protected override StateMachine CreateMachine()
		{
			StateMachine sm = new DocumentState(this); 


		
			(sm as DocumentState).RecordRejected += (s, e) => { Log("Effect : RecordRejected called.");};

		
			(sm as DocumentState).NotifyValidators += (s, e) => { Log("Effect : NotifyValidators called.");};

	
		
			return sm;
		}
	}	

}
// End of Tempate

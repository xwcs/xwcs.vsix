using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class CreateTrigger : TriggerBase {
		public CreateTrigger(StateMachine machine) : base (machine, "CreateTrigger") {}
	}	

}
// End of Tempate

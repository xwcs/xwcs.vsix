using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class InvalidateTrigger : TriggerBase {
		public InvalidateTrigger(StateMachine machine) : base (machine, "InvalidateTrigger") {}
	}	

}
// End of Tempate

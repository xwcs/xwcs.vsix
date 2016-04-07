using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class ValidateTrigger : TriggerBase {
		public ValidateTrigger(StateMachine machine) : base (machine, "ValidateTrigger") {}
	}	

}
// End of Tempate

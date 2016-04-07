using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class RemoveTrigger : TriggerBase {
		public RemoveTrigger(StateMachine machine) : base (machine, "RemoveTrigger") {}
	}	

}
// End of Tempate

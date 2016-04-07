using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class ConsolidateTrigger : TriggerBase {
		public ConsolidateTrigger(StateMachine machine) : base (machine, "ConsolidateTrigger") {}
	}	

}
// End of Tempate

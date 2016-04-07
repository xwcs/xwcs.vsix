using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class SaveTrigger : TriggerBase {
		public SaveTrigger(StateMachine machine) : base (machine, "SaveTrigger") {}
	}	

}
// End of Tempate

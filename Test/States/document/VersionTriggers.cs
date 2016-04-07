using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class VersionTrigger : TriggerBase {
		public VersionTrigger(StateMachine machine) : base (machine, "VersionTrigger") {}
	}	

}
// End of Tempate

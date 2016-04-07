using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class HideTrigger : TriggerBase {
		public HideTrigger(StateMachine machine) : base (machine, "HideTrigger") {}
	}	

}
// End of Tempate

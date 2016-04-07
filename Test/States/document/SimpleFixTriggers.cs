using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace

	public partial class SimpleFixTrigger : TriggerBase {
		public SimpleFixTrigger(StateMachine machine) : base (machine, "SimpleFixTrigger") {}
	}	

}
// End of Tempate

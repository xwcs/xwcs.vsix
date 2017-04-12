using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace
	public partial class ConsolidatoState : StateBase	{ 
		public ConsolidatoState(StateMachine machine) : base(machine, "Consolidato") { }

        /// <summary>
        /// Returns a list of callable triggers, it will 
        /// </summary>
		protected override void InitTriggers()
        {
			AddTrigger(new RejectTrigger(StateMachine)) ;
			AddTrigger(new ValidateTrigger(StateMachine)) ;
        }

	}

}
// End of Tempate
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace
	public partial class ValidatoState : StateBase	{ 
		public ValidatoState(StateMachine machine) : base(machine, "Validato") { }

        /// <summary>
        /// Returns a list of callable triggers, it will 
        /// </summary>
		protected override void InitTriggers()
        {
			AddTrigger(new InvalidateTrigger(StateMachine)) ;
			AddTrigger(new PublishTrigger(StateMachine)) ;
			AddTrigger(new VersionTrigger(StateMachine)) ;
			AddTrigger(new SimpleFixTrigger(StateMachine)) ;
			AddTrigger(new RejectTrigger(StateMachine)) ;
        }

	}

}
// End of Tempate
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace
	public partial class ValidatoVersionatoState : StateBase	{ 
		public ValidatoVersionatoState(StateMachine machine) : base(machine, "ValidatoVersionato") { }

        /// <summary>
        /// Returns a list of callable triggers, it will 
        /// </summary>
		protected override void InitTriggers()
        {
			AddTrigger(new RevertTrigger(StateMachine)) ;
			AddTrigger(new PublishTrigger(StateMachine)) ;
			AddTrigger(new SimpleFixTrigger(StateMachine)) ;
        }

	}

}
// End of Tempate
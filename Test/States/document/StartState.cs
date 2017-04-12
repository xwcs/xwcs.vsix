using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace
	public partial class StartState : StateBase	{ 
		public StartState(StateMachine machine) : base(machine, "Start") { }

        /// <summary>
        /// Returns a list of callable triggers, it will 
        /// </summary>
		protected override void InitTriggers()
        {
			AddTrigger(new CreateTrigger(StateMachine)) ;
        }

	}

}
// End of Tempate
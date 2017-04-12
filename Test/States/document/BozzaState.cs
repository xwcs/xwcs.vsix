using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace
	public partial class BozzaState : StateBase	{ 
		public BozzaState(StateMachine machine) : base(machine, "Bozza") { }

        /// <summary>
        /// Returns a list of callable triggers, it will 
        /// </summary>
		protected override void InitTriggers()
        {
			AddTrigger(new ConsolidateTrigger(StateMachine)) ;
			AddTrigger(new RemoveTrigger(StateMachine)) ;
        }

	}

}
// End of Tempate
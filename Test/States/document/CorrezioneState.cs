using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace
	public partial class CorrezioneState : StateBase	{ 
		public CorrezioneState(StateMachine machine) : base(machine, "Correzione") { }

        /// <summary>
        /// Returns a list of callable triggers, it will 
        /// </summary>
		protected override void InitTriggers()
        {
			AddTrigger(new SaveTrigger(StateMachine)) ;
        }

	}

}
// End of Tempate
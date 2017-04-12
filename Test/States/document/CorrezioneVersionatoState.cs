using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace
	public partial class CorrezioneVersionatoState : StateBase	{ 
		public CorrezioneVersionatoState(StateMachine machine) : base(machine, "CorrezioneVersionato") { }

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
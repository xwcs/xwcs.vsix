using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace
	public partial class PubblicatoState : StateBase	{ 
		public PubblicatoState(StateMachine machine) : base(machine, "Pubblicato") { }

        /// <summary>
        /// Returns a list of callable triggers, it will 
        /// </summary>
		protected override void InitTriggers()
        {
			AddTrigger(new VersionTrigger(StateMachine)) ;
			AddTrigger(new HideTrigger(StateMachine)) ;
			AddTrigger(new SimpleFixTrigger(StateMachine)) ;
        }

	}

}
// End of Tempate
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace
	public partial class PubblicatoVersionatoState : StateBase 
	{ 
		public PubblicatoVersionatoState(StateMachine machine) : base(machine, "PubblicatoVersionato") { }

        /// <summary>
        /// Returns a list of callable triggers
        /// </summary>
        public override List<TriggerBase> GetTriggers()
        {
			List<TriggerBase> l = new List<TriggerBase>();
			l.Add(new RevertTrigger(StateMachine) ) ;
			l.Add(new HideTrigger(StateMachine) ) ;
			l.Add(new SimpleFixTrigger(StateMachine) ) ;
			return l ;
        }

	}

}
// End of Tempate
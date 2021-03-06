﻿
 


// Converting E:\Projekty\xwcs\xwcs.vsix\Test\States\document\DocumentStates.tastate into .cs file
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using xwcs.core.statemachine;

namespace Test.States.document { // StateMachineNamespace


	#region State Machine
	/// <summary>
    /// This class is the actual state machine designed in the State-Diagarm.
	/// </summary>
	public partial class DocumentState : StateMachine
	{
		/// <summary>
		/// Creates a new instance of this state machine.
		/// Pay attention to initialize (start or bind) the state machine
		/// </summary>
		public DocumentState(ISynchronizeInvoke si) : base(si) { 
			Name = "DocumentState";
		}

        public override void Start() {
            // initially we go into the StartState.
            this.TransitionToNewState(new StartState(this), null, null, null);
        }

		/// <summary>
		/// Makes the state machine react to a trigger.
		/// </summary>
		protected override void ProcessTriggerInternal(TriggerBase trigger)
		{
			if (this.CurrentState == null) return;
			if (trigger == null) throw new ArgumentException("tigger must not be null");

			// determine what action to take based on the current state
			// and the given trigger.
			if (this.CurrentState is StartState)
			{
				if (trigger is CreateTrigger)
				{
					SetCopyNumberGuard guard = new SetCopyNumberGuard(this) ;
					this.TransitionToNewState(new BozzaState(this), trigger, guard, null);
					return;
				}
			}
			if (this.CurrentState is BozzaState)
			{
				if (trigger is ConsolidateTrigger)
				{
					CheckListOkGuard guard = new CheckListOkGuard(this) ;
					this.TransitionToNewState(new ConsolidatoState(this), trigger, guard, NotifyValidators);

					return;
				}
				if (trigger is RemoveTrigger)
				{
					EraseGuard guard = new EraseGuard(this) ;
					this.TransitionToNewState(new EndState(this), trigger, guard, null);
					return;
				}
			}
			if (this.CurrentState is ConsolidatoState)
			{
				if (trigger is RejectTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new BozzaState(this), trigger, guard, RecordRejected);

					return;
				}
				if (trigger is ValidateTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new ValidatoState(this), trigger, guard, null);
					return;
				}
			}
			if (this.CurrentState is ValidatoState)
			{
				if (trigger is InvalidateTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new ConsolidatoState(this), trigger, guard, null);
					return;
				}
				if (trigger is PublishTrigger)
				{
					NotFallGuard guard = new NotFallGuard(this) ;
					this.TransitionToNewState(new PubblicatoState(this), trigger, guard, null);
					return;
				}
				if (trigger is VersionTrigger)
				{
					CreateBozzaGuard guard = new CreateBozzaGuard(this) ;
					this.TransitionToNewState(new ValidatoVersionatoState(this), trigger, guard, null);
					return;
				}
				if (trigger is SimpleFixTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new CorrezioneState(this), trigger, guard, null);
					return;
				}
				if (trigger is RejectTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new BozzaState(this), trigger, guard, null);
					return;
				}
			}
			if (this.CurrentState is PubblicatoState)
			{
				if (trigger is VersionTrigger)
				{
					CreateBozzaGuard guard = new CreateBozzaGuard(this) ;
					this.TransitionToNewState(new PubblicatoVersionatoState(this), trigger, guard, null);
					return;
				}
				if (trigger is HideTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new ValidatoState(this), trigger, guard, null);
					return;
				}
				if (trigger is SimpleFixTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new CorrezioneState(this), trigger, guard, null);
					return;
				}
			}
			if (this.CurrentState is CorrezioneState)
			{
				if (trigger is SaveTrigger)
				{
					RtfInGuard guard = new RtfInGuard(this) ;
					this.TransitionToNewState(new ValidatoState(this), trigger, guard, null);
					return;
				}
			}
			if (this.CurrentState is EndState)
			{
			}
			if (this.CurrentState is ValidatoVersionatoState)
			{
				if (trigger is RevertTrigger)
				{
					DupIsErasedGuard guard = new DupIsErasedGuard(this) ;
					this.TransitionToNewState(new ValidatoState(this), trigger, guard, null);
					return;
				}
				if (trigger is PublishTrigger)
				{
					NotFallGuard guard = new NotFallGuard(this) ;
					this.TransitionToNewState(new PubblicatoVersionatoState(this), trigger, guard, null);
					return;
				}
				if (trigger is SimpleFixTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new CorrezioneVersionatoState(this), trigger, guard, null);
					return;
				}
			}
			if (this.CurrentState is PubblicatoVersionatoState)
			{
				if (trigger is RevertTrigger)
				{
					DupIsErasedGuard guard = new DupIsErasedGuard(this) ;
					this.TransitionToNewState(new PubblicatoState(this), trigger, guard, null);
					return;
				}
				if (trigger is HideTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new ValidatoVersionatoState(this), trigger, guard, null);
					return;
				}
				if (trigger is SimpleFixTrigger)
				{
					DefaultGuardBase guard = null ;
					this.TransitionToNewState(new CorrezioneVersionatoState(this), trigger, guard, null);
					return;
				}
			}
			if (this.CurrentState is CorrezioneVersionatoState)
			{
				if (trigger is SaveTrigger)
				{
					RtfInGuard guard = new RtfInGuard(this) ;
					this.TransitionToNewState(new ValidatoVersionatoState(this), trigger, guard, null);
					return;
				}
			}
			// the start state
			if (this.CurrentState is StartState)
			{
				if (trigger is CreateTrigger)
				{
					SetCopyNumberGuard guard = new SetCopyNumberGuard(this) ;
					this.TransitionToNewState(new BozzaState(this), trigger, guard, null);
					return;
				}
			}
		}

		#region Events
		
		public event TransitionEventHandler RecordRejected;

		
		public event TransitionEventHandler NotifyValidators;

		#endregion
	}
	#endregion


}
// End of Tempate




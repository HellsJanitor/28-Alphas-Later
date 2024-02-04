using System;
using UnityEngine.Scripting;
using BaseAction = global::GameEvent.SequenceActions.BaseAction;
using ActionBaseTargetAction = global::GameEvent.SequenceActions.ActionBaseTargetAction;

namespace _28AL.CC.GameEvents.SequenceActions;

[Preserve]
public class ActionSetAttack : ActionBaseTargetAction
{
	public override ActionCompleteStates PerformTargetAction(Entity ent)
	{
		if(ent is EntityAlive ea){
			// ea.SetAttackTarget(Target, 60 * 20);
		}

		return ActionCompleteStates.Complete;
	}

	// EntityAlive a
}
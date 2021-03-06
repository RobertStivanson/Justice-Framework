﻿using JusticeFramework.Core.AI.BehaviourTree;

namespace JusticeFramework.AI.BehaviourNode {
    public class HealthLessThan : Leaf {
		protected override ENodeStatus OnTick(BehaviourTree.Context tick) {
			AiController controller = tick.blackboard.Get<AiController>("controller");
			float compareValue = tick.blackboard.Get<float>("hlt_healthTarget");
			
			return controller.Actor.CurrentHealth < compareValue ? ENodeStatus.Success : ENodeStatus.Failure;
		}
	}
}
﻿using JusticeFramework.Core.AI.BehaviourTree;
using JusticeFramework.Core.AI.BehaviourTree.Nodes;

namespace JusticeFramework.AI.BehaviourTree.Nodes.Conditions {
	public class HealthLessThan : Leaf {
		protected override ENodeStatus OnTick(TickState tick) {
			AiController controller = tick.blackboard.Get<AiController>("controller");
			float compareValue = tick.blackboard.Get<float>("hlt_healthTarget");
			
			return controller.Actor.CurrentHealth < compareValue ? ENodeStatus.Success : ENodeStatus.Failure;
		}
	}
}
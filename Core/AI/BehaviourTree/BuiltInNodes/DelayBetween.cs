﻿using System;
using UnityEngine;

namespace JusticeFramework.Core.AI.BehaviourTree.BuiltInNodes {
	[Serializable]
	public class DelayBetween : Decorator {
		[SerializeField]
		[HideInInspector]
		private float delay;

		public DelayBetween(float delayBetweenExecutions) {
			delay = delayBetweenExecutions;
		}

		protected override ENodeStatus OnTick(BehaviourTree.Context tick) {
			if (task == null) {
				return ENodeStatus.Error;
			}
			
			float lastTickTime = tick.blackboard.Get<float>("timeSinceLastTick", Id);
			
			if (lastTickTime == 0) {
				tick.blackboard.Set("timeSinceLastTick", Time.time, Id);
			} else {
				if ((Time.time - lastTickTime) < delay) {
					return ENodeStatus.Failure;
				}

				tick.blackboard.Set("timeSinceLastTick", Time.time, Id);
			}
			
			return task.Tick(tick);
		}
	}
}
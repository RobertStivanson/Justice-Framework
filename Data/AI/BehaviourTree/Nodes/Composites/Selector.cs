﻿using System;
using System.Collections.Generic;

namespace JusticeFramework.Data.AI.BehaviourTree.Nodes.Composites {
	[Serializable]
	public class Selector : Composite {
		public Selector() {
		}
		
		public Selector(List<Node> tasks) : base(tasks) {
		}
		
		protected override ENodeStatus OnTick(TickState tick) {
			for (int i = 0; i < tasks.Count; i++) {
				ENodeStatus childStatus = tasks[i].Tick(tick);

				if (childStatus != ENodeStatus.Failure) {
					return childStatus;
				}
			}
			
			return ENodeStatus.Failure;
		}
	}
}
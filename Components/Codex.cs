﻿using System;
using JusticeFramework.Data.Models;
using JusticeFramework.Data;
using JusticeFramework.Data.Events;
using JusticeFramework.Data.Interfaces;
using JusticeFramework.UI.Views;
using JusticeFramework.Utility.Extensions;

namespace JusticeFramework.Components {
	[Serializable]
	public class Codex : Item, ICodex {
#region Properties

		private CodexModel CodexModel {
			get { return model as CodexModel; }
		}
		
		public override EInteractionType InteractionType {
			get { return EInteractionType.Read; }
		}
		
		public string Text {
			get { return CodexModel.text; }
		}
		
#endregion
		
		public override void Activate(object sender, ActivateEventArgs e) {
			if (e?.Activator != null) {
				return;
			}

			if (ReferenceEquals(GameManager.Player, e?.ActivatedBy)) {
				CodexView view = UiManager.UI.OpenWindow<CodexView>();
				view.SetCodex(this);
			}
		}
	}
}
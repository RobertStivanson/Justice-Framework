﻿using JusticeFramework.Components;

namespace JusticeFramework.Interfaces {
	public delegate void OnCurrentHealthChanged(IDamageable damagable);
	public delegate void OnDamageTaken(IDamageable reciever, Reference sender, float amount);
	public delegate void OnHealingRecieved(IDamageable reciever, Reference sender, float amount);
	public delegate void OnDeath(IDamageable reciever, Reference sender);

	public interface IDamageable {
		event OnCurrentHealthChanged onCurrentHealthChanged;
		event OnDamageTaken onDamageTaken;
		event OnHealingRecieved onHealingRecieved;
		event OnDeath onDeath;

		float CurrentHealth { get; }
		int MaxHealth { get; }

		void Damage(Actor attacker, float damageAmount, bool ignoreDamageReduction = false);
		void Heal(Actor healer, float amount);
	}
}
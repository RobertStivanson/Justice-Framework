﻿using JusticeFramework.Components;
using JusticeFramework.Events;
using UnityEngine;

namespace JusticeFramework.Interfaces {
	/// <inheritdoc />
	/// <summary>
	/// Interface that defines attributes needed for equippable items
	/// </summary>
	public interface IEquippable : IItem {
		/// <summary>
		/// The slot that this item should be equipped to
		/// </summary>
		EEquipSlot EquipSlot { get; }
		
		/// <summary>
		/// The sounds played when the item is equipped
		/// </summary>
		AudioClip EquipSound { get; }

        /// <summary>
        /// The renderer attached to this object
        /// </summary>
        Renderer Renderer { get; }

        /// <summary>
        /// The rigidbody attached to this object
        /// </summary>
        Rigidbody Rigidbody { get; }

        /// <summary>
        /// The collider attached to this object
        /// </summary>
        Collider Collider { get; }
    }
}
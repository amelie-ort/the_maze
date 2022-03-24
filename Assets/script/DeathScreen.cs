// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DeathScean : MonoBehaviour
// {
//     // Health component of player
//     // public CharacterHealth CharacterHealth = null;
//     public CharacterHealth CharacterHealth
//     {
//         get
//         {
//             if (this.CharacterHealth == null)
//                 this.CharacterHealth = this.gameObject.GetComponentInParent<CharacterHealth>();
//             return this.CharacterHealth;
//         }
//     }

//     // Root of the view
//     private Transform deathScreenRoot = null;

//     void Awake()
//     {
//         // Register to health events
//         if (this.CharacterHealth != null)
//         {
//             this.CharacterHealth.OnDead.AddListener(this.OnDead);
//             this.CharacterHealth.OnRevive.AddListener(this.OnRevive);
//         }

//         // Hide
//         if (this.deathScreenRoot != null)
//             this.deathScreenRoot.gameObject.SetActive(false);
//     }

//     // UI Events
//     public void OnRespawnButtonClicked()
//     {
//         if (this.CharacterHealth != null)
//             this.CharacterHealth.Revive();
//     }

//     // Events
//     public void OnDead()
//     {
//         if (this.deathScreenRoot != null)
//             this.deathScreenRoot.gameObject.SetActive(true);
//     }
//     public void OnRevive()
//     {
//         if (this.deathScreenRoot != null)
//             this.deathScreenRoot.gameObject.SetActive(false);
//     }
// }

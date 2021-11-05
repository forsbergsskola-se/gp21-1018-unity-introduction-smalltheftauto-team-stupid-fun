// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class DetectFireDamage : MonoBehaviour
// {
//
//     public bool isInFire;
//     public bool stopDealDamage;
//     
//     
//     void Start()
//     {
//         
//     }

    
//     void Update()
//     {
//         if (isInFire == true)
//         {
//             if (stopDealDamage == false)
//             {
//                 stopDealDamage = true;
//                 StartCoroutine(DamageFromFire());
//             }
//         }
//     }
//
//     private void OnTriggerEnter(Collider col)
//     {
//         if (col.tag == "fire")
//         {
//             isInFire = true;
//         }
//     }
//     
//     private void OnTriggerExit(Collider col)
//     {
//         if (col.tag == "fire")
//         {
//             isInFire = false;
//         }
//     }
//
//     IEnumerable DamageFromFire()
//     {
//         yield return new WaitForSeconds(1);
//         
//     }
// }

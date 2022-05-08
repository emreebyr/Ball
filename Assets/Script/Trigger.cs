using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    UnityEngine.Events.UnityEvent<string> triggerEvent;

    public int score = 0 ;
    public void OnTriggerEnter(Collider other) {
       Destroy (other.gameObject);
       score  ++ ;
       Debug.Log ("Score" +score);
       

       triggerEvent.Invoke (score.ToString());

       
   }
}

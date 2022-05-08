using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winbox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        GameObject.Find("Top").SendMessage("Finnish");
    }
}

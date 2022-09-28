using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public GameObject WinText;
     private void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "Player"){
            WinText.SetActive(true);
            Destroy(gameObject);
        }  
    }
}

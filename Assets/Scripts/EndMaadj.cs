using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMaadj : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        Fade.setFadeOut(true);
    }
}

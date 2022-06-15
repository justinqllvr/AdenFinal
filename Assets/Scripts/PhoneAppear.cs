using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneAppear : MonoBehaviour
{

    public GameObject tutoUI;
    public GameObject queteTitleUI;
    public GameObject queteUI;
    public GameObject phoneUI;
    public int queteDelay;
    public int tutoDelay;
    public int phoneDelay;

    private void Start() {
        StartCoroutine(tutoCoroutine());
    }

    IEnumerator queteCoroutine() {
        yield return new WaitForSeconds(queteDelay);
        queteTitleUI.SetActive(true);
        StartCoroutine(queteEnd());
    }

    IEnumerator queteEnd() {
        yield return new WaitForSeconds(3);
        queteTitleUI.SetActive(false);
        queteUI.SetActive(true);
        StartCoroutine(phoneCoroutine());
    }

    IEnumerator tutoCoroutine() {
        yield return new WaitForSeconds(tutoDelay);
        tutoUI.SetActive(true);
        StartCoroutine(tutoEnd());
    }

    IEnumerator tutoEnd() {
        yield return new WaitForSeconds(4);
        tutoUI.SetActive(false);
        StartCoroutine(queteCoroutine());
    }

    IEnumerator phoneCoroutine() {
        yield return new WaitForSeconds(phoneDelay);
        phoneUI.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayInfo : MonoBehaviour
{
    [SerializeField] TMP_Text infoText;

    public void DispText(){
        StartCoroutine(DisplayInfoText());
    }
    
    IEnumerator DisplayInfoText(){
        infoText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        infoText.gameObject.SetActive(false);
    }
}
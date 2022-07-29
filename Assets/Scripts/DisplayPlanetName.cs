using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;
using TMPro;

  
public class DisplayPlanetName: MonoBehaviour {  
  
  public TMP_Text planetNameText;
  
  private void Start() {
    planetNameText=(TMP_Text)FindObjectOfType(typeof(TMP_Text));
  }

  void OnMouseDown() {  
    if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) {  
        planetNameText.text=hit.transform.name;
      }  
    }  
  }  
}   
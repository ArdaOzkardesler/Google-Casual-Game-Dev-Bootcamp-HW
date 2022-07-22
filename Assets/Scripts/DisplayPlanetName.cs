using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;
using TMPro;

  
public class DisplayPlanetName: MonoBehaviour {  
  
  [SerializeField] TMP_Text planetNameText;
  
  // Update is called once per frame    
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
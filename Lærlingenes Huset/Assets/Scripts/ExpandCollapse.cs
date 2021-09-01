using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpandCollapse : MonoBehaviour
{
  private bool IsExpanded;
 // public GameObject houseCollapsed;
 // public GameObject houseExpanded;
  public Button yourButton;
  public Vector3 originalPosition;
  public Vector3 newPosition;
  public GameObject gameObject;


  private void Start()
  {
    IsExpanded = false;
   // houseCollapsed.SetActive(true);
   // houseExpanded.SetActive(false);
    gameObject.transform.position = originalPosition;

    Button btn = yourButton.GetComponent<Button>();
    btn.onClick.AddListener(Click);
  }

  private void Click()
  {
    if (IsExpanded == false)
    {
      //houseCollapsed.SetActive(false);
      //houseExpanded.SetActive(true);
      IsExpanded = true;
      gameObject.transform.position = newPosition;
    }
    
    else if (IsExpanded == true)
    {
      //houseCollapsed.SetActive(true);
     // houseExpanded.SetActive(false);
      IsExpanded = false;
      gameObject.transform.position = originalPosition;
    }
  
   
  }
 
}

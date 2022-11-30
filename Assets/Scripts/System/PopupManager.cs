using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    public GameObject popup;
    void Start()
    {
        
    }

    public void ClosePopup()
    {
        popup.gameObject.SetActive(false);
    }
  


}

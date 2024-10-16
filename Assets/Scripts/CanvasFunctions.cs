using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasFunctions : MonoBehaviour
{

    public GameObject panelMenu;
    public GameObject panelHud;

   public void MifuncionDeBoton(){
        panelMenu.SetActive(false);
        panelHud.SetActive(true);
   }
}

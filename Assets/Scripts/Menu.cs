using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject MenuPrincipal;

    private void Start()
    {
          Time.timeScale = 0;
    }
    public void Jogar()
    {
        Time.timeScale = 1;
        //transform.getchild(0).gameobject.setActive(false);
        MenuPrincipal.SetActive(false);   
    }


      public  void Sair()
    {
        Application.Quit();
    }
}

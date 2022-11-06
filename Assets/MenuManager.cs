using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    
   public void OnPlaneSceneSelected()
    {
        SceneManager.LoadScene("Ar_1");
    }
    public void OnMarkerSelected()
    {
        SceneManager.LoadScene("Ar_2");
    }


}


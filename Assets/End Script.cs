using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public void Restart()
   {
		  SceneManager.LoadSceneAsync(1);
   }

    public void EndGame()
   {
		  Application.Quit();
   }
}

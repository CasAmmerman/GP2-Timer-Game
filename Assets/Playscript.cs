using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playscript : MonoBehaviour
{
   public void PlayGame()
   {
		  SceneManager.LoadSceneAsync(1);
   }
   public void EndGame()
   {
		  Application.Quit();
   }

   public void RestartGame()
   {
		  SceneManager.LoadSceneAsync(0);
   }
}

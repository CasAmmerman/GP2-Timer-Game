using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercollision : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D Collision)
{
	if(Collision.transform.tag == "Tree")
	{
	  SceneManager.LoadSceneAsync(2);
	}
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePicture : MonoBehaviour
{

	public Material[] myMaterials360;
	public float timeDelay = 5.0f;


	public void Start ()
	{

		StartCoroutine (PictureSlider ());


	}


	IEnumerator PictureSlider ()
	{

		for (int i = 0; i < myMaterials360.Length; i++) {

//			Debug.Log ("Entering loop function");

			yield return new WaitForSeconds (timeDelay);

			gameObject.GetComponent<Renderer> ().material = myMaterials360 [i];

//			Debug.Log ("Material #: " + i + " is rendered");

		}

	}


}

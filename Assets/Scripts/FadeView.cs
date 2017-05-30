using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeView : MonoBehaviour
{


	// Fading is done by controlling the alpha of a canvas that is put in front of the camera to block the view.
	// The canvas has a Canvas Group and its alpha is changed in the Fade() function.
	// This is put on the FadeCanvas in front of the Camera and is also called by the Movement360 script on the information stand to call this function
	// doFadeToSphere()
	// It calls the Movement360 script to move to and back from the 360 Sphere.

	public CanvasGroup fadeCanvasGroup;

	public GameObject Picture360;
	public GameObject Video360;


	// Calling the movement script
	public Movement360 movement360;

	public float fadeOutSpeed = 1f;
	public float fadeInSpeed = 1f;


	public void FadeOutAndInToInitialPosition ()
	{


		//Do fade out and In and go to initial location
		StartCoroutine (doFadeBackToInitial ());

	}



	public void FadeOutAndInTo360PictureSphere ()
	{

		if (!Picture360.activeSelf) {
			Picture360.SetActive (true);
		}

//		Picture360.SetActive (true);

		//Then do fade out and In and go to initial location
		StartCoroutine (doFadeTo360PictureSphere ());

	}


	public void FadeOutAndInTo360VideoSphere ()
	{

		if (!Video360.activeSelf) {
			Video360.SetActive (true);
		}

//		Video360.SetActive (true);
		//Then do fade out and In and go to initial location
		StartCoroutine (doFadeTo360VideoSphere ());

	}



	// This function fades out and in and moves the Camera back to its initial location in front of the information stand

	private IEnumerator doFadeBackToInitial ()
	{
		yield return StartCoroutine (Fade (1f, fadeOutSpeed));

		//Hide the spheres after fading out
		if (Picture360.activeSelf) {
			Picture360.SetActive (false);
		}

		if (Video360.activeSelf) {
			Video360.SetActive (false);
		}

		//Return the Camera to its initial location
		movement360.MoveBack ();

		yield return StartCoroutine (Fade (0f, fadeInSpeed));

	}



	// This function fades out and in and moves the Camera to the center of the 360 sphere

	private IEnumerator doFadeTo360PictureSphere ()
	{
		yield return StartCoroutine (Fade (1f, fadeOutSpeed));


		//Move the Camera to the center of the 360 Sphere
		movement360.MoveToPicture360Sphere ();

		yield return StartCoroutine (Fade (0f, fadeInSpeed));

	}



	private IEnumerator doFadeTo360VideoSphere ()
	{
		yield return StartCoroutine (Fade (1f, fadeOutSpeed));


		//Move the Camera to the center of the 360 Sphere
		movement360.MoveToVideo360Sphere ();

		yield return StartCoroutine (Fade (0f, fadeInSpeed));

	}



	// The Main fading function. From Unity Tutorial (Adventure Market);

	private IEnumerator Fade (float finalAlpha, float fadeSpeed)
	{

		fadeCanvasGroup.blocksRaycasts = true;
	
		while (!Mathf.Approximately (fadeCanvasGroup.alpha, finalAlpha)) {
			fadeCanvasGroup.alpha = Mathf.MoveTowards (fadeCanvasGroup.alpha, finalAlpha, fadeSpeed * Time.deltaTime);
			yield return null;
		}

		fadeCanvasGroup.blocksRaycasts = false;
	}




	//	public void FadeOut ()
	//	{
	//
	//		StartCoroutine (Fade (1f, fadeOutSpeed));
	//
	//	}
	//
	//
	//	public void FadeIn ()
	//	{
	//
	//		StartCoroutine (Fade (0f, fadeInSpeed));
	//
	//	}

}

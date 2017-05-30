using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement360 : MonoBehaviour
{

	// This is put on the information stand

	public GameObject mainCamera;
	public Transform CameraLocation360PictureISS;
	public Transform CameraLocation360VideoISS;
	public Transform initialCameraPosition;


	// Moves the Camera to the Center of the 360 Sphere
	public void MoveToPicture360Sphere ()
	{
		mainCamera.transform.position = CameraLocation360PictureISS.transform.position;
	
	}


	public void MoveToVideo360Sphere ()
	{
		mainCamera.transform.position = CameraLocation360VideoISS.transform.position;
	
	}



	// Moves the Camera back to be in front of the information stand
	public void MoveBack ()
	{

		mainCamera.transform.position = initialCameraPosition.transform.position;


	}
	

}

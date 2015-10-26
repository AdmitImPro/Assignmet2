/* Author: Arunan Shan */
/* File: HeartController.cs */
/* Creation Date: Oct 19, 2015 */
/* Description: This script destroys the heart game object on collision*/
/* Last Modified by: Monday October 25, 2015 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeartController : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D otherGameObject) 
	{
		if (otherGameObject.tag == "Player") {
			
			
			Destroy(gameObject);
		}
		
		
	}
	
	
}

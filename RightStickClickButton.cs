using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightStickClickButton : MonoBehaviour
{

	private RectTransform rect;
	private ParticleSystem part;
	private Transform trans;
	private Player1Controller button;
	private bool isPressed;
	private bool playing;

	public GameObject xboxController;

	// Use this for initialization
	void Start()
	{

		rect = GetComponent<RectTransform>();
		part = GetComponent<ParticleSystem>();
		trans = rect.transform;
		button = xboxController.GetComponent<Player1Controller>();
	}

	// Update is called once per frame
	void Update()
	{
		if (button.rightStickButton == true) //if A button goes down
		{
			if (part.isPlaying == false) //and if particle system is not playing
			{
				trans.localPosition = new Vector3(Random.Range(-70, -1000), Random.Range(-500, 500), Random.Range(200, 300)); //pick a random location within the button square and move to it
				part.Play(true); //play the animation
				Component[] children = GetComponentsInChildren<ParticleSystem>(); //create an array of all the children of the particle system
				foreach (ParticleSystem childParticleSystem in children) //for each child
				{
					childParticleSystem.Play(true); //play the partcle system
				}
			}
		}
	}
}

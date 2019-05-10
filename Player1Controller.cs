using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Controller : MonoBehaviour {

	//buttons
	public bool aButton;
	public bool bButton;
	public bool xButton;
	public bool yButton;
	public bool lbButton;
	public bool rbButton;
	public bool selectButton;
	public bool startButton;
	public bool leftStickButton;
	public bool rightStickButton;
	
	//axes
	public bool leftTrigger;
	public bool rightTrigger;
	public bool leftStickRight;
	public bool leftStickLeft;
	public bool leftStickDown;
	public bool leftStickUp;
	public bool rightStickRight;
	public bool rightStickLeft;
	public bool rightStickDown;
	public bool rightStickUp;
	public bool dPadRight;
	public bool dPadLeft;
	public bool dPadUp;
	public bool dPadDown;
	
	// Update is called once per frame
	void Update () {

		#region Xbox Controller Buttons

		//--> Core Buttons Start
		if (Input.GetButtonDown("XboxA"))
		{			
			//A Button
			print("A button");
			aButton = true;
		} else
		{
			aButton = false;
		}
		if (Input.GetButton("XboxB"))
		{
			//B Button
			print("B button");
			bButton = true;
		}
		else
		{
			bButton = false;
		}
		if (Input.GetButton("XboxX"))
		{
			//X Button
			print("X button");
			xButton = true;
		}
		else
		{
			xButton = false;
		}
		if (Input.GetButton("XboxY"))
		{
			//Y Button
			print("Y button");
			yButton = true;
		}
		else
		{
			yButton = false;
		}

		if (Input.GetButton("XboxLB"))
		{
			//Left Bumper Button
			print("LB button");
			lbButton = true;
		}
		else
		{
			lbButton = false;
		}
		if (Input.GetButton("XboxRB"))
		{
			//Right Bumper Button
			print("RB button");
			rbButton = true;
		}
		else
		{
			rbButton = false;
		}
		//--> Core Buttons End

		//--> Start/Select Buttons Start
		if (Input.GetButton("XboxSelect"))
		{
			//Select Button
			print("Select button");
			selectButton = true;
		}
		else
		{
			selectButton = false;
		}
		if (Input.GetButton("XboxStart"))
		{
			//Start Button
			print("Start button");
			startButton = true;
		}
		else
		{
			startButton = false;
		}
		//--> Start/Select Buttons End

		//--> Xbox Stick Clicks Start
		if (Input.GetButton("XboxClickLeftStick"))
		{
			//Left Stick Click Button
			print("Left Stick button");
			leftStickButton = true;
		}
		else
		{
			leftStickButton = false;
		}
		if (Input.GetButton("XboxClickRightStick"))
		{
			//Right Stick Click Button
			print("Right Stick button");
			rightStickButton = true;
		}
		else
		{
			rightStickButton = false;
		}
		//--> Xbox Stick Clicks End

		#endregion

		#region Xbox Controller Axes

		if (Input.GetAxis("XboxLeftTrigger") > 0) {
			//Left Trigger Axis
			print("Left Trigger");
			leftTrigger = true;
		}
		else
		{
			leftTrigger = false;
		}
		if (Input.GetAxis("XboxRightTrigger") > 0)
		{
			//Right Trigger Axis
			print("Right Trigger");
			rightTrigger = true;
		}
		else
		{
			rightTrigger = false;
		}
		if (Input.GetAxis("LeftStickXAxis") > 0)
		{
			//Left Stick X Axis RIGHT
			print("LeftStickXRight");
			leftStickRight = true;
		}
		else
		{
			leftStickRight = false;
		}
		if (Input.GetAxis("LeftStickXAxis") < 0)
		{
			//Left Stick X Axis LEFT
			print("LeftStickXLeft");
			leftStickLeft = true;
		}
		else
		{
			leftStickLeft = false;
		}
		if (Input.GetAxis("LeftStickYAxis") > 0)
		{			
			//Left Stick Y Axis DOWN
			print("LeftStickYDown");
			leftStickDown = true;
		}
		else
		{
			leftStickDown = false;
		}
		if (Input.GetAxis("LeftStickYAxis") < 0)
		{			
			//Left Stick Y Axis UP
			print("LeftStickYUp");
			leftStickUp = true;
		}
		else
		{
			leftStickUp = false;
		}
		if (Input.GetAxis("RightStickXAxis") > 0)
		{			
			//Right Stick X Axis RIGHT
			print("RightStickXRight");
			rightStickRight = true;
		}
		else
		{
			rightStickRight = false;
		}
		if (Input.GetAxis("RightStickXAxis") < 0)
		{			
			//Right Stick X Axis LEFT
			print("RightStickXLeft");
			rightStickLeft = true;
		}
		else
		{
			rightStickLeft = false;
		}
		if (Input.GetAxis("RightStickYAxis") > 0)
		{			
			//Right Stick Y Axis DOWN
			print("RightStickYDown");
			rightStickDown = true;
		}
		else
		{
			rightStickDown = false;
		}
		if (Input.GetAxis("RightStickYAxis") < 0)
		{			
			//Right Stick Y Axis UP
			print("RightStickYUp");
			rightStickUp = true;
		}
		else
		{
			rightStickUp = false;
		}
		if (Input.GetAxis("DPadXAxis") > 0)
		{			
			//DPad X Axis RIGHT
			print("DPad X Right");
			dPadRight = true;
		}
		else
		{
			dPadRight = false;
		}
		if (Input.GetAxis("DPadXAxis") < 0)
		{			
			//DPad X Axis LEFT
			print("DPad X Left");
			dPadLeft = true;
		}
		else
		{
			dPadLeft = false;
		}
		if (Input.GetAxis("DPadYAxis") > 0)
		{			
			//DPad Y Axis UP
			print("DPad Y Up");
			dPadUp = true;
		}
		else
		{
			dPadUp = false;
		}
		if (Input.GetAxis("DPadYAxis") < 0)
		{			
			//DPad Y Axis DOWN
			print("DPad Y Down");
			dPadDown = true;
		}
		else
		{
			dPadDown = false;
		}

		#endregion

	}
}

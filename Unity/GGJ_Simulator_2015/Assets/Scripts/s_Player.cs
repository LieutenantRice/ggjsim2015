using UnityEngine;
using System.Collections;

public class s_Player : MonoBehaviour 
{
	public float f_movementSpeed = 3.0f;
	public float f_mouseSensitivity = 3.0f;
	public float f_upDownRange = 30.0f;

	private float f_verticleRotation =0;

	// Use this for initialization
	void Start () 
	{
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Rotation
		float f_rotLeftRight = Input.GetAxis("Mouse X") * f_mouseSensitivity;
		transform.Rotate (0,f_rotLeftRight,0);

		f_verticleRotation -= Input.GetAxis ("Mouse Y") * f_mouseSensitivity;
		f_verticleRotation = Mathf.Clamp (f_verticleRotation, -f_upDownRange, f_upDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler (f_verticleRotation, 0, 0);

		//Movement
		float f_forwardSpeed = Input.GetAxis ("Vertical") * f_movementSpeed;
		float f_sideSpeed = Input.GetAxis ("Horizontal") * f_movementSpeed;

		//Character
		Vector3 v_speed = new Vector3 (f_sideSpeed, Physics.gravity.y, f_forwardSpeed);
		v_speed = transform.rotation * v_speed;

		CharacterController cc = GetComponent<CharacterController> ();

		cc.Move ( v_speed * Time.deltaTime );

	}
}

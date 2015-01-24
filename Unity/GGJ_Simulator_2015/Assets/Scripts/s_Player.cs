using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class s_Player : MonoBehaviour 
{
	public float f_movementSpeed = 3.0f;
	public float f_mouseSensitivity = 3.0f;
	public float f_upDownRange = 30.0f;
    public float f_runSlow = 1.0f;
    public float f_runMax = 3.0f;
    public float f_runMultiplier;
    public float f_velocity = 0.0f;

	private float f_verticleRotation = 0;
    private CharacterController characterController;
    private s_Camera s_cam ;

	// Use this for initialization
	void Start () 
	{
        Screen.lockCursor = true;
        s_cam = Camera.main.GetComponent<s_Camera>();
        characterController = GetComponent<CharacterController>();
        f_runMultiplier = f_runSlow;
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
        if ( Input.GetKey(KeyCode.LeftShift) )
        {
            if (f_runMultiplier != f_runMax)
            {
                f_runMultiplier = f_runMax;
                s_cam.Run(true);
            }
        }
        else if (f_runMultiplier != f_runSlow) 
        {
            f_runMultiplier = f_runSlow;
            s_cam.Run(false);
        }
		float f_forwardSpeed = Input.GetAxis ("Vertical") * f_movementSpeed * f_runMultiplier;
        float f_sideSpeed = Input.GetAxis("Horizontal") * f_movementSpeed * f_runMultiplier;

		//Character
		Vector3 v_speed = new Vector3 (f_sideSpeed, Physics.gravity.y, f_forwardSpeed);
        
		v_speed = transform.rotation * v_speed;

		

		characterController.Move ( v_speed * Time.deltaTime );
        v_speed.y = 0;
        f_velocity = v_speed.magnitude;

	}
}

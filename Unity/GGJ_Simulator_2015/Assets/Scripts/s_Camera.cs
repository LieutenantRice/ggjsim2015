using UnityEngine;
using System.Collections;

public class s_Camera : MonoBehaviour 
{
    public float f_fov_max = 120.0f;
    public float f_fov_min = 60.0f;

    private bool b_goFOVbananaz = false;
    private bool b_running = false;
    private GameObject hPlayer;

	// Use this for initialization
	void Start () 
    {
        hPlayer = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (b_goFOVbananaz)
        {
            float dt = Time.deltaTime;
            float fov = camera.fieldOfView;
            int i_dt_fov = 0;
            if (b_running && transform.parent.gameObject.GetComponent<s_Player>().f_velocity > 0)
            {
                if (fov < f_fov_max)
                {
                    i_dt_fov = 30;
                }
            }
            else
            {
                if (fov > f_fov_min)
                {
                    i_dt_fov = -60;
                }
                else
                {
                    b_goFOVbananaz = false;
                }
            }
            camera.fieldOfView += i_dt_fov * dt;
            Debug.Log(camera.fieldOfView + "");  
        }
	}

    public void Run(bool b_run)
    {
        float fov = camera.fieldOfView ;
        if (b_run)
        {
            b_goFOVbananaz = true;
            b_running = true;
        }
        else
        {
            b_running = false;
        }
        

    }
}

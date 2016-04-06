using UnityEngine;
using System.Collections;

public class DashAbility : MonoBehaviour {


    public Rigidbody2D DashBody; 
    public float DashTimer;
    public Vector3 DashDir;

	// Use this for initialization
	void Start ()
    {
        DashTimer = 0f;
        DashBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && DashTimer <= 0)
        {
            DashDir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += DashDir;
           
        }
	}
}

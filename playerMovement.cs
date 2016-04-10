using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{


    public float moveupdown;
    public float moveleftright;
    public float moveSpeed = 0.1f;
    public float amount = 0;
    public Color A = Color.blue;
    public Color B = Color.red;
    public GameObject Obj;
    public Collision2D Col;
	public Animator Anim;
	private bool PlayingAni;
	private float yposition;
	private bool falling;
	private float ypospre;

    // Use this for initialization
    void Start()
    {
        Col = Obj.GetComponent<Collision2D>();
		Anim = Obj.GetComponent<Animator>();
		PlayingAni = false;
		falling = false;
    }

    // Update is called once per frame
    void Update()
    {
		ypospre = transform.position.y;
        moveupdown = Input.GetAxis("Vertical");
        moveleftright = Input.GetAxis("Horizontal");
        transform.Translate(moveSpeed * moveleftright, 0, 0);

		if (yposition >= ypospre+0.1f) 
		{
			Anim.Play ("SplatAni", -1, 0f);
			falling = true;
		}
		if (falling == false) {
			if (moveleftright >= 0.1f) {	
				if (PlayingAni == false) {
					Anim.Play ("Moving", -1, 0f);
					PlayingAni = true;
				}
			}
			if (moveleftright <= -0.1f) {
				if (PlayingAni == false) {
					Anim.Play ("MovingL", -1, 0f);
					PlayingAni = true;
				}
			}
			if (moveleftright == 0 && yposition <= transform.position.y) {
				PlayingAni = false;
				Anim.Play ("Stand", -1, 0f);
			}
		}
		yposition = ypospre;
		falling = false;

    }

  /*  void OnCollisionEnter2D(Collision2D other)
    {
        if (Col == other)
        {
            other.gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(A, B, 0);
        }
    }
    */
}
using UnityEngine;
using System.Collections;

public class detection : MonoBehaviour {

    public bool doneOnce = false;
    public GameObject Obj;
    public GameObject playerObj;
    public GameObject WallObj;
    public Color A = Color.blue;
    public Color B = Color.red;

        // These two are linked in proportionality, so healthChange should always be 100*sizeChange 
    public int healthChange = 10; // Change Health Change per tile 
    public float sizeChange = 0.1f; // Change Scale X Y of Player Object
    public float playerScale;
	// Use this for initialization

  
    


	void Start ()
    {
        playerObj = GameObject.Find("WhiteBox"); // WhiteBox = Name of Player Object
        WallObj = GameObject.Find("FloorPrefab");
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (!doneOnce)
        {
            playerScale = playerObj.transform.localScale.x;
            playerScale -= sizeChange;
            playerObj.GetComponent<Actions>().health -= healthChange;
            playerObj.transform.localScale = new Vector2(playerScale, playerScale);
            doneOnce = true;
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(A, B, 0);
         
          //   Instantiate(Obj, transform.position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update () {
	
	}
}

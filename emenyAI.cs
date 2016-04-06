using UnityEngine;
using System.Collections;

public class emenyAI : MonoBehaviour {

    public Transform target;
    private float Range;
    public float Speed = 1f;
    private Vector2 spawnPos;
//    public Transform[] patrol;
//    private int Currentpoint;


    // Use this for initialization
    void Start(){
        target = GameObject.Find("player").transform;
//        transform.position = patrol[0].position;
//        Currentpoint = 0;
        spawnPos = new Vector2(transform.position.x,transform.position.y);

    }

    // Update is called once per frame
    void Update(){
        Range = Vector2.Distance(transform.position, target.transform.position);

        if (Range <= 5f && Input.GetKey("m")){
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Speed * Time.deltaTime);
        }
//        else{
//            if (Vector2.Distance(transform.position, patrol[Currentpoint].position) < 0.5f){
//                Currentpoint ++;
//            }
//            if (Currentpoint >= patrol.Length){
//                Currentpoint = 0;
//            }
//            transform.position = Vector2.MoveTowards(transform.position, patrol[Currentpoint].position, Speed * Time.deltaTime);
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, spawnPos, Speed * Time.deltaTime);
        }
        }
//        }
    }
}

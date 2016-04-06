using UnityEngine;
using System.Collections;


public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Camera maincamera;
    private Vector3 offset;
    private bool playerpos;
    void Start()
    {
        maincamera = GetComponent<Camera>();
        offset = transform.position - player.transform.position;
        playerpos = true;
    }
    void Update()
    {
        Vector3 viewPos = maincamera.WorldToViewportPoint(player.transform.position);
        if (viewPos.x < 0.2f || viewPos.x > 0.8f || viewPos.y < 0.2f || viewPos.y > 0.8f)
        {
            if (playerpos)
            {
                Resetoffset();
            }
            Camerafollow();
        }
        else
        {
            playerpos = true;
        }
    }
    void Resetoffset()
    {
        offset = transform.position - player.transform.position;
        playerpos = false;
    }
    void Camerafollow()
    {
        transform.position = player.transform.position + offset;
    }
}

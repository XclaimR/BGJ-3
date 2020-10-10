using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHMovement : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(player.transform.position.x,player.transform.position.y - transform.position.y/5);
    }
}

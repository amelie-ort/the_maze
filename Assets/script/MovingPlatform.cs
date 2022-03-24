using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    public Player player = null;

    Vector3 nextPos ;

    void Start(){
        nextPos = startPos.position; 
    }

    void Update(){
        
        if(transform.position == pos1.position){
            nextPos = pos2.position;
        }
        if(transform.position == pos2.position){
            nextPos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        if(transform.position.y + 1.5f > player.transform.position.y && player.transform.position.y > transform.position.y){
            if(transform.position.x - 1f > player.transform.position.x && player.transform.position.x > transform.position.x + 1f)
                Debug.LogWarning("Player "+ transform.position);
                player.transform.position = Vector3.MoveTowards(player.transform.position, nextPos, speed * Time.deltaTime);
        }

    }

    // private void OnTriggerStay2D(){
    //     Debug.LogWarning("dezijdjiez "+ transform.position);
    //     player.transform.position = Vector3.MoveTowards(player.transform.position, nextPos, speed * Time.deltaTime);
    // }

    private void OnDrawGizmos(){
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}

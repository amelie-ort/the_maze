using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustDoor : MonoBehaviour
{
    public Player player = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(){
        player.Victory() ;
    }
}

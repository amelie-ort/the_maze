using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Vector3 spawnPosition = new Vector3();
    // Start is called before the first frame update
    public PlayerAnimationsController PlayerAnimationsController = null ;
    // public FollowPosition cameraFollowPosition = null ;
    public GameObject dust = null ; 
    public Rigidbody2D rb = null ; 
    public GameObject deathScreen = null; 
    public GameObject VictoryScreen = null; 
    public int gemmes = 0 ;
    public GameObject player = null ; 

    void Start()
    {
        this.spawnPosition = this.PlayerAnimationsController.transform.position;
        this.deathScreen.SetActive(false);
        this.dust.SetActive(false);

    }

    public void Die(){
        // Debug.LogWarning("Player "+ this.gameObject.name + " is now dead");
        this.deathScreen.SetActive(true);
        this.PlayerAnimationsController.Die();
        // this.cameraFollowPosition.enabled = false ;

    }

    public void Victory(){
        this.player.SetActive(false);
        this.rb.bodyType = RigidbodyType2D.Static ; 
        // Debug.LogWarning("Player "+ this.gameObject.name + " is now dead");
        this.VictoryScreen.SetActive(true);
        
        // this.PlayerAnimationsController.Die();
        // this.cameraFollowPosition.enabled = false ;

    }

    public void ReSpawn(){
        this.player.SetActive(true);
        this.rb.bodyType = RigidbodyType2D.Dynamic ; 


        this.deathScreen.SetActive(false);
        this.VictoryScreen.SetActive(false);

        this.PlayerAnimationsController.Restart_two();
        // this.PlayerAnimationsController.Rigidbody2D.velocity = Vector3.zero;
        this.PlayerAnimationsController.transform.position = this.spawnPosition;
        this.PlayerAnimationsController.enabled = true ;

    }

    public void Update(){
        if(gemmes == 5 ){
            this.dust.SetActive(true);
        }
    }
    


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gemmes : MonoBehaviour

{
    public GameObject gemme = null;
    public GameObject inventory = null;
    public Player player = null;

    // Start is called before the first frame update
    void Start()
    {
        gemme.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(){
        Debug.LogWarning(inventory.GetComponent<Text>().text);
        gemme.SetActive(false);
        player.gemmes = player.gemmes + 1 ;
        // int tmp = int.Parse(inventory.GetComponent<Text>().text) + 1;
        inventory.GetComponent<Text>().text = player.gemmes.ToString() ;
    }
}

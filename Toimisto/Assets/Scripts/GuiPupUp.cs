using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiPupUp : MonoBehaviour
{
    public Collider hitbox;
    public GameObject TargetBox; 
    public bool IsColliding;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter(Collider collision)
       {
            if(collision.gameObject.tag == "Player")
            {
            TargetBox.SetActive(true);
            IsColliding = true;
            }
       } 
    public void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
        TargetBox.SetActive(false);
        IsColliding = false;
        }
    }
}

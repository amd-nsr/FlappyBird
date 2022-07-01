using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

    public float upForce = 200f;                   //Upward force of the "flap".
    private bool isDead = false;            //Has the player collided with a wall?
    private Rigidbody2D rb2d;               //Holds a reference to the Rigidbody2Dcomponentofthebird.
    private Animator anim;  
	// Use this for initialization
	void Start () {
    anim = GetComponent<Animator> ();
    rb2d = GetComponent<Rigidbody2D>();}
	
	void Update () {
        if (isDead == false) {
            if (Input.GetKeyDown("space")){
                rb2d.velocity = Vector2.zero;
                if(transform.position.y < 4.3 && GameControl.instance.paused == false ){
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
                                            }
            }
        }
	}
    
     void OnCollisionEnter2D(){
         rb2d.velocity = Vector2.zero;
        isDead = true;   
        anim.SetTrigger ("Die");
         GameControl.instance.BirdDied ();
    }
}

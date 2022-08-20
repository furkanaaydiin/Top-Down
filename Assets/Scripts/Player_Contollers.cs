using UnityEngine;



public class Player_Contollers : MonoBehaviour
{
    [Header("component")]
    public Rigidbody2D rb;
    public Animator animator;

    [Header("gameplay")]
    public float speed;
    private Vector2 movoment;  

    
     void Update()
    {
        movoment.x = Input.GetAxis("Horizontal");
        movoment.y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(
            movoment.x * speed,
            movoment.y * speed
        );
        RunAnim();

    }

    private void RunAnim()
    {
        if(movoment.x != 0 || movoment.y != 0)
        {
            animator.SetBool("isRunning" , true);
        }
        else
        {
             animator.SetBool("isRunning" , false);
        }
    }
     

    
    
   
}

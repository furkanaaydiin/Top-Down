using UnityEngine;


public class Anami_Controllers : MonoBehaviour
{
    private Transform playerPos;
    public float speed;
    private int head = 3;

 
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            playerPos.position,
            speed * Time.deltaTime
        );
        if(head <=0)
        {
            Destroy(gameObject);
        }

        
    }
    
      
    

    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "bullet")
        {
             head--;
        }
        
    }
    
}

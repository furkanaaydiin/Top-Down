using UnityEngine;



public class Bullet_Controllers : MonoBehaviour
{

    private Vector2 targer;
    public float speed;
    

    

    
    void Start()
    {
        targer =Camera.main.ScreenToWorldPoint(Input.mousePosition);    
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            targer,
            speed* Time.deltaTime
        );
        Destroy(gameObject,2f); 
    }



    
    
}

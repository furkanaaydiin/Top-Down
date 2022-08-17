using UnityEngine;

public class Gun : MonoBehaviour
{
    
    private Vector3 mousePos;
    public GameObject Cross;

    public GameObject bullent;

    

    
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            transform.position.z
        ));

        Cross.transform.position = new Vector3(mousePos.x,mousePos.y,transform.position.z);

        if(Input.GetMouseButtonDown(0))
        {
            Short();
        }
        
        Vector3 turgerDirections = mousePos  - transform.position;
        float rotateZ = Mathf.Atan2(turgerDirections.y,turgerDirections.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f,0f,rotateZ);
    }

        private void Short()
        {
           Instantiate(bullent , transform.position , Quaternion.identity);
        }




    
}

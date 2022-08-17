
using UnityEngine;

public class Spawner_Controllers : MonoBehaviour
{
    
    public GameObject enemiPrefab;
    public Transform[] spwanPoint;
    public float inverval;
    void Start()
    {
        InvokeRepeating("spawn",0.5f,inverval);
    }

    


    private void spawn()
    {
        int randPos = Random.Range(0,spwanPoint.Length);
        GameObject newenemi = Instantiate(enemiPrefab,spwanPoint[randPos].position,Quaternion.identity);
    }

    
}

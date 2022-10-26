using System;
using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    [SerializeField] private Text skor;
    private int skorCount = 0;
    private void Start()
    {
        StaticEvents.OnEnemyKill += OnEnemyKill;
    }

    private void OnEnemyKill()
    {
        skorCount++;
        skor.text = skorCount.ToString();
    } 
    
}

public static class StaticEvents
{
    public static Action OnEnemyKill;
}

        

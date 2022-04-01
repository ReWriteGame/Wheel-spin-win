using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRule : MonoBehaviour
{
    [SerializeField] private Cube hero;
    [SerializeField] private Cube game;

    public UnityEvent heroWinEvent;
    public UnityEvent enemyWinEvent;
    public UnityEvent drawEvent;

    public void checkResult()
    {
    
        if (game.CurrentEdge.GetComponent<Edge>().EdgeNum == hero.CurrentEdge.GetComponent<Edge>().EdgeNum)
            heroWinEvent?.Invoke();
        else enemyWinEvent?.Invoke();
    }

}

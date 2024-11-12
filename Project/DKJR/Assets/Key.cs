using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Subject
{
    public WinDisplay _Win;
   
    private void OnEnable()
    {
        if (_Win)
            Attach(_Win);
    }

    private void OnDisable()
    {
        if (_Win)
            Detach(_Win);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        NotifyObservers();
    }
}

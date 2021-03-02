using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEventDemo : MonoBehaviour
{
    [SerializeField] private UnityEvent animTriggeredEvent;
    
    public void TriggerUnityEvent()
    {
        animTriggeredEvent.Invoke();
    }
}

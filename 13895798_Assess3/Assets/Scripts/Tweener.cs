using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    //private Tween activeTween;
    private List<Tween> activeTweens = new List<Tween>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < activeTweens.Count; i++)
        {
            if (Vector3.Distance(activeTweens[i].Target.position, activeTweens[i].EndPos) > 0.00001f)
            {
                float LinearFraction =((Time.time - activeTweens[i].StartTime) / activeTweens[i].Duration);

                activeTweens[i].Target.position = Vector3.Lerp(activeTweens[i].StartPos, activeTweens[i].EndPos, LinearFraction);
            }
            else
            {
                activeTweens[i].Target.position = activeTweens[i].EndPos;
                activeTweens.Remove(activeTweens[i]);
            }
        }
    }

    public bool AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (TweenExists(targetObject))
        {
            return false;
        }
        else
        {
            activeTweens.Add(new Tween(targetObject, startPos, endPos, Time.time, duration));
            return true;
        }
    }

    public bool TweenExists(Transform target)
    {

        for (int i = 0; i < activeTweens.Count; i++)
        {
            if (activeTweens[i].Target == target)
            {
                return true;
            }
        }
        return false;

    }
}

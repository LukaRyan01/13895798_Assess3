using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public KeyCode lastInput;
    [SerializeField]
    private GameObject kirby;
    private Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            lastInput = KeyCode.W;
        }
        if (Input.GetKeyDown("a"))
        {
            lastInput = KeyCode.A;
        }
        if (Input.GetKeyDown("s"))
        {
            lastInput = KeyCode.S;
        }
        if (Input.GetKeyDown("d"))
        {
            lastInput = KeyCode.D;
        }
        if (!(tweener.TweenExists(kirby.transform)))
        {
            if (lastInput == KeyCode.W)
            {
                tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(0.0f, 1.0f, 0.0f)), 1.0f);
            }
            if (lastInput == KeyCode.A)
            {
                tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(-1.0f, 0.0f, 0.0f)), 1.0f);
            }
            if (lastInput == KeyCode.S)
            {
                tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(0.0f, -1.0f, 0.0f)), 1.0f);
            }
            if (lastInput == KeyCode.D)
            {
                tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(1.0f, 0.0f, 0.0f)), 1.0f);
            }
        }

    }
}

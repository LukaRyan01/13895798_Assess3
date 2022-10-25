using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class TweenManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private Tweener tweener;
    public Animator animatorController;
    AudioSource movementAudio;
    public float movementDuration;
    private Vector3 posTR;
    private Vector3 posTL;
    private Vector3 posBL;
    private Vector3 posBR;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        movementAudio = GetComponent<AudioSource>();
        posTR = new Vector3 (-5.5f, 13.5f, 0.0f);
        posTL = new Vector3(-9.5f, 13.5f, 0.0f);
        posBL = new Vector3(-9.5f, 9.5f, 0.0f);
        posBR = new Vector3(-5.5f, 9.5f, 0.0f);
        StartCoroutine(Loop(movementDuration));

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Loop(float waitTIme)
    {
        while (true)
        {
            // add bottom right animation and sound
            tweener.AddTween(player.transform, player.transform.position, posBR, movementDuration);
            movementAudio.Play();
            yield return new WaitForSeconds(waitTIme);
            movementAudio.Stop();
            // add bottom left animation and sound 
            animatorController.SetTrigger("LeftParam");
            tweener.AddTween(player.transform, player.transform.position, posBL, movementDuration);
            movementAudio.Play();
            yield return new WaitForSeconds(waitTIme);
            movementAudio.Stop();

            // add top left animation and sound 
            animatorController.SetTrigger("UpParam");
            tweener.AddTween(player.transform, player.transform.position, posTL, movementDuration);
            movementAudio.Play();
            yield return new WaitForSeconds(waitTIme);
            movementAudio.Stop();

            // add top right animation and sound 
            animatorController.SetTrigger("RightParam");
            tweener.AddTween(player.transform, player.transform.position, posTR, movementDuration);
            movementAudio.Play();
            yield return new WaitForSeconds(waitTIme);
            movementAudio.Stop();

            // set sprite position to down
            animatorController.SetTrigger("DownParam");

        }
    }
    
}

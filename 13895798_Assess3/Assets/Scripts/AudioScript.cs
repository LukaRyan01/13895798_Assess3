using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioScript : MonoBehaviour
{
    public AudioClip introMusic;
    public AudioClip normalMusic;
    public AudioClip walkingSound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playIntroMusic());
    }
    // Play intro music until complete then loop normal music
    IEnumerator playIntroMusic()
    {
        /*
         * GetComponent<AudioSource>().clip = introMusic;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(introMusic.length);
        */
        GetComponent<AudioSource>().clip = normalMusic;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
        yield return new WaitForSeconds(1);
    }

    public void playWalkingSound()
    {
        GetComponent<AudioSource>().clip = walkingSound;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
    }



}

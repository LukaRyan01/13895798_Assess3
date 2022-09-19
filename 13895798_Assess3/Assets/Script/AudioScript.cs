using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioScript : MonoBehaviour
{
    public AudioClip introMusic;
    public AudioClip normalMusic;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playIntroMusic());
    }
    // Play intro music until complete then loop normal music
    IEnumerator playIntroMusic()
    {
        GetComponent<AudioSource>().clip = introMusic;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(introMusic.length);
        GetComponent<AudioSource>().clip = normalMusic;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    public Camera Camera;
    private float cameraWidth;
    private float cameraHeight;
    public int spawnFrequency;
    private Tweener tweener;
    [SerializeField]
    private GameObject Cherry;
    private GameObject MovingCherry;
    private float startLocation;
    // Start is called before the first frame update
    void Awake()
    {
        tweener = GetComponent<Tweener>();
        cameraHeight = Camera.orthographicSize * 2;
        cameraWidth = cameraHeight * Screen.width / Screen.height;
        StartCoroutine(Loop(spawnFrequency));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Loop(int delay)
    {
        while (true)
        {
            startLocation = Random.Range(-cameraHeight / 2, cameraHeight / 2);
            MovingCherry = Instantiate(Cherry, new Vector3(-cameraWidth / 2 + 1, startLocation + 0.5f, 0), Quaternion.Euler(0, 0, 0));
            tweener.AddTween(MovingCherry.transform, MovingCherry.transform.position, new Vector3(cameraWidth/2 + 2, -startLocation + 0.5f, 0), delay/2);
            yield return new WaitForSeconds(delay/2);
            MovingCherry.SetActive(false);
            yield return new WaitForSeconds(delay/2);
            
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PacStudentController : MonoBehaviour
{
    public KeyCode lastInput;
    [SerializeField]
    private GameObject kirby;
    private Tweener tweener;
    private Vector3 KirbyNewPos;
    public Tilemap TileMap;
    public Animator AnimationController;
    public AudioSource walkingSound;
    public AudioSource eatingSound;

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
            walkingSound.Stop();
            eatingSound.Stop();
            kirby.GetComponentInChildren<ParticleSystem>().Stop();

            if (lastInput == KeyCode.W)
            {
                KirbyNewPos = kirby.transform.position + new Vector3(0.0f, 1.0f, 0.0f);
                if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))) == null)
                {
                    kirby.GetComponentInChildren<ParticleSystem>().Play();
                    AnimationController.SetTrigger("UpParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                    walkingSound.Play();
                }
                else if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))).name == "Normal Pellet Simple Tile")
                {
                    kirby.GetComponentInChildren<ParticleSystem>().Play();
                    AnimationController.SetTrigger("UpParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                    eatingSound.Play();
                }
            }
            if (lastInput == KeyCode.A)
            {
                KirbyNewPos = kirby.transform.position + new Vector3(-1.0f, 0.0f, 0.0f);
                if (KirbyNewPos == new Vector3(-11.5f, 0.5f, 0.0f))
                {
                    kirby.transform.position = new Vector3(14.5f, 0.5f, 0.0f);
                }
                else if (KirbyNewPos == new Vector3(15.5f, 0.5f, 0.0f))
                {
                    kirby.transform.position = new Vector3(-11.5f, 0.5f, 0.0f);
                }
                else
                {
                    if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))) == null)
                    {
                        AnimationController.SetTrigger("LeftParam");
                        tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                        walkingSound.Play();
                        kirby.GetComponentInChildren<ParticleSystem>().Play();
                    }
                    else if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))).name == "Normal Pellet Simple Tile")
                    {
                        AnimationController.SetTrigger("LeftParam");
                        tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(-1.0f, 0.0f, 0.0f)), 1.0f);
                        eatingSound.Play();
                        kirby.GetComponentInChildren<ParticleSystem>().Play();
                    }
                }
            }
            if (lastInput == KeyCode.S)
            {
                AnimationController.SetTrigger("DownParam");
                KirbyNewPos = kirby.transform.position + new Vector3(0.0f, -1.0f, 0.0f);
                if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))) == null)
                {
                    tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                    walkingSound.Play();
                    kirby.GetComponentInChildren<ParticleSystem>().Play();
                }
                else if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))).name == "Normal Pellet Simple Tile")
                {
                    tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(0.0f, -1.0f, 0.0f)), 1.0f);
                    eatingSound.Play();
                    kirby.GetComponentInChildren<ParticleSystem>().Play();
                }
            }
            if (lastInput == KeyCode.D)
            {
                KirbyNewPos = kirby.transform.position + new Vector3(1.0f, 0.0f, 0.0f);
                if (KirbyNewPos == new Vector3(-11.5f, 0.5f, 0.0f))
                {
                    kirby.transform.position = new Vector3(14.5f, 0.5f, 0.0f);
                }
                else if (KirbyNewPos == new Vector3(15.5f, 0.5f, 0.0f)) {                 
                    kirby.transform.position = new Vector3(-11.5f, 0.5f, 0.0f);
                }   
                else
                {
                    if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))) == null)
                    {
                        AnimationController.SetTrigger("RightParam");
                        tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                        walkingSound.Play();
                        kirby.GetComponentInChildren<ParticleSystem>().Play();
                    }
                    else if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))).name == "Normal Pellet Simple Tile")
                    {
                        AnimationController.SetTrigger("RightParam");
                        tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(1.0f, 0.0f, 0.0f)), 1.0f);
                        eatingSound.Play();
                        kirby.GetComponentInChildren<ParticleSystem>().Play();
                    }
                }
            }
        }

    }
}

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
                KirbyNewPos = kirby.transform.position + new Vector3(0.0f, 1.0f, 0.0f);
                if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))) == null)
                {
                    AnimationController.SetTrigger("UpParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                }
                else if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))).name == "Normal Pellet Simple Tile")
                {
                    AnimationController.SetTrigger("UpParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                }
            }
            if (lastInput == KeyCode.A)
            {
                KirbyNewPos = kirby.transform.position + new Vector3(-1.0f, 0.0f, 0.0f);
                if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))) == null)
                {
                    AnimationController.SetTrigger("LeftParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                }
                else if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))).name == "Normal Pellet Simple Tile" )
                {
                    AnimationController.SetTrigger("LeftParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(-1.0f, 0.0f, 0.0f)), 1.0f);
               }
            }
            if (lastInput == KeyCode.S)
            {

                KirbyNewPos = kirby.transform.position + new Vector3(0.0f, -1.0f, 0.0f);
                if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))) == null)
                {
                    AnimationController.SetTrigger("DownParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                }
                else if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))).name == "Normal Pellet Simple Tile")
                {
                    AnimationController.SetTrigger("DownParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(0.0f, -1.0f, 0.0f)), 1.0f);
                }
            }
            if (lastInput == KeyCode.D)
            {
                KirbyNewPos = kirby.transform.position + new Vector3(1.0f, 0.0f, 0.0f);
                if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))) == null)
                {
                    AnimationController.SetTrigger("RightParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, KirbyNewPos, 1.0f);
                }
                else if (TileMap.GetTile(Vector3Int.FloorToInt(KirbyNewPos + new Vector3(-4.5f, -1.5f, 0.0f))).name == "Normal Pellet Simple Tile")
                {
                    AnimationController.SetTrigger("RightParam");
                    tweener.AddTween(kirby.transform, kirby.transform.position, (kirby.transform.position + new Vector3(1.0f, 0.0f, 0.0f)), 1.0f);
                }
            }
        }

    }
}

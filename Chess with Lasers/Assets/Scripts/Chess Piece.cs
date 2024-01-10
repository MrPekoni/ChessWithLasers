using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
    Vector2 Pos;
    public int Team;
    public Vector2 Position;
    // Start is called before the first frame update
    void Start()
    {
        Position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.z);
        if (gameObject.name.StartsWith("W"))
        {
            Team = 1;
        }
        else
        {
            Team = 2;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

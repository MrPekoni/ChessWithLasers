using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
    Chess chess;
    Vector2 Pos;
    // Start is called before the first frame update
    void Start()
    {
        Pos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.z);
        //chess.ChessBoard
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

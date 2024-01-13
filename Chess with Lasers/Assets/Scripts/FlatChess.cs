using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FlatChess : MonoBehaviour
{
    public GameObject OccupyingPiece, GameController;
    ChessLogic chessLogic;
    private int Childcount;
    void Start()
    {
        Childcount = gameObject.transform.childCount;
        if (Childcount > 0)
        {
            OccupyingPiece = gameObject.transform.GetChild(0).gameObject;
        }

        GameController = GameObject.Find("GameController");
        chessLogic = GameController.GetComponent<ChessLogic>();
    }
    public void OnClick()
    {
        
        Childcount = gameObject.transform.childCount; // Get the amount of children objects

        if (Childcount > 0) // Checks if there is a child aka chesspiece
        {
            OccupyingPiece = gameObject.transform.GetChild(0).gameObject; // Set the occupying piece as the child of this object
            chessLogic.LastSelectedPiece = OccupyingPiece; // Updates the last piece that was selected
            chessLogic.StartTileSelected = true;
            //Debug.Log("Selected Tile: " + gameObject.name + "   Selected Piece: " + OccupyingPiece.name);
        }
        else // if no child is present, set it to null
        {
            OccupyingPiece = null;
            chessLogic.SelectedPiece= null;
            //Debug.Log("Selected Tile: " + gameObject.name);
        }


        if (chessLogic.StartTileSelected) // If a tile containing a chesspiece is present
        {
            chessLogic.DestinationTile = gameObject; // Sets the tile the chesspiece will go to
            chessLogic.MovePiece(); // Attempt to move LastSelectedPiece to DestinationTile
        }
        else
        {
            chessLogic.SelectedTile = gameObject;
            chessLogic.SelectedPiece = OccupyingPiece;
        }
        

    }
}

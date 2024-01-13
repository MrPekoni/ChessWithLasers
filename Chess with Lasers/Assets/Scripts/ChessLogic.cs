using UnityEngine;


public class ChessLogic : MonoBehaviour
{
    public GameObject SelectedTile, SelectedPiece, DestinationTile, LastSelectedPiece;
    public bool StartTileSelected;
    public void MovePiece()
    {
        
        if (SelectedPiece == null && StartTileSelected && SelectedTile != DestinationTile) 
        {
            Debug.Log("A Piece should have moved");
            LastSelectedPiece.transform.SetParent(SelectedTile.transform, false);
            StartTileSelected = false;
        }
        else
        {
            Debug.LogError("Failed to move piece!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }
}
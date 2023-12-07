using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChessLogic : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if ("Game Piece" == GetClickedObject(out RaycastHit hit))
            {
                if (hit.collider.gameObject.CompareTag("Game Piece"))
                {
                    Debug.Log("CHESS GAMING");
                }
                if (hit.collider.gameObject.CompareTag("Tile"))
                {
                    Debug.Log("TILE GAMING");
                }
                if (hit.collider.gameObject.CompareTag("Tile"))
                print("clicked/touched!");
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("Mouse is off!");
        }
    }

    string GetClickedObject(out RaycastHit hit)
    {
        string target = null;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            if (!isPointerOverUIObject()) { target = hit.collider.gameObject.tag; }
        }
        return target;
    }
    private bool isPointerOverUIObject()
    {
        PointerEventData ped = new PointerEventData(EventSystem.current);
        ped.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(ped, results);
        return results.Count > 0;
    }
}
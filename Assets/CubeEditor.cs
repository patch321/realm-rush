using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(Waypoint))]
public class CubeEditor : MonoBehaviour
{
    Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        SnapToGrid();
        UpdateLabel();
    }

    private void UpdateLabel()
    {
        Vector2Int gridPos = waypoint.GetGridPos();
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        var labelText = gridPos.x + "," + gridPos.y;
        textMesh.text = labelText;
        gameObject.name = "Cube " + labelText;
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        transform.position = new Vector3(waypoint.GetGridPos().x * gridSize, 0, waypoint.GetGridPos().y * gridSize);
    }
}

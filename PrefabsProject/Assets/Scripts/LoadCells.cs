using UnityEngine;
using System.Collections;

public class LoadCells : MonoBehaviour {

    private GameObject[,] cells = new GameObject[8,8];

    void Start () {

        string[] names = { "Circle", "Triangle", "Heart", "Star" };

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                var cell = Instantiate(Resources.Load("Cell")) as GameObject;
                cell.transform.position = new Vector3(i - 3.5f, j - 3.5f);
                cell.name = "Cell";
                cells[i,j] = cell;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                var elem = Instantiate(Resources.Load(names[Random.Range(0, names.Length)])) as GameObject;
                elem.transform.parent = cells[i,j].transform;
                elem.transform.localPosition = new Vector3(0.0f, -0.05f);
            }
        }
    }
	
	void Update () {
	
	}
}

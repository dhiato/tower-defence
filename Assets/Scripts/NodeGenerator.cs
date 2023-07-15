using UnityEngine;

public class NodeGenerator : MonoBehaviour
{
    public NodePlacementArea placementArea;
    public GameObject nodePrefab;
    public float nodeSpacing = 1f;
    public int squareSize = 5;

    private void Start()
    {
        GenerateNodes();
    }

    private void GenerateNodes()
    {
        for (int x = 0; x < squareSize; x++)
        {
            for (int z = 0; z < squareSize; z++)
            {
                Vector3 spawnPosition = new Vector3(x * nodeSpacing, 0f, z * nodeSpacing);

                // Check if the spawn position is within the placement area
                if (placementArea.ContainsPoint(spawnPosition))
                {
                    GameObject nodeGO = Instantiate(nodePrefab, spawnPosition, Quaternion.identity);
                    // Add any additional node setup or customization here
                }
            }
        }
    }
}

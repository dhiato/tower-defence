using UnityEngine;

public class NodePlacementArea : MonoBehaviour
{
    public float areaWidth = 10f;
    public float areaLength = 10f;

    public bool ContainsPoint(Vector3 point)
    {
        Vector3 localPoint = transform.InverseTransformPoint(point);

        if (Mathf.Abs(localPoint.x) <= areaWidth / 2f && Mathf.Abs(localPoint.z) <= areaLength / 2f)
        {
            return true;
        }

        return false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Vector3 center = transform.position;
        Vector3 size = new Vector3(areaWidth, 0.1f, areaLength);
        Gizmos.DrawWireCube(center, size);
    }
}

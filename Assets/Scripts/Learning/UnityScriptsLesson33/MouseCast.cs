using UnityEngine;

public class MouseCast : MonoBehaviour
{
    private void Update()
    {
        RaycastHit hit;
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
                {
                    Debug.Log(hit.point);
                }
            }
        }
    }
}

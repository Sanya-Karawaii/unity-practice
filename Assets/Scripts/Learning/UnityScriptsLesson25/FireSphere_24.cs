
using UnityEngine;

public class FireSphere_24 : MonoBehaviour
{

    public void ChangeSize()
    {
        transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
    }

    public void AddForce()
    {
        GetComponent<Rigidbody>().AddForce(3, 5, 0, ForceMode.Impulse);
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}

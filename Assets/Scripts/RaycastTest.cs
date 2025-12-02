using UnityEngine;

public class RaycastTest : MonoBehaviour
{

    [SerializeField] LayerMask mask;

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 10, mask);
        if (hit)
        {
            print("hit " + hit.transform.name);
            if (hit.transform.CompareTag("Enemy"))
            {

            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, transform.up * 10);
    }

}

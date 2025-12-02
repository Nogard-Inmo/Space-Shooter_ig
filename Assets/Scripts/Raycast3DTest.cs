using UnityEngine;

public class Raycast3DTest : MonoBehaviour
{

    [SerializeField] LayerMask mask;

    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 10, mask);

        RaycastHit hit;


        if (Physics.Raycast(transform.position, transform.up, out hit, 10, mask))
        {
            print($"Hit {hit.transform.name}");
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    Ray RayOrigin;
    RaycastHit HitInfo;
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            RayOrigin = Camera.main.ViewportPointToRay(new Vector3(0, 0, 0));
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out HitInfo, 100.0f))
            {
                if (HitInfo.transform.gameObject.GetComponent<Door>())
                {
                    SceneManager.LoadScene(1);
                }


                Debug.DrawRay(RayOrigin.direction, HitInfo.point, Color.yellow);
            }
        }
    }
}  
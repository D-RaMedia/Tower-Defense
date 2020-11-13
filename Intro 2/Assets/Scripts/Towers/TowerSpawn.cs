using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    public GameObject tower1;
    public GameObject tower2;
    private bool select1;
    private bool select2;


    void Update()
    {
        #region Select Tower Type
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            select1 = true;
            select2 = false;
            Debug.Log("Standard Tower Selected");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            select1 = false;
            select2 = true;
            Debug.Log("Multitarget Tower Selected");

        }
        #endregion

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.green);

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 spawnpos = hit.point;
            spawnpos.y = 17f;
            #region Spawn Tower
            if (Input.GetKeyDown(KeyCode.Mouse0) == true)
            {
                if (hit.collider)
                {
                    if (hit.collider.tag == "placeable")
                    {
                        if (select1 == true)
                        {
                            Instantiate(tower1, spawnpos, Quaternion.identity);
                            Debug.Log("Placed Standard Tower at " + Input.mousePosition);
                        }

                        if (select2 == true)
                        {
                            Instantiate(tower2, spawnpos, Quaternion.identity);
                            Debug.Log("Placed Multitarget Tower at " + Input.mousePosition);
                        }
                    }
                }
            }
            #endregion

            #region Delete Tower
            if (Input.GetKeyDown(KeyCode.Mouse1) == true)
            {
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider)
                        {
                            if (hit.collider.tag == "PlayerTower")
                            {
                                Destroy(hit.collider.gameObject);
                                Debug.Log("Destroyed tower at " + Input.mousePosition);
                            }
                        }
                    }
                }
            }
            #endregion
        }
    }
}

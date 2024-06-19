using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolygonManager : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject cylinderPrefab;
    public GameObject tetrahedronPrefab;


    private Vector3 randomPosition()
    {
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(-2f, 2f);
        float z = Random.Range(-2f, 2f);

        return new Vector3(x, y, z);
    }

    public void createCube()
    {
        Vector3 randomPos = randomPosition();
        Instantiate(cubePrefab, randomPos, cubePrefab.transform.rotation);
    }

    public void createCylinder()
    {
        Vector3 randomPos = randomPosition();
        Instantiate(cylinderPrefab, randomPos, cylinderPrefab.transform.rotation);
    }

    public void createTetrahedron()
    {
        Vector3 randomPos = randomPosition();
        Instantiate(tetrahedronPrefab, randomPos, tetrahedronPrefab.transform.rotation);
    }


}

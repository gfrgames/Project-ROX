using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build_grid : MonoBehaviour
{
	public int width = 8, height = 10;
	public GameObject block;
	public float blockSize;
	public float xStart, yStart;
    // Start is called before the first frame update
    void Start()
    {
		for (int i = 0; i < width; ++i) {
			for (int j = 0; j < height; ++j) {
				Instantiate (block, new Vector3 (xStart + blockSize * i, yStart - j * blockSize), Quaternion.identity);
			}
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

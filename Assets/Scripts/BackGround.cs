using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackGround : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Material material;
    public float hiz;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.material;
    }

    private void Update()
    {
        Vector2 meshSet = material.mainTextureOffset;
        meshSet.y = -Time.time/10;
        //meshSet.x = Time.time/10;
        material.mainTextureOffset = meshSet;
    }
    public void StartBtn()
    {
        
        SceneManager.LoadScene(1);
    }
    public void ExitBtn()
    {
        Application.Quit();
    }
}

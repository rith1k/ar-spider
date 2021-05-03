using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texturechange : MonoBehaviour {

 public Material[] materials;
// Renderer rend;

  //   public Texture[] texture; //set in inspector
     public int currentTexture; //set default/starting index in inspector
     bool shouldChange = false; //this bool is set to prevent unwanted texture changes to the same texture every frame
    [SerializeField]
    private GameObject cube;

    // void Start(){
    //     rend= GetComponent<Renderer>();
    //     rend.enabled=true;
    //     rend.sharedMaterial= material[0];

    // }
    public void changetexture(int textureToSet)
    {
        currentTexture = textureToSet;
        shouldChange = true;
    }
    public void incrementtexture()
    {
        currentTexture++;
        shouldChange = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (shouldChange)
        {
            shouldChange = false; 
            GetComponent<Renderer>().material= materials[currentTexture]; //set new texture
        }
    }
}
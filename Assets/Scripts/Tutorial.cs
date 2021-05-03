using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial : MonoBehaviour
{   
    public GameObject basic1, basic2, basic3, basic4, basic5, basic6;

public void tutorial1(){
  basic1.SetActive(true);
  basic2.SetActive(false);
  basic3.SetActive(false);
  basic4.SetActive(false);
  basic5.SetActive(false);
  basic6.SetActive(false);
}   
public void tutorial2(){
  basic1.SetActive(false);
  basic2.SetActive(true);
  basic3.SetActive(false);
  basic4.SetActive(false);
  basic5.SetActive(false);
basic6.SetActive(false);

}  

public void tutorial3(){
  basic1.SetActive(false);
  basic2.SetActive(false);
  basic3.SetActive(true);
  basic4.SetActive(false);
  basic5.SetActive(false);
basic6.SetActive(false);

}  
public void tutorial4(){
  basic1.SetActive(false);
  basic2.SetActive(false);
  basic3.SetActive(false);
  basic4.SetActive(true);
  basic5.SetActive(false);
basic6.SetActive(false);

}  
public void tutorial5(){
  basic1.SetActive(false);
  basic2.SetActive(false);
  basic3.SetActive(false);
  basic4.SetActive(false);
  basic5.SetActive(true);
  basic6.SetActive(false);

}  
public void tutorial6(){
  basic1.SetActive(false);
  basic2.SetActive(false);
  basic3.SetActive(false);
  basic4.SetActive(false);
  basic5.SetActive(false);
  basic6.SetActive(true);

}  


}
    
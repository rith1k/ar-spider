using UnityEngine;
using System.Collections;
 
namespace Supyrb
{
    public class WebInterface : MonoBehaviour
    {
 
        public void OpenWebsite(string url)
        {
            Application.OpenURL(url);
        }
    }
}
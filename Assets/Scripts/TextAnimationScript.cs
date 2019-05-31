using System.Collections;
using UnityEngine;
using TMPro;

public class TextAnimationScript : MonoBehaviour
{
    private TextMeshPro textMesh;


    IEnumerator Start() {
        textMesh = gameObject.GetComponent<TextMeshPro>();
        int totalVisibleChar = textMesh.textInfo.characterCount;
        int counter=0;
        while(true){
            int visiblecount = counter%(totalVisibleChar+1);
            textMesh.maxVisibleCharacters = visiblecount;
            if(visiblecount>=totalVisibleChar){
                yield return new WaitForSeconds(10.0f);
            }
            counter+=1;
            yield return new WaitForSeconds(0.07f);
        }
    }
}

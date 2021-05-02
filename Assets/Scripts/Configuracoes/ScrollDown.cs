using UnityEngine;
using UnityEngine.UI;

public class ScrollDown : MonoBehaviour
{
    public ScrollRect scroll;
    public TMPro.TMP_Text message;

    private void Update()
    {
        if(scroll.verticalNormalizedPosition > 0.06f)
        {
            message.enabled = true;
            //Debug.Log(scroll.verticalNormalizedPosition);
        }
        else
        {
            message.enabled = false;
        }
    }
}

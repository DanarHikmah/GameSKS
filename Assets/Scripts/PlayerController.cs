using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public node rightNow = null;
    public string arah = "bottom";
    bool selectDirection = false;

    void Start () {
        StartCoroutine(Move(3));
	}

    private void Update()
    {
        
    }

    void Gerak(node next)
    {
        transform.position = next.transform.position;
    }

    void WaitUntilChooseDirection()
    {
        Debug.Log("waitiinggg");
        selectDirection = true;
    }

    IEnumerator Move(int jmlDadu)
    {
        for (int i = 0; i < jmlDadu; i++)
        {
            if (!selectDirection)
            {
                switch (arah)
                {
                    case "bottom":
                        if (rightNow.bottom != null)
                        {
                            Gerak(rightNow.bottom);
                            rightNow = rightNow.bottom;
                        }
                        else
                        {
                            WaitUntilChooseDirection();
                        }
                        break;
                    case "top":
                        if (rightNow.top != null)
                        {
                            Gerak(rightNow.top);
                            rightNow = rightNow.top;
                        }
                        else
                        {
                            WaitUntilChooseDirection();
                        }
                        break;
                    case "right":
                        if (rightNow.right != null)
                        {
                            Gerak(rightNow.right);
                            rightNow = rightNow.right;
                        }
                        else
                        {
                            WaitUntilChooseDirection();
                        }
                        break;
                    case "left":
                        if (rightNow.left != null)
                        {
                            Gerak(rightNow.left);
                            rightNow = rightNow.left;
                        }
                        else
                        {
                            WaitUntilChooseDirection();
                        }
                        break;
                }
            }
            else
            {
                break;
            }
            yield return new WaitForSeconds(.75f);
        }
    }
}

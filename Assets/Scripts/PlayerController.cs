using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public node rightNow = null;
    public static int arah = 0;
    public static int sisaDadu = 0;
    public static bool pilihArrow = false;
    
    public static bool selectDirection = false;
    public static bool puterdadu = false;
    public static int jalan = 0;

    void Start () {
        puterdadu = false;
	}

    private void Update()
    {
        Debug.Log(jalan);
        if (puterdadu == true)
        {
            StartCoroutine(Move(jalan));
        }
        if (pilihArrow == true)
        {
            StartCoroutine(Move(sisaDadu));
        }
    }

    void Gerak(node next)
    {
        transform.position = next.transform.position;
    }

    bool WaitUntilChooseDirection()
    {
        Debug.Log("waitiinggg");
        selectDirection = true;
        return true;
    }

    IEnumerator Move(int jmlDadu)
    {
        puterdadu = false;
        pilihArrow = false;
        bool sisa = false;
        for (int i = jmlDadu; i > 0; i--)
        {
            sisaDadu = i;
            //Debug.Log("BERAPA JALANNYA : " + jalan);
            Debug.Log("SISA JALANNYA : " + sisaDadu);
            if (!selectDirection)
            {
                switch (arah)
                {
                    case 0:
                        if (rightNow.bottom != null)
                        {
                            Gerak(rightNow.bottom);
                            rightNow = rightNow.bottom;
                        }
                        else
                        {
                            sisa = WaitUntilChooseDirection();
                        }
                        break;
                    case 3:
                        if (rightNow.top != null)
                        {
                            Gerak(rightNow.top);
                            rightNow = rightNow.top;
                        }
                        else
                        {
                            sisa = WaitUntilChooseDirection();
                        }
                        break;
                    case 2:
                        if (rightNow.right != null)
                        {
                            Gerak(rightNow.right);
                            rightNow = rightNow.right;
                        }
                        else
                        {
                            sisa = WaitUntilChooseDirection();
                        }
                        break;
                    case 1:
                        if (rightNow.left != null)
                        {
                            Gerak(rightNow.left);
                            rightNow = rightNow.left;
                        }
                        else
                        {
                            sisa = WaitUntilChooseDirection();
                        }
                        break;
                }
                if (sisa)
                {
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

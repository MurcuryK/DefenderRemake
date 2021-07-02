using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGAni : MonoBehaviour
{

    public Vector2 NumFrames = new Vector2(6, 1);
    public Vector2 CurrentFrame = new Vector2(0, 0);

    Vector2 Size;
    float FramePerSec = 30;
    float NextFrameTime;

    private MeshRenderer AniRenderer;

	// Use this for initialization
	void Start () {
        AniRenderer = GetComponent<MeshRenderer>();

        Size = new Vector2(1.0f / NumFrames.x, 1.0f / NumFrames.y);

        NextFrameTime = Time.time + (1 / FramePerSec);
	}
	
	// Update is called once per frame
	void Update () {

        if(NextFrameTime < Time.time)
        {
            NextFrameTime = Time.time + (1 / FramePerSec);
            CurrentFrame.x++;
        }

        if(CurrentFrame.x >= NumFrames.x)
        {
            CurrentFrame.x = 0;
            CurrentFrame.y++;

            if(CurrentFrame.y >+ NumFrames.y)
            {
                CurrentFrame.y = 0;
            }
        }

        Vector2 OffSet = new Vector2(CurrentFrame.x * Size.x, 1.0f - Size.y - CurrentFrame.y * Size.y);

        AniRenderer.material.SetTextureOffset("_MainTex", OffSet);
        AniRenderer.material.SetTextureScale("_MainTex", Size);
    }
}

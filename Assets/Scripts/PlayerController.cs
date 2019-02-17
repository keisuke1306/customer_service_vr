﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace CUSTOMER_SERVICE
{
	public class PlayerController : MonoBehaviour
	{

		// Use this for initialization
		void Start ()
		{
			// 初期位置
			transform.position = new Vector3(27.5f, 6.7f, 3.9f);

			Vector3[] paths = new [] {
				new Vector3(20f, 2.3f, -0.5f),
				new Vector3(8.33f, 1.46f, 3.26f),
			};

            DOTween.Sequence().Append(
                transform.DOPath(
                    paths,
                    5f,
                    PathType.CatmullRom
                )
            )
            .Append(
                transform.DOPath(
                    new Vector3[]{
                        new Vector3(4.8f, 1.11f, 3.26f),
                        new Vector3(4f, 0.52f, -1.46f),
                    },
                    4f,
                    PathType.CatmullRom
                )
             )
             .Join(
                transform.DORotate(
                    new Vector3(0f, -270f, 0f),
                    4f
                )
             )
             .SetDelay(3f);
		}
		
		// Update is called once per frame
		void Update ()
		{
			
		}
	}
}
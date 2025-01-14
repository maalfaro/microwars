﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovieOnSpace : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            Renderer r = GetComponent<Renderer>();
            MovieTexture movie = (MovieTexture)r.material.mainTexture;

            if (movie != null) { 
                if (movie.isPlaying)
                {
                    movie.Pause();
                }
                else
                {
                    movie.Play();
                }
            }else
            {

            }
        }
    }
}

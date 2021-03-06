﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbyssalSpotify
{
    /// <summary>
    ///     Represents a generic Spotify entity.
    /// </summary>
    public abstract class SpotifyEntity
    {
        internal SpotifyClient Client;

        internal SpotifyEntity(SpotifyClient client)
        {
            Client = client;
        }
    }
}
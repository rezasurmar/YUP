﻿using System;
using System.Collections.Generic;

namespace YUP.App.Base
{
    public class YtBase
    {
        public string                           channelId           { get; set; } // This is common for channel and video

        public string                           title               { get; set; }   
        public string                           description         { get; set; }
        public string                           thumbnail           { get; set; }

        public bool                             isWatched           { get; set; }
        public bool                             isFavorite          { get; set; }
        public bool                             isHidden            { get; set; }
        public bool                             IsChosen            { get; set; } //Used for multiple items editing 


        //public List<YTThumbnail>                thumbnails  { get; set; }
        public string[]                         tags                { get; set; }
    }
}
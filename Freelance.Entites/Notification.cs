﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Freelance.Entites
{
    public class Notification
    {
        public int Id { get; set; }
        public string NotificationText { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string FromUserName { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}

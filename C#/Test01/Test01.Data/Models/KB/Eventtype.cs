﻿using System;
using System.Collections.Generic;

namespace Test01.Data.Models.KB
{
    public partial class Eventtype
    {
        public Eventtype()
        {
            TopicEvent = new HashSet<TopicEvent>();
        }

        public int Id { get; set; }
        public string Shortname { get; set; }
        public string Description { get; set; }
        public string Sifgroup { get; set; }
        public string Cuser { get; set; }
        public DateTime? Cdate { get; set; }
        public string Muser { get; set; }
        public DateTime? Mdate { get; set; }

        public virtual ICollection<TopicEvent> TopicEvent { get; set; }
    }
}

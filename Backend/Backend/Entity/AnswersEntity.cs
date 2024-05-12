﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entity
{
    public class AnswersEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime Posted { get; set; }

        public int UserId { get; set; }

        public int QuestId { get; set; }
    }
}

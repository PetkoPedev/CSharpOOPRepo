﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P05_BorderControl
{
    public class Robot : ILivable
    {
        public string Model { get; private set; }
        public string Id { get; private set; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}

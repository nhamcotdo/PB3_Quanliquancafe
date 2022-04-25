﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class CBBItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public CBBItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString() => Text;
        public CBBItem()
        {
        }
    }
}

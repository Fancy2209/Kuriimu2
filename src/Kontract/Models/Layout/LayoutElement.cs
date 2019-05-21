﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Kontract.Models.Layout
{
    public abstract class LayoutElement
    {
        public Size Size { get; }

        public Point RelativeLocation { get; }

        protected LayoutElement(Size size, Point location)
        {
            Size = size;
            RelativeLocation = location;
        }

        public virtual void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Brushes.Black, 3), new Rectangle(GetAbsoluteLocation(), Size));
        }

        public abstract Point GetAbsoluteLocation();
    }
}

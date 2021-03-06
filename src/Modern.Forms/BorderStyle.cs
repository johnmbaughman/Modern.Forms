﻿using SkiaSharp;

namespace Modern.Forms
{
    public class BorderStyle
    {
        private readonly BorderStyle? _parent;

        private SKColor color;
        private int width;

        public BorderStyle (BorderStyle? parent)
        {
            _parent = parent;

            Left = new BorderSideStyle (_parent?.Left);
            Top = new BorderSideStyle (_parent?.Top);
            Right = new BorderSideStyle (_parent?.Right);
            Bottom = new BorderSideStyle (_parent?.Bottom);
        }

        public SKColor Color {
            get => color;
            set {
                color = value;
                Left.Color = value;
                Right.Color = value;
                Top.Color = value;
                Bottom.Color = value;
            }
        }

        public int Width {
            get => width;
            set {
                width = value;
                Left.Width = value;
                Right.Width = value;
                Top.Width = value;
                Bottom.Width = value;
            }
        }

        public int? Radius { get; set; }

        public int GetRadius () => Radius ?? _parent?.GetRadius () ?? 0;

        public BorderSideStyle Left { get; }
        public BorderSideStyle Top { get; }
        public BorderSideStyle Right { get; }
        public BorderSideStyle Bottom { get; }
    }

    public class BorderSideStyle
    {
        private readonly BorderSideStyle? _parent;

        public BorderSideStyle (BorderSideStyle? parent) => _parent = parent;

        public SKColor? Color { get; set; }

        public SKColor GetColor () => Color ?? _parent?.GetColor () ?? Theme.BorderGray;

        public int? Width { get; set; }

        public int GetWidth () => Width ?? _parent?.GetWidth () ?? 0;
    }
}

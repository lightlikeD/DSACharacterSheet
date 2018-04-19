﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DSACharacterSheet.Xml.Objects
{
    public class Stroke : BindableBase, IEnumerable<Point>
    {
        private Color _color = Color.Black;

        public Color Color
        {
            get { return _color; }
            set
            {
                if (_color == value)
                    return;
                _color = value;
                OnPropertyChanged();
            }
        }

        private double _width = 0;

        public double Width
        {
            get { return _width; }
            set
            {
                if (_width == value)
                    return;
                _width = value;
                OnPropertyChanged();
            }
        }

        private IList<Point> _points = new List<Point>();

        public IList<Point> Points
        {
            get { return _points; }
            private set
            {
                if (_points == value)
                    return;
                _points = value;
                OnPropertyChanged();
            }
        }

        public int Count
        {
            get { return Points.Count(); }
        }

        public Point this[int index]
        {
            get { return Points[index]; }
        }

        #region c'tor

        public Stroke(IEnumerable<Point> points, Color color, double width)
        {
            Color = color;

            Width = width;
            //Width = stroke.DrawingAttributes.Width;

            foreach (var point in points)
            //foreach (var point in stroke.GetBezierStylusPoints())
                    Points.Add(new Point(Convert.ToInt32(point.X), Convert.ToInt32(point.Y)));
        }

        #endregion c'tor

        public IEnumerator<Point> GetEnumerator()
        {
            return Points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Points.GetEnumerator();
        }

        public List<System.DrawingCore.Point> GetDrawingCorePoints()
        {
            var result = new List<System.DrawingCore.Point>();

            foreach (var point in Points)
            {
                result.Add(new System.DrawingCore.Point(point.X, point.Y));
            }

            return result;
        }
    }
}
﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using Painting.Types.Paint;

namespace Tanks.Objects
{
    public class Bullet : GameObject
    {
        private float _rotation;

        public float Rotation
        {
            get { return _rotation; }
            set
            {
                View.Rotation = value;
                _rotation = value;
            }
        }

        public Bullet(Coordinate position, Coordinate size, Colour colour, float rotation)
            : base(
                position, size,
                new ShapeCollection(new ObservableCollection<Shape>
                {
                    new Ellipse(0, new Colour(Color.Empty), new Coordinate(658, 277), new Coordinate(50, 120),
                        new Colour(Color.FromArgb(-16777216)), 0f),
                    new Polygon(3, 0, new Colour(Color.Empty), new Coordinate(648, 322), new Coordinate(70, 100),
                        new Colour(Color.FromArgb(-65536)), 30),
                }) {Position = new Coordinate(0, 0)})
        {
            View.Shapes[1].MainColour = colour;
            Rotation = rotation;
        }
    }
}
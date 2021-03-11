﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MaritimeTravel.Source.GameComponents {
    class Transform {
        public Vector2 Position { get; set; }
        public Vector2 Dimensions { get; set; }
        public Vector2 Scale { get; set; }
        public float Rotation { get; set; }

        public Transform() {
            Position = new Vector2(0f, 0f);
            Scale = new Vector2(1f, 1f);
            Rotation = 0f;
            Dimensions = new Vector2(100, 100);
        }

        public Transform(Vector2 dimensions) {
            Position = new Vector2(0f, 0f);
            Scale = new Vector2(1f, 1f);
            Rotation = 0f;
            Dimensions = dimensions;
        }

        public Transform(Vector2 dimensions, float rotation) {
            Position = new Vector2(0f, 0f);
            Scale = new Vector2(1f, 1f);
            Rotation = rotation;
            Dimensions = dimensions;
        }

        public void Translate(Vector2 translation) {
            Position += translation;
        }

        public void Rotate(float radians) {
            Rotation += radians;
        }
    }
}

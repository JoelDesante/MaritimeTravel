﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;

namespace MaritimeTravel.Source.Scene {
    abstract class Scene {

        protected MaritimeTravel game;
        protected Dictionary<string, Song> songs;
        
        public Scene(MaritimeTravel game) {
            this.game = game;
            this.songs = new Dictionary<string, Song>();
        }

        public abstract void LoadContent();
        public abstract void UnloadContent();
        public abstract void Draw(SpriteBatch spriteBatch, GameTime gameTime);
        public abstract void Update(GameTime gameTime);
        public abstract void Initialize();
    }
}

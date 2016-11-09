﻿using System;
using System.Drawing;
using System.Linq;
using Painting.Types.Paint;
using Tanks.Backend;
using Tanks.Enums;

namespace Tanks.Objects.GameObjects
{
    public class EvilPlayer : Player
    {
        public EvilPlayer(Coordinate position, Coordinate unturnedSize, float rotation, decimal id,
            Coordinate startPosition, int intelligenceLevel, InGameEngine engine, int lives = 1) : base(rotation, lives, position, unturnedSize, new Colour(Color.Red), id, startPosition, (decimal)1E7)
        {
            IntelligenceLevel = intelligenceLevel;
            Engine = engine;
        }

        public virtual void DoSomething()
        {
        }

        protected void Trace() => Tracer.TracePosition(Engine.Player.CenterPosition(), this);
        protected void IntelliShoot()
        {
            if (Engine.Field.Objects
                    .Where(o => o is Block)
                    .Any(block => Arithmetic.Cuts(CenterPosition(), block.Position, block.UnturnedSize, Rotation, PublicStuff.NormalBulletSize, 5)))
                return;
            Shoot(Engine);
        }

        public int IntelligenceLevel { get; protected set; }
        private InGameEngine Engine { get; }
    }
}
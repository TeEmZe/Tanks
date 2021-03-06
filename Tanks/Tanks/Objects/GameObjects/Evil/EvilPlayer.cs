﻿using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms.VisualStyles;
using Painting.Types.Paint;
using Tanks.Backend;
using Tanks.Enums;
using Tanks.Objects.Animation;

namespace Tanks.Objects.GameObjects.Evil
{
    public class EvilPlayer : Player
    {
        public EvilPlayer(Coordinate position, Coordinate size, float rotation,
            Coordinate startPosition, int intelligenceLevel, InGameEngine engine, int lives = 1)
            : base(
                rotation, lives, position, size, new Colour(Color.Red), startPosition, (decimal)1E7, engine,
                typeof(NormalBullet))
        {
            IntelligenceLevel = intelligenceLevel;
        }

        public virtual void DoSomething()
        {
        }

        protected void IntelliTrace(Coordinate aim)
        {
            if (!IntelliCutsAnything(new Area(aim, Position), 1))
                return;
            Trace(aim);
            if (!IntelliCutsAnything(new Area(aim, Position), 1))
                return;
            var direction = Direction.Up;
            do
            {
                Trace(GetReboundingPositionToShoot(aim, direction));
                if (direction == Direction.Left)
                    break;
                direction = DirectionFunctionality.Next(direction);
            } while (IntelliCutsAnything(new Area(aim, Position), 1));
        }

        private void Trace(Coordinate aim) => Rotation = Tracer.TracePosition(aim, this);

        private void IntelliShoot(Coordinate aim, int intelliState = 0)
        {
            if (IntelliCutsAnything(new Area(aim, Position), intelliState))
                return;
            Shoot();
        }

        /// <summary>
        /// Doesn't calculate rebounding
        /// </summary>
        /// <param name="area"></param>
        /// <param name="intelliState"></param>
        /// <returns></returns>
        private bool IntelliCutsAnything(Area area, int intelliState = 0)
            =>
            Engine.Field.Objects.Any(
                o =>
                    (o is Block || intelliState > 0 && o is EvilPlayer) &&
                    (area.IsCoordinateInArea(o.Position) || area.IsCoordinateInArea(o.Position.Add(o.Size))) &&
                    Arithmetic.Cuts(CenterPosition(), o.Position, o.Size, Rotation, PublicStuff.NormalBulletSize, 5));

        protected void IntelliTraceShoot(Coordinate aim, int intelliState = 0)
        {
            switch (intelliState)
            {
                case 0:
                    Trace(aim);
                    IntelliShoot(aim, intelliState);
                    break;
                case 1:
                    Trace(aim);
                    if (BulletType == typeof(NormalBullet))
                    {
                        IntelliTrace(aim);
                        IntelliShoot(aim, 1);
                    }
                    else
                        throw new NotImplementedException("This bullet is not supported for intelligent shooting yet.");
                    break;
            }
        }

        private int IntelligenceLevel { get; }
    }
}
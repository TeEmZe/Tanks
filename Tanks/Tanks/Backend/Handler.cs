﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Painting.Types.Paint;
using Tanks.Enums;
using Tanks.Frontend;
using Tanks.Objects;
using Tanks.Objects.Animation;

namespace Tanks.Backend
{
    public class Handler
    {
        public static void KeyInPutHandler (InGameEngine engine, Keys key, KeyHandlerAction action)
        {
            switch (key)
            {
                case Keys.KeyCode:
                    break;
                case Keys.Modifiers:
                    break;
                case Keys.None:
                    break;
                case Keys.LButton:
                    break;
                case Keys.RButton:
                    break;
                case Keys.Cancel:
                    break;
                case Keys.MButton:
                    break;
                case Keys.XButton1:
                    break;
                case Keys.XButton2:
                    break;
                case Keys.Back:
                    break;
                case Keys.Tab:
                    break;
                case Keys.LineFeed:
                    break;
                case Keys.Clear:
                    break;
                case Keys.Return:
                    break;
                case Keys.ShiftKey:
                    break;
                case Keys.ControlKey:
                    break;
                case Keys.Menu:
                    break;
                case Keys.Pause:
                    break;
                case Keys.Capital:
                    break;
                case Keys.KanaMode:
                    break;
                case Keys.JunjaMode:
                    break;
                case Keys.FinalMode:
                    break;
                case Keys.HanjaMode:
                    break;
                case Keys.Escape:
                        engine.Window.Close();
                    break;
                case Keys.IMEConvert:
                    break;
                case Keys.IMENonconvert:
                    break;
                case Keys.IMEAccept:
                    break;
                case Keys.IMEModeChange:
                    break;
                case Keys.Space:
                    break;
                case Keys.Prior:
                    break;
                case Keys.Next:
                    break;
                case Keys.End:
                    break;
                case Keys.Home:
                    break;
                case Keys.Left:
                    break;
                case Keys.Up:
                    break;
                case Keys.Right:
                    break;
                case Keys.Down:
                    engine.Window.WindowState = FormWindowState.Minimized;
                    break;
                case Keys.Select:
                    break;
                case Keys.Print:
                    break;
                case Keys.Execute:
                    break;
                case Keys.Snapshot:
                    break;
                case Keys.Insert:
                    break;
                case Keys.Delete:
                    break;
                case Keys.Help:
                    break;
                case Keys.D0:
                    break;
                case Keys.D1:
                    break;
                case Keys.D2:
                    break;
                case Keys.D3:
                    break;
                case Keys.D4:
                    break;
                case Keys.D5:
                    break;
                case Keys.D6:
                    break;
                case Keys.D7:
                    break;
                case Keys.D8:
                    break;
                case Keys.D9:
                    break;
                case Keys.A:
                    if (action == KeyHandlerAction.Down)
                    {
                        if (!(engine.Player.Position.X > 10) || !(engine.Player.Position.X + engine.Player.Size.X > 10) ||
                            engine.Animations.Any (
                                animation =>
                                    animation.AnimatedObject.Id == engine.Player.Id &&
                                    ((NormalMoveAnimation) animation).Direction == Direction.Left))
                            break;
                        if (engine.Animations.Any (
                            animation =>
                                animation.AnimatedObject.Id == engine.Player.Id &&
                                ((NormalMoveAnimation) animation).Direction == Direction.Right))
                            engine.Animations =
                                new ObservableCollection<Animation> (engine.Animations.Where (
                                    animation =>
                                        !(animation.AnimatedObject.Id == engine.Player.Id &&
                                          ((NormalMoveAnimation) animation).Direction == Direction.Right)).ToList ());
                        engine.Animations.Add (new NormalMoveAnimation (engine.Player, Direction.Left, engine, 3));
                    }
                    else if (action == KeyHandlerAction.Up)
                    {
                        engine.Animations = new ObservableCollection<Animation> (
                            engine.Animations.Where (animation => !(animation.AnimatedObject.Id == engine.Player.Id && ((NormalMoveAnimation) animation).Direction == Direction.Left))
                                .ToList ());
                    }
                    break;
                case Keys.B:
                    break;
                case Keys.C:
                    break;
                case Keys.D:
                    if (action == KeyHandlerAction.Down)
                    {
                        if (!(engine.Player.Position.X < engine.Field.Size.X) ||
                            !(engine.Player.Position.X + engine.Player.Size.X < engine.Field.Size.X) ||
                            engine.Animations.Any (
                                animation =>
                                    animation.AnimatedObject.Id == engine.Player.Id &&
                                    ((NormalMoveAnimation) animation).Direction == Direction.Right))
                            break;
                        if (engine.Animations.Any (
                            animation =>
                                animation.AnimatedObject.Id == engine.Player.Id &&
                                ((NormalMoveAnimation) animation).Direction == Direction.Left))
                            engine.Animations =
                                new ObservableCollection<Animation> (engine.Animations.Where (
                                    animation =>
                                        !(animation.AnimatedObject.Id == engine.Player.Id &&
                                          ((NormalMoveAnimation) animation).Direction == Direction.Left)).ToList ());
                        engine.Animations.Add (new NormalMoveAnimation (engine.Player, Direction.Right, engine, 3));
                    }
                    else if (action == KeyHandlerAction.Up)
                    {
                        engine.Animations = new ObservableCollection<Animation> (
                            engine.Animations.Where (
                                    animation =>
                                        !(animation.AnimatedObject.Id == engine.Player.Id &&
                                          ((NormalMoveAnimation) animation).Direction == Direction.Right))
                                .ToList ());
                    }
                    break;
                case Keys.E:
                    break;
                case Keys.F:
                    break;
                case Keys.G:
                    break;
                case Keys.H:
                    break;
                case Keys.I:
                    break;
                case Keys.J:
                    break;
                case Keys.K:
                    break;
                case Keys.L:
                    break;
                case Keys.M:
                    break;
                case Keys.N:
                    break;
                case Keys.O:
                    break;
                case Keys.P:
                    break;
                case Keys.Q:
                    break;
                case Keys.R:
                    break;
                case Keys.S:
                    if (action == KeyHandlerAction.Down)
                    {
                        if (!(engine.Player.Position.Y < engine.Field.Size.Y) || !(engine.Player.Position.Y + engine.Player.Size.Y < engine.Field.Size.Y) || engine.Animations.Any (animation => animation.AnimatedObject.Id == engine.Player.Id && ((NormalMoveAnimation) animation).Direction == Direction.Down))
                            break;
                        if (engine.Animations.Any (
                                animation =>
                                    animation.AnimatedObject.Id == engine.Player.Id &&
                                    ((NormalMoveAnimation) animation).Direction == Direction.Up))
                            engine.Animations =
                                new ObservableCollection<Animation> (engine.Animations.Where (
                                    animation =>
                                        !(animation.AnimatedObject.Id == engine.Player.Id &&
                                          ((NormalMoveAnimation) animation).Direction == Direction.Up)).ToList ());
                        engine.Animations.Add (new NormalMoveAnimation (engine.Player, Direction.Down, engine, 3));
                    }
                    else if (action == KeyHandlerAction.Up)
                    {
                        engine.Animations = new ObservableCollection<Animation> (
                            engine.Animations.Where (
                                    animation =>
                                        !(animation.AnimatedObject.Id == engine.Player.Id &&
                                          ((NormalMoveAnimation) animation).Direction == Direction.Down))
                                .ToList ());
                    }
                    break;
                case Keys.T:
                    break;
                case Keys.U:
                    break;
                case Keys.V:
                    break;
                case Keys.W:
                    if (action == KeyHandlerAction.Down)
                    {
                        if (!(engine.Player.Position.Y > 10) || !(engine.Player.Position.Y + engine.Player.Size.Y > 10) || engine.Animations.Any (animation => animation.AnimatedObject.Id == engine.Player.Id && ((NormalMoveAnimation) animation).Direction == Direction.Up))
                            break;
                        if (engine.Animations.Any (
                                animation =>
                                    animation.AnimatedObject.Id == engine.Player.Id &&
                                    ((NormalMoveAnimation) animation).Direction == Direction.Down))
                            engine.Animations =
                                new ObservableCollection<Animation> (engine.Animations.Where (
                                    animation =>
                                        !(animation.AnimatedObject.Id == engine.Player.Id &&
                                          ((NormalMoveAnimation) animation).Direction == Direction.Down)).ToList ());
                        engine.Animations.Add (new NormalMoveAnimation (engine.Player, Direction.Up, engine, 3));
                    }
                    else if (action == KeyHandlerAction.Up)
                    {
                        engine.Animations = new ObservableCollection<Animation> (
                            engine.Animations.Where (
                                    animation =>
                                        !(animation.AnimatedObject.Id == engine.Player.Id &&
                                          ((NormalMoveAnimation) animation).Direction == Direction.Up))
                                .ToList ());
                    }
                    break;
                case Keys.X:
                    break;
                case Keys.Y:
                    break;
                case Keys.Z:
                    break;
                case Keys.LWin:
                    break;
                case Keys.RWin:
                    break;
                case Keys.Apps:
                    break;
                case Keys.Sleep:
                    break;
                case Keys.NumPad0:
                    break;
                case Keys.NumPad1:
                    break;
                case Keys.NumPad2:
                    break;
                case Keys.NumPad3:
                    break;
                case Keys.NumPad4:
                    break;
                case Keys.NumPad5:
                    break;
                case Keys.NumPad6:
                    break;
                case Keys.NumPad7:
                    break;
                case Keys.NumPad8:
                    break;
                case Keys.NumPad9:
                    break;
                case Keys.Multiply:
                    break;
                case Keys.Add:
                    break;
                case Keys.Separator:
                    break;
                case Keys.Subtract:
                    break;
                case Keys.Decimal:
                    break;
                case Keys.Divide:
                    break;
                case Keys.F1:
                    break;
                case Keys.F2:
                    break;
                case Keys.F3:
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    break;
                case Keys.F6:
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    break;
                case Keys.F13:
                    break;
                case Keys.F14:
                    break;
                case Keys.F15:
                    break;
                case Keys.F16:
                    break;
                case Keys.F17:
                    break;
                case Keys.F18:
                    break;
                case Keys.F19:
                    break;
                case Keys.F20:
                    break;
                case Keys.F21:
                    break;
                case Keys.F22:
                    break;
                case Keys.F23:
                    break;
                case Keys.F24:
                    break;
                case Keys.NumLock:
                    break;
                case Keys.Scroll:
                    break;
                case Keys.LShiftKey:
                    break;
                case Keys.RShiftKey:
                    break;
                case Keys.LControlKey:
                    break;
                case Keys.RControlKey:
                    break;
                case Keys.LMenu:
                    break;
                case Keys.RMenu:
                    break;
                case Keys.BrowserBack:
                    break;
                case Keys.BrowserForward:
                    break;
                case Keys.BrowserRefresh:
                    break;
                case Keys.BrowserStop:
                    break;
                case Keys.BrowserSearch:
                    break;
                case Keys.BrowserFavorites:
                    break;
                case Keys.BrowserHome:
                    break;
                case Keys.VolumeMute:
                    break;
                case Keys.VolumeDown:
                    break;
                case Keys.VolumeUp:
                    break;
                case Keys.MediaNextTrack:
                    break;
                case Keys.MediaPreviousTrack:
                    break;
                case Keys.MediaStop:
                    break;
                case Keys.MediaPlayPause:
                    break;
                case Keys.LaunchMail:
                    break;
                case Keys.SelectMedia:
                    break;
                case Keys.LaunchApplication1:
                    break;
                case Keys.LaunchApplication2:
                    break;
                case Keys.OemSemicolon:
                    break;
                case Keys.Oemplus:
                    break;
                case Keys.Oemcomma:
                    break;
                case Keys.OemMinus:
                    break;
                case Keys.OemPeriod:
                    break;
                case Keys.OemQuestion:
                    break;
                case Keys.Oemtilde:
                    break;
                case Keys.OemOpenBrackets:
                    break;
                case Keys.OemPipe:
                    break;
                case Keys.OemCloseBrackets:
                    break;
                case Keys.OemQuotes:
                    break;
                case Keys.Oem8:
                    break;
                case Keys.OemBackslash:
                    break;
                case Keys.ProcessKey:
                    break;
                case Keys.Packet:
                    break;
                case Keys.Attn:
                    break;
                case Keys.Crsel:
                    break;
                case Keys.Exsel:
                    break;
                case Keys.EraseEof:
                    break;
                case Keys.Play:
                    break;
                case Keys.Zoom:
                    break;
                case Keys.NoName:
                    break;
                case Keys.Pa1:
                    break;
                case Keys.OemClear:
                    break;
                case Keys.Shift:
                    break;
                case Keys.Control:
                    break;
                case Keys.Alt:
                    break;
                default:
                    throw new ArgumentOutOfRangeException ();
            }
        }

        public static void MouseInputHandler (MouseButtons button, InGameEngine engine)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    engine.Field.AddObject (AddableObjects.NormalBullet, engine);
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    throw new ArgumentOutOfRangeException (nameof (button), button, null);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spritimator_Tao
{
    class AnimSequence
    {
        private List<Frame> frames = new List<Frame>();
       // Frame currentFrame = null;
        int selectedFrame = 0;
        string name = "";
        int returnLoopFrame = 0;
        bool played = false;
        bool loop = true;

        public AnimSequence(string _name)
        {
            name = _name;
        }

        public AnimSequence(AnimSequence seq)
        {
            foreach (Frame frame in seq.frames)
            {
                frames.Add(new Frame(frame));
            }
            selectedFrame = seq.selectedFrame;
            name = seq.name + "_duplicate";
        }

        public void DeleteFrame(int index)
        {
            if (index > frames.Count-1 || index < 0)
                return;
            else
            {
                frames.RemoveAt(index);
            }
        }

        public void AddFrame(Frame frame)
        {
            frames.Add(frame);
        }

        public void InsertFrame(int index, Frame frame)
        {
            if (index > frames.Count - 1 || index < 0)
                return;
            else
                frames.Insert(index, frame);
        }

        public void DeleteLast()
        {
            frames.RemoveAt(frames.Count - 1);
        }

        public void ShowAll()
        {
            foreach (Frame frame in frames)
            {
                frame.Show();
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int FrameCount
        {
            get { return frames.Count; }
        }

        public List<Frame> Frames
        { get { return frames; } }

        public int ReturnLoopFrame
        { get { return returnLoopFrame; } set { returnLoopFrame = value; } }

        public bool HasPlayed
        { get { return played; } set { played = value; } }

        public bool Loops
        { get { return loop; } set { loop = value; } }

    }
}

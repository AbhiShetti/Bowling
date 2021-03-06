using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Model
{
    abstract public class Frame
    {
        protected ArrayList throws;
        protected int startingThrow;

        public Frame(ArrayList throws)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
        }

        abstract public int Score();
        abstract protected int FrameSize();

        protected int FirstBonusBall()
        {
            return (int)throws[startingThrow + FrameSize()];
        }

        protected int SecondBonusBall()
        {
            return (int)throws[startingThrow + FrameSize() + 1];
        }
    }
}

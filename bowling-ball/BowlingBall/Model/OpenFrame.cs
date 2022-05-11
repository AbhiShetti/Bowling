using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Model
{
    public class OpenFrame : Frame
    {

        public OpenFrame(ArrayList throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        override public int Score()
        {
            return (int)throws[startingThrow] + (int)throws[startingThrow + 1];
        }

        override protected int FrameSize()
        {
            return 2;
        }
    }
}

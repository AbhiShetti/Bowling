using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Model
{
    public class SpareFrame : Frame
    {

        public SpareFrame(ArrayList throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        override public int Score()
        {
            return 10 + FirstBonusBall(); ;
        }

        override protected int FrameSize()
        {
            return 2;
        }
    }
}
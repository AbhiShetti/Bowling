using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Model
{
    public class StrikeFrame : Frame
    {

        public StrikeFrame(ArrayList throws) : base(throws)
        {
            throws.Add(10);
        }

        override public int Score()
        {
            return 10 + FirstBonusBall() + SecondBonusBall();
        }

        override protected int FrameSize()
        {
            return 1;
        }
    }
}

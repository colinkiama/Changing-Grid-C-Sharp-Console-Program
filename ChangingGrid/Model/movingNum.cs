using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingGrid.Model
{
    public class movingChar
    {
        public const char characterMoving = 'x';

        public int[] charPosition = new int[2];

        public movingChar(int startingX, int startingY)
        {
            charPosition[0] = startingX;
            charPosition[1] = startingY;
        }

        internal void MoveForward()
        {
            if (charPosition[1] < 9)
            {
                charPosition[1] += 1;
            }
            else
            {
                if (charPosition[0] < 9)
                {
                    charPosition[0] += 1;
                }

                else
                {
                    charPosition[0] = 0;
                }

                charPosition[1] = 0;
            }
            
        }

        internal void MoveBack()
        {
            if (charPosition[1] > 0)
            {
                charPosition[1] -= 1;
            }
            else
            {
                if (charPosition[0] > 0)
                {
                    charPosition[0] -= 1;
                }

                else
                {
                    charPosition[0] = 9;
                }

                charPosition[1] = 9;
            }
        }

        internal void MoveUp()
        {
            if (charPosition[0] > 0)
            {
                charPosition[0] -= 1;
            }
            else
            {
                charPosition[0] = 9;
            }
        }

        internal void MoveDown()
        {
            if (charPosition[0] < 9)
            {
                charPosition[0] += 1;
            }
            else
            {
                charPosition[0] = 0;
            }
        }
    }
}

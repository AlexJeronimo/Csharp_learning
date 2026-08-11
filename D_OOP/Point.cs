using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    internal class Point
    {
        private int x;

        public void SetX(int x)
        {
            if(x < 1)
            {
                this.x = 1;
                return;
            }
            if(x > 5)
            {
                this.x = 5;
                return;
            }

            this.x = x;
        }

        public int GetX()
        {
            return x;
        }

        private int y;

        public int Y
        {
            get 
            {
                return y;
            }
            set
            {
                if(value < 1)
                {
                    y = 1;
                    return;
                }
                if(value > 5)
                {
                    y = 5;
                    return;
                }

                y = value;
            }
        }

        private int z;
        public int Z {
            get
            {
                return z;
            }
        }

        public int h { get; set; }

    }
}

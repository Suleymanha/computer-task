using System;
using System.Collections.Generic;
using System.Text;

namespace computer_task
{
    class Apple:Computer
    {
        public Apple(string name, string storage, int ram, int hd) : base(name, storage, ram, hd) 
        {

        }

        public Apple(string name, string storage, int ram, int hd, int screen) : base(name, storage, ram, hd,screen)
        {

        }

}

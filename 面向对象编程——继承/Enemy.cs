using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程__继承
{
    class Enemy
    {
        private float hp;
        private float speed;
        public float Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }

        }
        public float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public  void Ai() {

            Console.WriteLine("公用Ai");
        }
        public  void Move() {
            Console.WriteLine("公用移动");
        }
    }
}

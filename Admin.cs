using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Admin : OrdinaryUser
    {
        // добавляем админом аккаунт с id = 1
        public static int[] adminsID = new int[] { 1 };
        public Admin(int id) : base(id)
        {}
    }
}

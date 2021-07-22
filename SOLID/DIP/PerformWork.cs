using SOLID.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class PerformWork
    {
        public void DoWork()
        {
            IPerson owner = Factory.CreatePerson();

            owner.Name = "Juan Lopez";
            owner.Email = "test@testing.com";
            owner.Phone= "1234-56789";

            IWork work = Factory.CreateWork();
            work.WorkName = "paint the house";
            work.Owner = owner;

            work.PerformedWork(3);
            work.PerformedWork(1.5);
            work.CompleteWork();
        }
    }
}

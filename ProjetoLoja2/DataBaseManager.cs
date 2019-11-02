using ProjectStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStore
{
    public class DataBaseManager
    {
        public FineBurgerContext FineBurgerContext { get; set; }

        public DataBaseManager()
        {
            if(FineBurgerContext == null)
            {
                FineBurgerContext = new FineBurgerContext();
                FineBurgerContext.Database.EnsureCreated();
            }
        }
    }
}

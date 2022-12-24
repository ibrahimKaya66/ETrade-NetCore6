using ETrade.Business.Concrete;
using ETrade.DAL.Abstract;
using ETrade.Data.Context;
using ETrade.Data.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.DAL.Concrete
{
    public class OrderDAL:GenericRepository<Order,ETradeContext>,IOrderDAL
    {
    }
}

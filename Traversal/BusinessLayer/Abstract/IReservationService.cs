﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
       List<Reservation> GetListOfPendingApprovalReservations(int id);
       List<Reservation> GetListOfAcceptedReservations(int id);
       List<Reservation> GetListOfPastReservations(int id);
    }
}

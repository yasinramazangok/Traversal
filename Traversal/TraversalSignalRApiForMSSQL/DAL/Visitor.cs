﻿namespace TraversalSignalRApiForMSSQL.DAL
{
    public enum ECity
    {
        Edirne = 1,
        İstanbul = 2,
        Ankara = 3,
        Antalya = 4,
        Bursa = 5
    }

    public class Visitor
    {
        public int VisitorId { get; set; }

        public ECity City { get; set; }

        public int VisitCount { get; set; }

        public DateTime Date { get; set; }
    }
}

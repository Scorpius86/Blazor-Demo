using System;

namespace FlightFinder.Shared
{
    public enum TicketClass : int
    {
        Economy = 0,
        PremiumEconomy = 1,
        Business = 2,
        First = 3,
    }

    public static class TicketClassExtensions
    {
        public static string ToDisplayString(this TicketClass ticketClass)
        {
            switch (ticketClass)
            {
                case TicketClass.Economy: return "Economico";
                case TicketClass.PremiumEconomy: return "Economico Premium";
                case TicketClass.Business: return "Ejecutivo";
                case TicketClass.First: return "Primera Clase";
                default: throw new ArgumentException("Unknown ticket class: " + ticketClass.ToString());
            }
        }
    }

}

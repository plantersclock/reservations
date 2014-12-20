using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using Dapper;

namespace ReservationApp.Models
{
    public class ReservationRepository
    {
        string dbPath = @"Data Source = C:\Users\Matthew\Documents\visual studio 2013\Projects\ReservationApp\reservations.db; Version = 3;";

        public IEnumerable<Reservation> AllReservations()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var reservations = connection.Query<Reservation>("select * from reservations");
            return reservations;
        }
    }
}
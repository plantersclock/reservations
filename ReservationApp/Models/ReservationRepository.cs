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

        public IEnumerable<Reservation> AvailableDryVans()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var DryVans = connection.Query<Reservation>("select * from reservations where status != 'major' and type == 'dry_van'");
            return DryVans;
        }

        public IEnumerable<Reservation> AvailableReefers()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var Reefers = connection.Query<Reservation>("select * from reservations where status != 'major' and type == 'reefer'");
            return Reefers;
        }

        public IEnumerable<Reservation> AvailableFlatBeds()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var FlatBeds = connection.Query<Reservation>("select * from reservations where status != 'major' and type == 'flatbed'");
            return FlatBeds;
        }
    }
}
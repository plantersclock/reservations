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

        public IEnumerable<Inventory> AllReservations()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var reservations = connection.Query<Inventory>("select * from inventory");
            return reservations;
        }

        public IEnumerable<Inventory> AvailableDryVans()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var DryVans = connection.Query<Inventory>("select * from inventory where status != 'major' and type == 'dry_van' and reserved == 0");
            return DryVans;
        }

        public IEnumerable<Inventory> AvailableReefers()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var Reefers = connection.Query<Inventory>("select * from inventory where status != 'major' and type == 'reefer' and reserved == 0");
            return Reefers;
        }

        public IEnumerable<Inventory> AvailableFlatBeds()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var FlatBeds = connection.Query<Inventory>("select * from inventory where status != 'major' and type == 'flatbed' and reserved == 0");
            return FlatBeds;
        }

        public IEnumerable<String> CustomerNames()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var names = connection.Query<String>("select distinct customer_name from reservations");
            return names;
        }

        public IEnumerable<Reservations> CustomerReservations()
        {
            var connection = new SQLiteConnection(dbPath);
            connection.Open();
            var reservationcounts = connection.Query<Reservations>("select * from reservations order by");
            return reservationcounts;
        }

    }
}
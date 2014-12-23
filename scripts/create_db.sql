DROP TABLE IF EXISTS main.inventory;
DROP TABLE IF EXISTS main.reservations;

CREATE TABLE main.inventory (
   id INTEGER PRIMARY KEY AUTOINCREMENT,
   type TEXT,
   status TEXT,
   reserved INTEGER,
   reservedby TEXT
);

  
   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('dry_van', 'ready', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('dry_van', 'ready', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('dry_van', 'minor', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('dry_van', 'major', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('reefer', 'ready', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('flatbed', 'ready', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('reefer', 'minor', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('flatbed', 'major', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('dry_van', 'ready', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('flatbed', 'ready', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('reefer', 'minor', 0, NULL);

   INSERT INTO main.inventory (type, status, reserved, reservedby)
   VALUES ('reefer', 'major', 0, NULL);


   CREATE TABLE main.reservations (
   id INTEGER PRIMARY KEY AUTOINCREMENT,
   customer_name TEXT,
   date TEXT,
   fulfilled INTEGER,
   dv_count INTEGER,
   fb_count INTEGER,
   r_count INTEGER
);

INSERT INTO main.reservations (customer_name, date, fulfilled, dv_count, fb_count, r_count)
   VALUES ('Amazon', '01/01/15', 0, 3, 1, 1);

INSERT INTO main.reservations (customer_name, date, fulfilled, dv_count, fb_count, r_count)
   VALUES ('UPS', '12/23/14', 0, 1, 0, 1);

INSERT INTO main.reservations (customer_name, date, fulfilled, dv_count, fb_count, r_count)
   VALUES ('E-Toys', '07/04/15' , 0, 3, 4, 1);


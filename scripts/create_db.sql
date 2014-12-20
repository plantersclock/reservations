DROP TABLE IF EXISTS main.reservations;

CREATE TABLE main.reservations (
   id INT,
   type TEXT,
   status TEXT,
   reserved INT
);

INSERT INTO main.reservations (id, type, status, reserved)
   VALUES (1, 'dry_van', 'ready', 0);
-- Inserting Powers to Superpower table
INSERT INTO Superpower (Power_Name, Power_Description) VALUES (
	'Super strength', 
	'The power to exert force and lift weights beyond what is physically possible for an ordinary human being.'
);

INSERT INTO Superpower (Power_Name, Power_Description) VALUES (
	'Flying', 
	'Ability to fly.'
);

INSERT INTO Superpower (Power_Name, Power_Description) VALUES (
	'Telephaty', 
	'The power to mentally interact with other minds.'
);

INSERT INTO Superpower (Power_Name, Power_Description) VALUES (
	'Jazz hands', 
	'Very jazzy hands.'
);

-- Givin superheros superpowers
INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(1, 1);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(2, 4);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(3, 1);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(3, 2);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(3, 3);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(4, 3);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(5, 4);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(5, 4);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(6, 1);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(7, 4);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(8, 1);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(9, 2);

INSERT INTO SuperheroPower (HeroID, PowerID) VALUES(10, 1);
-- Creating the SuperheroDb
CREATE DATABASE SuperheroDB;

-- Creating the Superhero table
CREATE TABLE Superhero(
	SuperheroID int IDENTITY(1,1) PRIMARY KEY,
	Heroname nvarchar(50) NOT NULL,
	Alias nvarchar(100) NOT NULL,
	Origin nvarchar(100) NULL,
);

-- Creating the Assistant table
CREATE TABLE Assistant(
	AssistantID int IDENTITY(1,1) PRIMARY KEY,
	Assistantname nvarchar(50) NOT NULL,
);

-- Creating the Power table
CREATE TABLE SuperPower(
	PowerID int IDENTITY(1,1) PRIMARY KEY,
	Powername nvarchar(50) NOT NULL,
	PowerDescription nvarchar(200) NULL,
);

-- Adding SuperheroID to Assistant table as a foreign key
ALTER TABLE Assistant
ADD SuperheroID int FOREIGN KEY REFERENCES Superhero(SuperheroID);

-- Adding a SuperheroesPower table ??
CREATE TABLE SuperheroesPower(
	 SuperheroID int FOREIGN KEY REFERENCES Superhero(SuperheroID),
	 SuperpowerID int FOREIGN KEY REFERENCES Superpower(PowerID)
);
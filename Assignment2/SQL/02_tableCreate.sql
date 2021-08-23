-- Creating the Superhero table
CREATE TABLE Superhero(
	HeroID int IDENTITY(1,1) PRIMARY KEY,
	Hero_Name nvarchar(50) NOT NULL,
	Alias nvarchar(100) NOT NULL,
	Origin nvarchar(200) NULL,
);

-- Creating the Assistant table
CREATE TABLE Assistant(
	AssistantID int IDENTITY(1,1) PRIMARY KEY,
	Assistant_Name nvarchar(50) NOT NULL,
);

-- Creating the Power table
CREATE TABLE Superpower(
	PowerID int IDENTITY(1,1) PRIMARY KEY,
	Power_Name nvarchar(50) NOT NULL,
	Power_Description nvarchar(200) NULL,
);
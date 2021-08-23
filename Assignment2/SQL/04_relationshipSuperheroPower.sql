-- Adding a SuperherosPower table
CREATE TABLE SuperheroPower(
	 HeroID int FOREIGN KEY REFERENCES Superhero(HeroID),
	 PowerID int FOREIGN KEY REFERENCES Superpower(PowerID)
	 CONSTRAINT PK_SuperherosPower PRIMARY KEY (HeroID, PowerID)
);
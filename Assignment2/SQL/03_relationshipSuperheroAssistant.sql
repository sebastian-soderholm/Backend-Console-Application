-- Adding SuperheroID to Assistant table as a foreign key
ALTER TABLE Assistant
ADD HeroID int FOREIGN KEY REFERENCES Superhero(HeroID);
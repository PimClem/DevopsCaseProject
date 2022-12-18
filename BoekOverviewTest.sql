SELECT b.titel,b.auteur, g.genre
from Boek b join Genre g on b.genreId = g.genreId

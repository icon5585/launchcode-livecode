# Studio 15.5.2
# 2/24/20
# Hank DeDona

# 1
SELECT title FROM movies;
# 2
SELECT title, year_released FROM movies ORDER BY year_released DESC;
# 3
SELECT * FROM  directors ORDER BY country ASC; 
# 4
SELECT * FROM  directors ORDER BY country, last_name ASC;
# 5
INSERT INTO directors (first_name, last_name, country) VALUES ('Rob', 'Reiner', 'USA');
COMMIT;
# 6
SELECT director_id, last_name FROM directors WHERE first_name='Rob' AND last_name='Reiner';
# 7
INSERT INTO movies (title, year_released, director_id) VALUES ('The Princess Bride', 1987, 11);
COMMIT;
# 8 
SELECT * FROM movies m INNER JOIN directors d ON m.director_id = d.director_id;
# 9
SELECT * FROM movies m INNER JOIN directors d ON m.director_id = d.director_id ORDER BY d.last_name ASC;
# 10
SELECT d.first_name, d.last_name FROM directors d INNER JOIN movies m ON d.director_id = m.director_id WHERE m.title = 'The Incredibles';
SELECT d.first_name, d.last_name FROM directors d, movies m WHERE d.director_id = m.director_id AND m.title = 'The Incredibles';
# 11
SELECT d.last_name, d.country FROM directors d INNER JOIN movies m ON d.director_id = m.director_id WHERE m.title = 'Roma';
# 12
DELETE FROM movies WHERE movie_id = 11;
COMMIT;
# Note: Directors table *should* be untouched, unless we enable "cascade on delete"
# 13
DELETE FROM directors where director_id = 5;
# Note: You will get a foreign key constraint failure... You can "cascade on delete" to enable this, but it will delete all movies by this director.

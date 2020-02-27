# Studio 16.5 - More SQL
# Hank DeDona
# 2/26/2020

CREATE TABLE book (
   book_id INT AUTO_INCREMENT PRIMARY KEY,
   author_id INT,
   title VARCHAR(255),
   isbn INT,
   available BOOL,
   genre_id INT
);

COMMIT;

CREATE TABLE author (
   author_id INT AUTO_INCREMENT PRIMARY KEY,
   first_name VARCHAR(255),
   last_name VARCHAR(255),
   birthday DATE,
   deathday DATE
);

COMMIT;

CREATE TABLE patron (
   patron_id INT AUTO_INCREMENT PRIMARY KEY,
   first_name VARCHAR(255),
   last_name VARCHAR(255),
   loan_id INT
);

COMMIT;

CREATE TABLE reference_books (
   reference_id INT AUTO_INCREMENT PRIMARY KEY,
   edition INT,
   book_id INT,
   FOREIGN KEY (book_id)
      REFERENCES book(book_id)
      ON UPDATE SET NULL
      ON DELETE SET NULL
);

COMMIT;

INSERT INTO reference_books(edition, book_id)
VALUE (5,32);

COMMIT;

CREATE TABLE genre (
   genre_id INT PRIMARY KEY,
   genres VARCHAR(100)
);

COMMIT;

CREATE TABLE loan (
   loan_id INT AUTO_INCREMENT PRIMARY KEY,
   patron_id INT,
   date_out DATE,
   date_in DATE,
   book_id INT,
   FOREIGN KEY (book_id)
      REFERENCES book(book_id)
      ON UPDATE SET NULL
      ON DELETE SET NULL
);

COMMIT;

# 16.5.2 - Warm up queries
SELECT title, isbn FROM book WHERE genre_id IN (SELECT genre_id from genre where genres = 'Mystery');

SELECT b.title, a.first_name, a.last_name FROM book b INNER JOIN author a ON b.author_id = a.author_id WHERE a.deathday IS NULL;

# 16.5.3 - Loan out a book
# Note: I had to disable safe mode...
SET SQL_SAFE_UPDATES = 0;

# Change available to false for book
UPDATE book SET available=0 WHERE title='The Brutal Telling';
COMMIT;

# Add new row to loan
INSERT INTO loan (patron_id, date_out, book_id) VALUES (6, CURDATE() , 26);
COMMIT;

# Update patron table with loan ID
UPDATE patron SET loan_id = (SELECT MAX(loan_id) FROM loan) WHERE patron_id = 6; 
COMMIT;

# 16.5.4 - Check a book back in
# Change available to true for book
UPDATE book SET available = 1 WHERE title='The Brutal Telling';
COMMIT;

# Update loan table with date_in to today
UPDATE loan SET date_in = CURDATE() where loan_id = 2;	# We'd need to know the loan_id or some other value...
COMMIT;

# 16.5.5 - Wrap up query
SELECT p.first_name, p.last_name, g.genres FROM loan l INNER JOIN patron p ON p.patron_id = l.patron_id 
	INNER JOIN book b ON l.book_id = b.book_id 
    INNER JOIN genre g ON b.genre_id = g.genre_id
    WHERE l.date_in IS NULL;

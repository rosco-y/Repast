BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "SITES" (
	"CatID"	INTEGER NOT NULL,
	"ID"	INTEGER NOT NULL,
	"SiteName"	TEXT NOT NULL,
	"Password"	TEXT NOT NULL,
	PRIMARY KEY("ID","CatID")
);
CREATE TABLE IF NOT EXISTS "Categories" (
	"ID"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"CatName"	TEXT NOT NULL
);
COMMIT;

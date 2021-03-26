-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
CREATE DATABASE napsutes
DEFAULT CHAR SET utf8
COLLATE utf8_hungarian_ci;

-- 3. feladat:
UPDATE regiok
SET regioNEV='Észak-Írország'
WHERE regioNEV='Észak Írország'

-- 4. feladat:
SELECT COUNT(id) AS rekordszam,
AVG(perc) AS atlag
from meresek;

-- 5. feladat:
SELECT ev, SUM(perc)/60 AS orak
FROM meresek INNER JOIN regiok
ON meresek.regioId=regiok.id
WHERE regiok.regioNEV='Anglia'
AND ev BETWEEN 1990 AND 2000
GROUP BY ev
ORDER BY ev DESC;

-- 6. feladat:
SELECT ev, perc, regioNEV AS terulet
FROM meresek INNER JOIN regiok
ON meresek.regioId=regiokid
WHERE ho=2 AND perc>6000
ORDER BY perc DESC;




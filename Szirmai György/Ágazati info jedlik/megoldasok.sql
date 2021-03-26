-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
CREATE DATABASE Formula1 DEFAULT CHARSET=utf8 COLLATE utf8_hungarian_ci

-- 3. feladat:
update nagydijak set korokszama=70 where nev like "Hungarian Grand Prix";

-- 4. feladat:
SELECT vezeteknev, rajtszam, csapatnev, 2019-year(szuletesidatum) as eletkor FROM `pilotak` order by eletkor desc;

-- 5. feladat:
SELECT nev,vezeteknev, keresztnev,versenynap FROM `eredmenyek`
join nagydijak on eredmenyek.nagydijid=nagydijak.id
join pilotak
on pilotak.id=eredmenyek.pilotaid
WHERE helyezes=1
order by versenynap asc;

-- 6. feladat:
SELECT  concat(keresztnev,' ',  vezeteknev) as nev, csapatnev, sum(pontszam) as osszpontszam FROM `eredmenyek` 
join pilotak
on pilotak.id=eredmenyek.pilotaid
group by vezeteknev, keresztnev, csapatnev
order by osszpontszam desc
limit 3;


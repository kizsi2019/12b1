-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
Create database formula1


-- 3. feladat:
Update nagydijak set korokszama=70 WHERE nev Like"Hungarian%"

-- 4. feladat:
SELECT vezeteknev, rajtszam, csapatnev, 2019-year(szuletesidatum) AS eletkor FROM `pilotak` WHERE 1 ORDER by eletkor DESC

-- 5. feladat:
SELECT nagydijak.nev , vezeteknev, keresztnev, versenynap FROM eredmenyek JOIN nagydijak ON eredmenyek.nagydijid=nagydijak.id JOIN pilotak ON pilotak.id=eredmenyek.pilotaid WHERE helyezes=1 ORDER by versenynap ASC

-- 6. feladat:
SELECT concat(keresztnev,' ', vezeteknev) as nev, csapatnev, sum(pontszam) as osszpontszam FROM `eredmenyek` JOIN pilotak ON pilotak.id=eredmenyek.pilotaid GROUP BY vezeteknev, keresztnev, csapatnev ORDER BY osszpontszam DESC LIMIT 3

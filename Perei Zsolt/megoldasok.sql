A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

8. feladat: 
CREATE DATABASE konyvtaraksokadik
DEFAULT charset    = utf8
COLLATE utf8_hungarian_ci;

9. feladat:
*importálás*

10. feladat:
UPDATE megyek SET megyeNev="Budapest" WHERE megyeNev="BP"

11. feladat:
SELECT konyvtarNev, irsz from `konyvtarak` WHERE konyvtarNev like"%Szakkönyvtár%"

12. feladat:
SELECT konyvtarNev, irsz, cim FROM `konyvtarak` 
WHERE irsz LIKE "1%"

13. feladat:
SELECT telepNev
COUNT(id) AS konyvtarDarab FROM konyvtarak
INNER JOIN telepulesek
ON konyvtarak.irsz=telepulesek.irsz
GROUP BY telepNev HAVING konyvtarDarab >=7; 

14. feladat:
SELECT megyeNev COUNT(irsz) AS telepulesDarab FROM telepulesek 
INNER JOIN megyek
ON telepulesek.megyeId=megyek.id
WHERE irsz NOT LIKE "1%"
GROUP BY megyeNev 
ORDER BY telepulesDarab DESC; 


-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
create database napelem
default char set utf8
collate utf8_hungarian_ci;

-- 3. feladat:
update regiok
set regioNev='Észak-Írország'
where regioNev='Észak Írország';


-- 4. feladat:
select COUNT(id) as rekordszam,
AVG(perc) as atlag
from meresek;

-- 5. feladat:
select ev, sum(perc)/60 as orak
from meresek inner join regiok
on meresek.regioId=regiok.id
where regiok.regioNev='Anglia'
and ev between 1990 and 2000
group by ev
order by ev desc;

-- 6. feladat:
select ev, perc, regioNev as terulet
from meresek inner join regiok
on meresek.regioId=regiok.id
where ho=2 and perc>6000
order by perc desc;

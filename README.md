# Nyilvantartas
A programunk célja a portai nyilvántartás segítése.
Számon tartja az erkező személy/jármű fontos adatait.

A program egy főmenüvel indul, ahol 0, 1 vagy 2 adható meg, ha:

- 0-át adunk meg, a program leáll,

- 1-est adunk meg, akkor a nylvántartó (rögzítő) funkciót tudjuk elérni ennek menüjében:
  * csv formátumú fáljba rőgzítjük az adatokat
  * 1-es megadásával személy adatai rögzíthetőek (Neve és személy azonosító okmány száma);
  * 2-es megadásával jármű adatai rögzíthetőek (Autó típusa és rendszáma);
  * 0 megadásával visszalép a főmenübe;

- 2-est adunk meg, akkor a kereső funkciót érjük el:
  * Ha beírunk egy adatot, és ha benne van, kiírja a többi hozzátartozó adatot
  * Ha nincs benne az adatok között, kiírja hogy nem szerepel ilyen adat
  * Ha még nincs nyilvántartás, kiírja hogy nincs nyilvántartás és vissza dob a főmenübe

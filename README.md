# Nyilvántartás
A programunk célja a portai nyilvántartás segítése.
Számon tartja az erkező személy/jármű fontos adatait.

A program egy főmenüvel indul, ahol 0, 1 vagy 2 adható meg, ha:

- 0-át adunk meg, a program leáll,

- 1-est adunk meg, akkor a nylvántartó (rögzítő) funkciót tudjuk elérni ennek menüjében:
  * a program létrehoz egy "nyilvantartas.csv" nevű fáljt, és abba rőgzítjük az adatokat
  * 1-es megadásával személy adatai rögzíthetőek (Neve és személy azonosító okmány száma);
  * 2-es megadásával jármű adatai rögzíthetőek (Autó típusa és rendszáma);
  * 0 megadásával visszalép a főmenübe;

- 2-est adunk meg, akkor a kereső funkciót érjük el, ami a csv fájlon megy vegig:
  * Ha beírunk egy adatot, és ha benne van a fáljban, kiírja a többi hozzátartozó adatot
  * Ha a megadott adat nem szerepel a fáljban, kiírja hogy nem szerepel ilyen adat
  * Ha még nincs nyilvántartás, kiírja hogy nincs nyilvántartás és vissza dob a főmenübe

Ha szöveget vagy rossz számot ad meg bármely menüpontnál, akkor a program azt jelzi

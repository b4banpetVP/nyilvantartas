# Nyilvántartási Rendszer
A programunk célja a portai nyilvántartás segítése.
Számon tartja az érkező személy/jármű fontos adatait.

A program egy főmenüvel indul, ahol 0, 1 vagy 2 adható meg, ha:

- 0-át adunk meg, a program leáll,

- 1-est adunk meg, akkor a nyilvántartó (rögzítő) funkciót tudjuk elérni ennek menüjében:
  * a program létrehoz egy "nyilvantartas.csv" nevű fájlt, és abba rögzítjük az adatokat
  * 1-es megadásával személy adatai rögzíthetőek (neve és személyazonosító okmány száma);
  * 2-es megadásával jármű adatai rögzíthetőek (autó típusa és rendszáma);
  * 0 megadásával visszalép a főmenübe;

- 2-est adunk meg, akkor a kereső funkciót érjük el, ami a csv fájlon megy végig:
  * Ha beírunk egy adatot, és ha benne van a fájlban, kiírja a többi hozzátartozó adatot
  * Ha a megadott adat nem szerepel a fájlban, kiírja, hogy nem szerepel ilyen adat
  * Ha még nincs nyilvántartás, kiírja, hogy nincs nyilvántartás, és visszadob a főmenübe

Ha szöveget vagy rossz számot ad meg bármely menüpontnál, akkor a program azt jelzi, és újra bekéri az adatot.
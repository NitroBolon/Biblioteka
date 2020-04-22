# Biblioteka
Projekt systemu wspierającego pracę biblioteki (WPF)

Aplikacja pomagająca w organizacji pracy biblioteki. 
Umożliwia obsługę wypożyczania książek, obsługę klientów, obsługę katalogu oraz naliczania kar. 
Funkcjonalność: 
  - dodawanie, edytowanie, usuwanie, przeglądanie książek 
  - dodawanie, edytowanie, usuwanie, przeglądanie użytkowników 
  - możliwość naliczania kar za opóźnienia (po upływie terminu generowany pdf) 
  - możliwość wypożyczenia książek 

Tabele: 
  - Uzytkownicy (indeks, imię, nazwisko, numer telefonu) 
  - Ksiazki (indeks, tytuł, autor, rok wydania) 
  - Wypozyczenia (indeks, indeks użytkownika, indeks książki) 
  - Kary (indeks wypożyczenia, data wypożyczenia, data zwrotu, kara) 
  
  Użytkownik może wypożyczyć wiele książek. 
  Tabela Kary przechowuje listę wypożyczeń z datami - przekroczenie dozwolonego czasu wypożyczenia powoduje naliczenie kary. 
  Tabela Kary przechowuje wszystkie wypożyczenia, plus daty wypożyczenia/zwrotu i ewentualne naliczone kary. 
  
  Interfejs: 
    Książki 
    W wyznaczonym do tego miejscu wyświetlana jest lista książek. Po kliknięciu na odpowiedni przycisk 
    można dodać lub usunąć pozycję, a po kliknięciu na pozycję z listy można ją edytować. 
    
    Użytkownicy 
    W wyznaczonym do tego miejscu wyświetlana jest lista użytkowników. Po kliknięciu na odpowiedni przycisk można dodać 
    lub usunąć pozycję, a po kliknięciu na pozycję z listy można ją edytować.
    
    Naliczanie kar 
    W wyznaczonym do tego miejscu widoczne są wszystkie pozycje tabeli Kary, które przekroczyły dozwolony czas wypożyczenia. 
    Generowana jest wiadomość i naliczana jest kara. Obok jest przycisk umożliwiający wyzerowanie kary i ustawienie 
    daty zwrotu, jeżeli książka została zwrócona. 
    
    Wypożyczenia 
    W wyznaczonym do tego miejscu widoczne są wszystkie wypożyczenia. 
    Można dodać kolejny przypadek wypożyczenia lub zwrócić książkę, jeśli książka była trzymana dłużej niż 30 dni, 
    wtedy pokazuje nam się strona naliczania kar (pokazana kara konkretnego klienta), klient musi wyregulować karę, 
    po tym wypożyczenie książki przebiega pomyślnie. 


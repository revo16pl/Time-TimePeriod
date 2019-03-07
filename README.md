## Implementacja typów `Time`, `TimePeriod` w CSharp

###### Zadanie ma charakter ćwiczebny. W Bibliotekach C# Dostępne są gotowe struktury/klasy realizująCe (Prawdopodobnie lepiej) przedstawione założenia (Datetime, Datetimeoffset, Timespan).

###  Problem, cel
Zaprogramuj, wzajemnie powiązane ze sobą struktury Time oraz TimePeriod, Odpowiadające kolejno: punktowi w czasie i okresie w czasie.

#### Struktura `Time`

- zmienna typu `Time` opisuje punkt w czasie, w przedziale` 00:00:00 … 23:59:59`

- wnętrzną reprezentacją czasu są pola typu `byte`: `Hours`, `Minutes`, `Seconds`  - properties

- zapewniona została niezmienniczość (ang. immutable) tworzonych zmiennych typu `Time`

- zapewniono różne warianty konstrukcji w tym dla parametru typu `string`

- zaimplementowano standardową reprezentację tekstową czasu (w postaci: `hh:mm:ss`) – i przeciążenie metody `ToString()`

- zaimplementowano interfejsy `IEquatable<Time>` oraz `IComparable<Time>` przeciażono operatory relacyjne (==, !=, <, <=, >, >=)

- zapewniono działania arytmetyczne na czasie i przeciażenie operatorów

#### Struktura `TimePeriod`

- zmienna typu T`imePeriod` reprezentuje długość odcinka w czasie (odległość między dwoma punktami czasowymi, czas trwania),

- zapewniona została„zewnętrzną reprezentację w postaci `h:m:s` - zrealizowana jako`long`

- zapewniona została niezmienniczość (ang. immutable) tworzonych zmiennych typu `TimePeriod`

- Zapewniono różne warianty konstrukcji i zgłaszanie wyjatków w sytuacjach błędnych

- zaimplementowano  reprezentację tekstową upływu czasu (w postaci:` hhh:mm:ss`) – przeciążono metodę `ToString()` z dopuszczalnym zapisem `129:58:12`

- zaimplementowano interfejsy I`Equatable<TimePeriod>` oraz `IComparable<TimePeriod>`, przeciążono operatory relacyjne (`==`, `!=`, `<`, `<=`, `>`, `>=`),

- zapewniono działania arytmetyczne na odcinkach czasowych 

---

##### Aby przetestować poprawność zaprojektowanych struktur stworzono odpowiednie testy jednostkowe.

##### zaprogramowana biblioteka użyta została do stworzenia bardzo prostego programu "Stoper" w WinForm








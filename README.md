# APBD_Projekt

1. problem uznawania przychodów
Nasza aplikacja będzie dotyczyć problemu związanego z finansami, znanego jako "problem uznawania przychodów".
Uznawanie przychodów to powszechny problem w systemach biznesowych. Chodzi o to, kiedy można faktycznie zapisać otrzymane
pieniądze w księgach i potraktować jako przychód firmy. Jeśli sprzedamy komuś filiżankę kawy, to sytuacja jest prosta: otrzymujemy
kawę, bierzemy pieniądze i od razu możemy traktować otrzymane pieniądze jako przychód.
Jednak w przypadku wielu innych rzeczy sprawy się komplikują. Powiedzmy, że płacisz zaliczkę danej osoba, aby przez cały kolejny
rok wykonywała dla Ciebie pewne czynności. Nawet jeśli zapłacisz jej dziś jakąś absurdalną opłatę, nie może być ona od razu
zapisana w księgach jako przychód, ponieważ usługa ma być świadczona przez cały rok. Jednym z podejść może być uwzględnienie
tylko jednej dwunastej tej opłaty na każdy miesiąc w roku, ponieważ możesz zrezygnować z umowy po miesiącu, kiedy zdasz sobie
sprawę, że np. dana osoba nie jest w stanie wykonać powierzonych jej zadań.
Zasady uznawania przychodów są zróżnicowane i zmienne. Niektóre są ustalane przez przepisy, inne przez standardy zawodowe, a
jeszcze inne przez politykę firmy. Śledzenie przychodów okazuje się być dość skomplikowanym problemem.
W rzeczywistości niewłaściwe uznawanie przychodów było przyczyną kilku dużych skandali korporacyjnych, takich jak Enron i
WorldCom. Firmy te stosowały różne taktyki, aby fałszywie przedstawiać swoje kondycje finansowe, co prowadziło do poważnych
konsekwencji prawnych i strat finansowych dla inwestorów. Dlatego dokładne i zgodne z przepisami uznawanie przychodów jest
kluczowe dla utrzymania przejrzystości i zaufania na rynkach finansowych.
2. Kontekst
Tworzymy aplikację REST API - System Uznawania Przychodów dla dużej korporacji ABC.
3. Wymagania funkcjonalne
Aby opracować system uznawania przychodów, musimy upewnić się, że odpowiednio rozpoznaje przychody dla różnych typów
produktów. Powinniśmy również umożliwić użytkownikowi następują funkcje.
3.1. Zarządzanie klientami
Przypadki użycia:
Chcielibyśmy przechowywać informacje o klientach, którzy mogą być zarówno osobami fizycznymi, jak i firmami. Dla osób fizycznych
musimy przechowywać imię, nazwisko, adres, email, numer telefonu i PESEL (Polski Numer Identyfikacyjny). Dla firm musimy
przechowywać nazwę firmy, adres, email, numer telefonu i numer KRS (Numer Krajowego Rejestru Sądowego). Wszystkie
wymienione dane są wymagane.
Potrzebujemy możliwości dodawania, aktualizacji i usuwania klientów. Dla klientów indywidualnych numer PESEL nie może być
zmieniany po jego wprowadzeniu. Podobnie w przypadku firm, numer KRS nie może być zmieniany po jego wprowadzeniu.
Usuwając dane o kliencie indywidualnym, wykonujemy miękkie usunięcie. Oznacza to, że nadpisujemy dane w bazie, ale
zachowujemy sam rekord w bazie danych. Dane o firmach nie mogą być usuwane.

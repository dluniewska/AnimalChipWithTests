# AnimalChipWithTests

## Lista wszystkich testów
<p>
    <img src="https://user-images.githubusercontent.com/72083113/120903637-a6e5fc80-c647-11eb-81e7-dd9b0486e3c2.png" />
    <br>
</p>

**Autorzy:**
1. Daria Łuniewska
2. Paulina Ciach

## Architektura systemu i oprogramowania 

* Visual Studio
* .NET Core 5.0
* xUnit

## Klasa AnimalsStorage i Interfejs IAnimalSTorage służące do Mockowania kontrolera
#### AnimalStorage
<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904375-51f8b500-c64c-11eb-8484-3f8938a17723.png" />
    <br>
</p>

#### IAnimalStorage

<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904422-87050780-c64c-11eb-8974-996e4fa73a86.png" />
    <br>
</p>

## Testy kontrolera:
<p>
    <img src="https://user-images.githubusercontent.com/72083113/120903867-0ee91280-c649-11eb-8154-3e751337448c.png" />
    <br>
</p>
<p>
    <img src="https://user-images.githubusercontent.com/72083113/120903887-32ac5880-c649-11eb-9589-22f4044651d1.png" />
    <br>
</p>

## Testy itegracyjne
#### Klasa CustomWebApplicationFactory służąca do Tworzenia InMemoryDatabase, w celu pominięcia operowania na prawdziwej bazie:

<p>
    <img src="https://user-images.githubusercontent.com/72083113/120903989-d72e9a80-c649-11eb-9b11-0cbc60dcc13b.png" />
    <br>
</p>

#### Klasa FakeUserFilter służąca do tworzenie sztucznego użytkownika

<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904036-28d72500-c64a-11eb-9b04-a7934a751351.png" />
    <br>
</p>

#### Testowanie autentykacji przy pomocy klasy TestAuthHandler dziedziczącej po AuthenticationHandler 

<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904113-a3a04000-c64a-11eb-838b-155b4e22ff4c.png" />
    <br>
</p>

<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904127-c6325900-c64a-11eb-95d1-680cf4cc913d.png" />
    <br>
</p>

<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904147-dc401980-c64a-11eb-8342-a078802f46b4.png" />
    <br>
</p>

##Test Endpointów
<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904171-072a6d80-c64b-11eb-8bc8-1aa47898eda1.png" />
    <br>
</p>

## Testy jednostkowe przykładowych
#### Testy klasy ChipGenerator

<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904208-540e4400-c64b-11eb-95a4-9d2f37fdcf7d.png" />
    <br>
</p>
<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904226-6d16f500-c64b-11eb-8e9d-ad2cd6ccaef2.png" />
    <br>
</p>

#### Testy klasy NotDb operującej na modelu Animal

<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904293-c67f2400-c64b-11eb-833a-20206b0f1439.png" />
    <br>
</p>
<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904322-eadb0080-c64b-11eb-98f9-2c97f62664ec.png" />
    <br>
</p>
<p>
    <img src="https://user-images.githubusercontent.com/72083113/120904339-03e3b180-c64c-11eb-8f28-5f007cbddeed.png" />
    <br>
</p>



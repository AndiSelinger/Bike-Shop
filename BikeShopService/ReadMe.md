# Bike-Shop

BikeShop ist ein Webshop f�r Motorradliebhaber, basierend in Linz.


Zu entwickeln war das Backend-System mit der Datenbank-Anbindung, eine Web-Anwendung zur Verwaltung der Stammdaten der Projekte.



## Datenmodell und Datenbank

Das Datenmodell f�r ***BikeShop*** hat folgenden Aufbau:


***BIKE***

|Name|Type|MaxLength|Nullable|Unique|Db-Field|Access|
|------|------|-----------|----------|------|--------|------|
|Id | int |---|---  |---|  Yes | R |
| RowVersion | byte[] | --- | No | --- |  Yes | R |
| Brand | String | 128 | No |  No | Yes | RW |
| Type | string | 128 | Yes | No | Yes | RW |
| Model | string | 128 | No | No | Yes | RW |
| Vin | string | --- | No | Yes | Yes | RW |
| Power | int | --- | No | No | Yes | RW |
| CCM | int | --- | No | No | Yes | RW |
| Color | string | 64 | Yes | No | Yes | RW |
| ProductionYear | DateTime | --- | No | No | Yes | RW |
| Price | int | --- | No | No | Yes | RW |
| SpecialModel | bool | --- | Yes | No | No | RW |
| LastService | Bool | --- | Yes | No | No | RW |
| ServiceNeeded | Bool | --- | No* | No | No | RW |
| Mileage | int | --- | No | No | Yes | RW |
| ImageLink | string | --- | Yes | No | No | RW |
| ShopId | int | --- | No | No | Yes | RW |


***SHOP***

|Name|Type|MaxLength|Nullable|Unique|Db-Field|Access|
|------|------|-----------|----------|------|--------|------|
|Id | int |---|---  |---|  Yes | R |
| RowVersion | byte[] | --- | No | --- |  Yes | R |
| Location | String | ---| No |  Yes | Yes | RW |
| Adress | string | --- | No | Yes | Yes | RW |
| PhoneNumber| string | --- | No | No | Yes | RW |
| GoogleAdressString | string | --- | Yes | No | Yes | RW |


*calculated field


#### Business-Logik

Das System muss einige Gesch�ftsregeln umsetzen. Diese Regeln werden im Backend implementiert und m�ssen mit UnitTests �berpr�ft werden.

> **HINWEIS:** Unter **Gesch�ftsregeln** (Business-Rules) versteht man **elementare technische Sachverhalte** im Zusammenhang mit Computerprogrammen.

F�r den ***BikeShop.Logic*** sind folgende Regeln definiert:

Die **VIN** muss exakt 17 Zeichen lang sein.
**Power** darf nicht kleiner sein als 0.
**CCM** darf nicht kleiner sein als 0.
**Price** darf nicht kleiner sein als 0.

Das Motorrad muss j�nger sein als 1900 und kein Motorrad hat einen Kilometerz�hlerstand unter 0,00 KM. Servicejahr darf nicht unter Produktionsjahr sein.


#### RESTful-Service

REST-Service Zugriff f�r zwei Entit�ten ***'Bike' und 'Shop'*** mit folgende Komponenten:

- Zwei ***Modelle*** f�r die Entit�ten ***'Bike' und 'Shop'***.

- Zwei ***Kontroller*** mit den folgenden Operationen

- Abfrage alle Bikes

- Abfrage einer Vin mit der Id

- Erstellen eines Bikes

- �nderung eines Bikes

- L�schen eines Bikes

 Abfrage aller Bikes anhand der Parameter bei dem ***BikeShop Kontroller*** implementieren:

- ShopId

### Angular-Anwendung


- Erstellen der Komponenten
- Erstellen des Service
- Designen der Komponententeile
- Erstellung der Applikation durch AngularClient
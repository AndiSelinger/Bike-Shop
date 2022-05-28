



BikeShop ist ein Webshop für Motorradliebhaber, basierend in Linz.


Zu entwickeln war das Backend-System mit der Datenbank-Anbindung, eine Web-Anwendung zur Verwaltung der Stammdaten der Projekte.



## Datenmodell und Datenbank

Das Datenmodell für ***BikeShop*** hat folgenden Aufbau:


***BIKE***

|Name|Type|MaxLength|Nullable|Unique|Db-Field|Access|
|------|------|-----------|----------|------|--------|------|
|Id | int |---|---  |---|  Yes | R |
 | RowVersion | byte[] | --- | No | --- |  Yes | R |
 | Brand | String | 128 | No |  No | Yes | RW |
  | Type | string | 128 | No | No | Yes | RW |
  | Model | string | 128 | No | No | Yes | RW |
  | Vin | string | --- | No | Yes | Yes | RW |
  | Power | int | --- | No | No | Yes | RW |
  | CCM | int | --- | No | No | Yes | RW |
  | Color | string | 64 | No | No | Yes | RW |
  | ProductionYear | DateTime | --- | No | No | Yes | RW |
  | Price | int | --- | No | No | Yes | RW |
  | SpecialModel | bool | --- | Yes | No | No | RW |
  | LastService | Bool | --- | Yes | No | No | RW |
  | ServiceNeeded | Bool | --- | Yes* | No | No | RW |
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

Das System muss einige Geschäftsregeln umsetzen. Diese Regeln werden im Backend implementiert und müssen mit UnitTests überprüft werden.

> **HINWEIS:** Unter **Geschäftsregeln** (Business-Rules) versteht man **elementare technische Sachverhalte** im Zusammenhang mit Computerprogrammen.

Für den ***BikeShop.Logic*** sind folgende Regeln definiert:

Die **VIN** muss exakt 17 Zeichen lang sein.
**Power** darf nicht kleiner sein als 0.
**CCM** darf nicht kleiner sein als 0.
**Price** darf nicht kleiner sein als 0.

Das Motorrad muss jünger sein als 1900 und kein Motorrad hat einen Kilometerzählerstand unter 0,00 KM. Servicejahr darf nicht unter Produktionsjahr sein.


#### RESTful-Service

REST-Service Zugriff für zwei Entitäten ***'Bike' und 'Shop'*** mit folgende Komponenten:

- Zwei ***Modelle*** für die Entitäten ***'Bike' und 'Shop'***.

- Zwei ***Kontroller*** mit den folgenden Operationen

- Abfrage alle Bikes

- Abfrage einer Vin mit der Id

- Erstellen eines Bikes

- Änderung eines Bikes

- Löschen eines Bikes

 Abfrage aller Bikes anhand der Parameter bei dem ***BikeShop Kontroller*** implementieren:

- ShopId

### Angular-Anwendung


- Erstellen der Komponenten
- Erstellen des Service
- Designen der Komponententeile
- Erstellung der Applikation durch AngularClient



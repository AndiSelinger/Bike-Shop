export class Bike {

  public brand: string;
  public type: string;
  public model: string;
  public vin: string;
  public power: number;
  public ccm: number;
  public productionYear: Date;
  public price: number;
  public mileage: number;
  public imageLink: string;

  constructor(brand: string, type: string, model: string, vin: string, power: number, ccm: number, productionYear: Date, price: number, mileage: number, imageLink: string) {
    this.brand = brand;
    this.type = type;
    this.model = model;
    this.vin = vin;
    this.power = power;
    this.ccm = ccm;
    this.productionYear = productionYear;
    this.price = price;
    this.mileage = mileage;
    this.imageLink = imageLink;
  }
}

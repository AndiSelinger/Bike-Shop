export class Bike {

  private brand: string;
  private type: string;
  private model: string;
  private vin: string;
  private power: number;
  private ccm: number;
  private productionYear: Date;
  private price: number;
  private mileage: number;
  private imageLink: string;

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

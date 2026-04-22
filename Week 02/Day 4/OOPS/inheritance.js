class Vehicle{
constructor(brand,speed){
this.brand=brand
this.speed=speed
}
displayInfo(){
return "Brand: "+this.brand+", Speed: "+this.speed
}
}
class Car extends Vehicle{
constructor(brand,speed,fuelType){
super(brand,speed)
this.fuelType=fuelType
}
showCarDetails(){
return "Fuel Type: "+this.fuelType
}
}
let c=new Car("Toyota",160,"Petrol")
console.log(c.displayInfo())
console.log(c.showCarDetails())

/*one class using another class properties*/
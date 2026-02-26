class Payment{
pay(amount){
return "Processing payment"
}
}
class CreditCardPayment extends Payment{
pay(amount){
return "Paid ₹"+amount+" using Credit Card"
}}
class UPIPayment extends Payment{
pay(amount){
return "Paid ₹"+amount+" using UPI"
}}
class CashPayment extends Payment{
pay(amount){
return "Paid ₹"+amount+" using Cash"
}}
let p1=new CreditCardPayment()
let p2=new UPIPayment()
let p3=new CashPayment()

console.log(p1.pay(500))
console.log(p2.pay(800))
console.log(p3.pay(300))

/*Polymorphims: same method name, different behaviour*/ 
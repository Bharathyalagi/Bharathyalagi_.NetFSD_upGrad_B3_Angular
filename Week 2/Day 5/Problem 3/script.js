function saveEvent(e){
e.preventDefault()
let form = e.target
if(form.checkValidity()){

alert("Event added successfully")

let modalEl = document.getElementById("eventModal")
let modalObj = bootstrap.Modal.getInstance(modalEl)
modalObj.hide()

form.reset()
form.classList.remove("was-validated")

}
else{
form.classList.add("was-validated")
}

}
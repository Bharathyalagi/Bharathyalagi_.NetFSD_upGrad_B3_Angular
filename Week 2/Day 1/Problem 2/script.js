function validateName() {
    let name = document.getElementById("name").value;
    if (name.trim() === "") {
        document.getElementById("nameError").innerText = "Name cannot be empty";
    } else {
        document.getElementById("nameError").innerText = "";
    }
}

function validateEmail() {
    let email = document.getElementById("email").value;
    if (!email.includes("@")) {
        document.getElementById("emailError").innerText = "Invalid Email";
    } else {
        document.getElementById("emailError").innerText = "";
    }
}

function validateAge() {
    let age = document.getElementById("age").value;
    if (age <= 18) {
        document.getElementById("ageError").innerText = "Age must be above 18";
    } else {
        document.getElementById("ageError").innerText = "";
    }
}

function submitForm() {
    let name = document.getElementById("name").value;
    let email = document.getElementById("email").value;
    let age = document.getElementById("age").value;

    if (name && email.includes("@") && age > 18) {
        sessionStorage.setItem("userName", name);
        sessionStorage.setItem("userEmail", email);
        sessionStorage.setItem("userAge", age);
        alert("User data stored in sessionStorage");
    } else {
        alert("Please correct the errors before submitting");
    }
}
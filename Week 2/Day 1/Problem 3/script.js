window.onload = function () {
    displayHistory();
};

function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(successCallback, errorCallback);
    } else {
        alert("Geolocation not supported");
    }
}

function successCallback(position) {
    let lat = position.coords.latitude;
    let lon = position.coords.longitude;

    document.getElementById("output").innerText =
        "Latitude: " + lat + " , Longitude: " + lon;

    let history = JSON.parse(localStorage.getItem("locations")) || [];

    history.unshift({ latitude: lat, longitude: lon });

    if (history.length > 5) {
        history.pop();
    }

    localStorage.setItem("locations", JSON.stringify(history));

    displayHistory();
}

function errorCallback(error) {
    if (error.code === 1) alert("Permission Denied");
    else if (error.code === 2) alert("Location Unavailable");
    else if (error.code === 3) alert("Timeout");
}

function displayHistory() {
    let history = JSON.parse(localStorage.getItem("locations")) || [];
    let list = document.getElementById("history");
    list.innerHTML = "";

    history.forEach(function (item) {
        let li = document.createElement("li");
        li.textContent = "Lat: " + item.latitude + ", Lon: " + item.longitude;
        list.appendChild(li);
    });
}
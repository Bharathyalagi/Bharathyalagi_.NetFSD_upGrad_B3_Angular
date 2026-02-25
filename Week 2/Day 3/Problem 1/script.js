const output = document.getElementById("output")
const url = "https://api.open-meteo.com/v1/forecast?latitude=12.97&longitude=77.59&current_weather=true"
const formatWeather = data => {
    const temp = data.current_weather.temperature
    const wind = data.current_weather.windspeed
    const time = data.current_weather.time
    return `<p><strong>Temperature:</strong> ${temp} °C</p>
            <p><strong>Wind Speed:</strong> ${wind} km/h</p>
            <p><strong>Time:</strong> ${time} km/h</p>`

}

export const getWeatherWithPromise = () => {
    output.innerHTML = "Loading.............."
    fetch(url).then(response => {
        if (!response.ok) {
            throw new Error("Network failed")
        }
        return response.json()
    })
    .then(data => {
        output.innerHTML = formatWeather(data)
    })
    .catch(error => {
        output.innerHTML = `Error: ${error.message}`
    })
}
export const getWeatherAsync = async () => {
    output.innerHTML = "Loading........."
    try {
        const response = await fetch(url)
        if (!response.ok) {
            throw new Error("Network response failed")
        }
        const data = await response.json()
        output.innerHTML = formatWeather(data)
    } catch (error) {
        output.innerHTML = `Error: ${error.message}`
    }
}
window.getWeatherWithPromise = getWeatherWithPromise
window.getWeatherAsync = getWeatherAsync
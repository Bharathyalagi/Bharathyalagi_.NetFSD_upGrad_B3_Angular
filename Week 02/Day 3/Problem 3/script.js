const button = document.getElementById("themeBtn")

const applyTheme = theme => {
    if (theme === "dark") {
        document.body.classList.add("dark")
    } else {
        document.body.classList.remove("dark")
    }
}
const toggleTheme = () => {
    const currentTheme = localStorage.getItem("theme") || "light"
    const newTheme = currentTheme === "light" ? "dark" : "light"
    localStorage.setItem("theme", newTheme)
    applyTheme(newTheme)
}
const initializeTheme = () => {
    const savedTheme = localStorage.getItem("theme") || "light"
    applyTheme(savedTheme)
}
button.addEventListener("click", toggleTheme)
initializeTheme()
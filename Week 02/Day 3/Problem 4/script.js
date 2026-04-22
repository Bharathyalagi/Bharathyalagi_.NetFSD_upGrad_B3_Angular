const input = document.getElementById("taskInput")
const addBtn = document.getElementById("addBtn")
const list = document.getElementById("taskList")
const createTaskElement = taskText => {
    const li = document.createElement("li")
    li.innerHTML = `
        <span class="task-text">${taskText}</span>
        <button class="complete-btn">Complete</button>
        <button class="delete-btn">Delete</button>
    `
    return li
}
const addTask = () => {
    const value = input.value.trim()
    if (!value) return

    const taskElement = createTaskElement(value)
    list.appendChild(taskElement)
    input.value = ""
}
const handleListClick = event => {
    const target = event.target
    if (target.classList.contains("delete-btn")) {
        target.parentElement.remove()
    }
    if (target.classList.contains("complete-btn")) {
        const text = target.parentElement.querySelector(".task-text")
        text.classList.toggle("completed")
    }
}
addBtn.addEventListener("click", addTask)
list.addEventListener("click", handleListClick)